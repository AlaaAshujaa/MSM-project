import 'dart:convert';
import 'package:booksmarket/Models/Category_Model.dart';
import 'package:booksmarket/Models/ProductModel.dart';
import 'package:booksmarket/Models/Productt.dart';
import 'package:booksmarket/Models/ProfileModel.dart';
import 'package:booksmarket/Models/Shop_Model.dart';
import 'package:booksmarket/Screens/LoginScreen.dart';
import 'package:booksmarket/Screens/MainScreen.dart';
import 'package:booksmarket/Screens/ShopScreen.dart';
import 'package:flutter_spinkit/flutter_spinkit.dart';
import 'package:booksmarket/Screens/HomeScreen.dart';
import 'package:flutter/material.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'package:http/http.dart' as http;
import 'package:shared_preferences/shared_preferences.dart';

import '../constants.dart';

class Service {
  Future<void> LoginData(
      BuildContext context, String email, String password) async {
    var url = "https://bbooksmarket.000webhostapp.com/bookMarketApi/login.php?"
        "user_email="
        "${email}&user_password=${password}";

    var response = await http
        .get(url)
        .timeout(Duration(
          seconds: 10,
        ))
        .catchError((e) async {
      // print("error"+e);
    });
    if (response.statusCode == 200) {
      response.body;
      print(response.body);
      final json = jsonDecode(response.body);
      print("object${json["response"]['status']}");
      int state = int.parse(json["response"]['status']);
      print(state);

      if (state == 1) {
        print(json["response"]['user_type']);
        SharedPreferences prefs = await SharedPreferences.getInstance();
        await prefs.setInt('status', int.parse(json["response"]['status']));
        await prefs.setInt('userid', int.parse(json["response"]['user_id']));
        await prefs.setString('username', json["response"]['user_name']);
        await prefs.setString('user_email', json["response"]['user_email']);
        await prefs.setString('user_img', json["response"]['user_img']);
        await prefs.setInt(
            'userType', int.parse(json["response"]['user_type']));

        print(prefs.getInt("status"));
        print("alitow${prefs.getInt("userType")}");
        Navigator.of(context).pushReplacement(
          new MaterialPageRoute(
            builder: (context) => new HomeScreen(
              prefs.getInt("userType"),
              prefs.getInt("userid"),
              prefs.getString("username"),
              prefs.getString("user_email"),

              prefs.getString("user_img"),
            ),
          ),
        );
      } else {
        confirm(context, json["response"]['message']);
      }
    }
  }

  void confirm(BuildContext context, String msg) {
    bool _loading = false;
    AlertDialog alertDialog = new AlertDialog(
      content: new Text("${msg}"),
      actions: <Widget>[
        new Center(
          child: RaisedButton(
            child: new Text("موافق", style: new TextStyle(color: Colors.black)),
            color: kthirdColor,
            onPressed: () => Navigator.pop(context),
          ),
        ),
      ],
    );

    showDialog(context: context, child: alertDialog);
  }

  Future<void> addData(BuildContext context, String name, String img,
      String pass, String email, String phon, String adress) async {
    String url =
        "https://bbooksmarket.000webhostapp.com/bookMarketApi/addUser.php";
    var response = await http
        .post(url, body: {
          "user_name": name,
          "user_img": img,
          "user_password": pass,
          "user_email": email,
          "user_phonenumber": phon,
          "user_address": adress,
          "user_type": '1',
        })
        .timeout(Duration(
          seconds: 10,
        ))
        .catchError((e) async {});
    if (response.statusCode == 200) {
      response.body;
      print(response.body);
      final json = jsonDecode(response.body);
      print("object${json["response"]['status']}");
      int state = json["response"]['status'];
      print(state);
      if (state == 1) {
        Fluttertoast.showToast(
            msg: "تم انشاء الحساب بنجاح\n قم الان بتسجيل دخولك",
            toastLength: Toast.LENGTH_SHORT,
            gravity: ToastGravity.CENTER,
            timeInSecForIosWeb: 1,
            backgroundColor: kthirdColor,
            textColor: Colors.white,
            fontSize: 16.0);

        Navigator.pop(context);
        /* confirm(context, json["response"]['message']);
        Navigator.of(context).push(
            new MaterialPageRoute(builder: (context) =>  LoginScreen()));*/
      } else {
        confirm(context, json["response"]['message']);
      }
    }
  }

  List<CategoryModel> cateList = [];
  Future<void> loadCateList() async {
    String url =
        "https://bbooksmarket.000webhostapp.com/bookMarketApi/FetchSection.php";

    var response = await http.get(url);

    var jsondata = jsonDecode(response.body);

    if (response.statusCode == 200) {
      print(response.body);
      List<CategoryModel> data = jsondata
          .map<CategoryModel>((data) => CategoryModel.fromMap(data))
          .toList()
          .cast<CategoryModel>();

      cateList = data;
    }
  }
  List<ProductModel> p_list_id=[];
  Future<void> p_id_list(int p_id)async{
    String url =
        "https://bbooksmarket.000webhostapp.com/bookMarketApi/FetchPwithId.php?Book_Product_id=${p_id}";

    var response = await http.get(url);

    var jsondata = jsonDecode(response.body);

    if (response.statusCode == 200) {
      print(response.body);
      List<ProductModel> data = jsondata
          .map<ProductModel>((data) => ProductModel.fromMap(data))
          .toList()
          .cast<ProductModel>();

      p_list_id = data;
    }

  }
  List<ProfileModel> profileList=[];
  Future<void> Profile(int user_id)async{
    String url =
        "https://bbooksmarket.000webhostapp.com/bookMarketApi/FetchProfile.php?user_id=${user_id}";

    var response = await http.get(url);

    var jsondata = jsonDecode(response.body);

    if (response.statusCode == 200) {
      print(response.body);
      List<ProfileModel> data = jsondata
          .map<ProfileModel>((data) => ProfileModel.fromMap(data))
          .toList()
          .cast<ProfileModel>();

      profileList = data;
    }

  }
  List<Productt> ProducttList = [];

  Future<void> loadpList() async {
    String url =
        "https://bbooksmarket.000webhostapp.com/bookMarketApi/FetchProduct.php";

    var response = await http.get(url);

    var jsondata = jsonDecode(response.body);

    if (response.statusCode == 200) {
      print(response.body);
      List<Productt> data = jsondata
          .map<Productt>((data) => Productt.fromMap(data))
          .toList()
          .cast<Productt>();

      ProducttList = data;
    }
  }

  List<ShopModel> shopeList = [];

  Future<void> loadshopList() async {
    String url =
        "https://bbooksmarket.000webhostapp.com/bookMarketApi/FetchShops.php";

    var response = await http.get(url);

    var jsondata = jsonDecode(response.body);

    if (response.statusCode == 200) {
      print(response.body);
      List<ShopModel> data = jsondata
          .map<ShopModel>((data) => ShopModel.fromMap(data))
          .toList()
          .cast<ShopModel>();

      shopeList = data;
    }
  }

  shop(String Owner_id) async {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    String url =
        "https://bbooksmarket.000webhostapp.com/bookMarketApi/fetchShopwithid.php?user_id=${Owner_id}";

    var response = await http.get(url);

    var jsondata = jsonDecode(response.body);
    print(response.body);
    if (response.statusCode == 200) {
      ShopModel data = ShopModel.fromMap(jsondata);

      print("samar${data.Book_Shop_id}");
      prefs.setInt("shopid", data.Book_Shop_id);
    }
  }

  List<ProductModel> ProductList = [];

  Future<void> loadProductList(String url) async {
    var response = await http.get(url);

    var jsondata = jsonDecode(response.body);
    print(jsondata);
    if (response.statusCode == 200) {
      print(response.body);
      List<ProductModel> data = jsondata
          .map<ProductModel>((data) => ProductModel.fromMap(data))
          .toList()
          .cast<ProductModel>();

      ProductList = data;
    }
  }

  addProduct(BuildContext context, String p_name,String p_img,
      String p_price,String p_quntity,
      String   p_descrption,String p_author,
      String p_shopid, String p_cateid) async {
    String url =
        "https://bbooksmarket.000webhostapp.com/bookMarketApi/addProductdata.php";
    var response = await http
        .post(url, body: {
          "Book_Product_name": p_name,
          "Book_Product_img": p_img,
          "Book_Product_price": p_price,
          "Book_Product_quntity": p_quntity,
          "Book_Product_descrption": p_descrption,
          "Book_Product_author": p_author,
          "Book_Product_shopid": p_shopid,
          "Book_Product_categoryid": p_cateid,
        })
        .timeout(Duration(
          seconds: 10,
        ))
        .catchError((e) async {});
    if (response.statusCode == 200) {
      response.body;
      print(response.body);
      final json = jsonDecode(response.body);
      print("object${json["response"]['status']}");
      int state = json["response"]['status'];
      print(state);
      if (state == 1) {
         Fluttertoast.showToast(
            msg: "تم الاضافة بنجاح",
            toastLength: Toast.LENGTH_SHORT,
            gravity: ToastGravity.CENTER,
            timeInSecForIosWeb: 1,
            backgroundColor: kthirdColor,
            textColor: Colors.white,
            fontSize: 16.0);

        Navigator.pop(context);  }
      else {
        confirm(context, json["response"]['message']);
      }
    }
    SharedPreferences prefs = await SharedPreferences.getInstance();

    Navigator.of(context).push(
        new MaterialPageRoute(builder: (context) => HomeScreen(
          prefs.getInt("userType"),
          prefs.getInt("user_id"),
          prefs.getString("username"),
          prefs.getString("user_email"),
          prefs.getString("user_img"),

        )));

  }

  EditeProduct(
      BuildContext context,
      String edit_id,
      String p_name,
      String p_img,
      String p_price,
      String p_quntity,
      String p_descrption,
    String  p_author,
      String p_shopid,
      String p_cateid) async {
    String url =
        "https://bbooksmarket.000webhostapp.com/bookMarketApi/editShopRating.php";
    print("id:${edit_id}+name:${p_name}+pimg${p_img}+"
        "pprice:${p_price}+pquntity:${p_quntity}+pdes:${p_descrption}+p_shopid:${p_shopid}"
        "pc:${p_cateid}");
    var response = await http
        .post(url, body: {
          "Book_Product_id": edit_id,
          "Book_Product_name": p_name,
          "Book_Product_img": p_img,
          "Book_Product_price": p_price,
          "Book_Product_quntity": p_quntity,
          "Book_Product_descrption": p_descrption,
          "Book_Product_author": p_author,
          "Book_Product_shopid": p_shopid,
          "Book_Product_categoryid": p_cateid,
        })
        .timeout(Duration(
          seconds: 10,
        ))
        .catchError((e) async {});
    // Navigator.pop(context);
    SpinKitDoubleBounce(
      color: Colors.white,
      size: 100,
    );
    if (response.statusCode == 200) {
      response.body;
      print(response.body);
      final json = jsonDecode(response.body);
      print("object${json["response"]['status']}");
      int state = json["response"]['status'];
      print(state);
      if (state == 1) {
        confirm(context,"تم التعديل بنجاح");

          Fluttertoast.showToast(
              msg: "تم التحديث بنجاح",
              toastLength: Toast.LENGTH_SHORT,
              gravity: ToastGravity.CENTER,
              timeInSecForIosWeb: 1,
              backgroundColor: kthirdColor,
              textColor: Colors.white,
              fontSize: 16.0);

        Navigator.pop(context);
      } else {
        confirm(context, json["response"]['message']);
      }
    }
    SharedPreferences prefs = await SharedPreferences.getInstance();

    Navigator.of(context).push(
        new MaterialPageRoute(builder: (context) => HomeScreen(
          prefs.getInt("userType"),
          prefs.getInt("user_id"),
          prefs.getString("username"),
          prefs.getString("user_email"),
          prefs.getString("user_img"),

        ))); }

  deleteProduct(BuildContext context, String delet_id) async {
    String url =
        "https://bbooksmarket.000webhostapp.com/bookMarketApi/deleteProductData.php";
    print(delet_id);
    var response = await http
        .post(url, body: {
          "Edite_product_id": delet_id,
        })
        .timeout(Duration(
          seconds: 10,
        ))
        .catchError((e) async {});
    if (response.statusCode == 200) {
      response.body;
      print(response.body);
      final json = jsonDecode(response.body);
      print("object${json["response"]['status']}");
      int state = json["response"]['status'];
      print(state);
      if (state == 1) {
        confirm(context, json["response"]['message']);
        //Navigator.pop(context);
      } else {
        confirm(context, json["response"]['message']);
      }
    }
  }
}
