import 'package:booksmarket/Models/Category_Model.dart';
import 'package:booksmarket/constants.dart';
import 'package:flutter/material.dart';
import 'package:flutter_spinkit/flutter_spinkit.dart';
import 'dart:convert';
import 'dart:io';
import 'package:path/path.dart';
import 'package:http/http.dart'as http;
import 'package:booksmarket/Helper/Service.dart';
import 'package:image_picker/image_picker.dart';
import 'package:shared_preferences/shared_preferences.dart';

class AddProduct  extends StatefulWidget {
  @override
  _AddProductState createState() => _AddProductState();
}

class _AddProductState extends State<AddProduct> {

  GlobalKey<FormState> fkey = new GlobalKey();
  TextEditingController controlerp_name = new TextEditingController();
  TextEditingController controlerp_price = new TextEditingController();
  TextEditingController controlerp_quntity = new TextEditingController();
  TextEditingController controlerp_descrption = new TextEditingController();
  TextEditingController controlerp_author = new TextEditingController();

  File _image;
  final picker = ImagePicker();
  getImag() async {
    final pickedFile = await picker.getImage(source: ImageSource.gallery);
    if (pickedFile != null) {
      _image = File(pickedFile.path);
      setState(() {});
    }
  }
  List<CategoryModel> cate_list = [];

  void getcateList() async {
    Service service = Service();
    await service.loadCateList();
    cate_list = service.cateList;
  }
  int _cateidValue;
  @override
  void initState() {
    super.initState();
    getcateList();
  }

  @override
  Widget build(BuildContext context) {
    double height = MediaQuery.of(context).size.height;
    double widht = MediaQuery.of(context).size.width;

    return  Directionality(
      textDirection: TextDirection.rtl,
      child: Scaffold(

          appBar: AppBar(
            title: Text(
              "متجـر للـكتـب",textAlign: TextAlign.center,
              style: customtextStyle(20.0, kMainColor),
            ),
            elevation: 0,

            actions: <Widget>[
              Padding(
                padding: const EdgeInsets.only(left: 15.0),
                child: Icon(
                  Icons.shopping_cart,
                  color: kMainColor,
                ),
              ),
            ],
          ),
        body:Padding(padding: EdgeInsets.only(left:20,right: 20,top: 40,bottom: 20),
        child: Container(
          decoration: BoxDecoration(
              borderRadius: BorderRadius.circular(50),
              color: Colors.grey[200],
              boxShadow: [
                BoxShadow(
                    color:kthirdColor,
                    offset: Offset(1, 1),
                    blurRadius: 6)
              ]
          ),
          child:  Form(
            key: fkey,
            child: ListView(
              children: <Widget>[

                SizedBox(
                  height: 10,
                ),
                Text("اختر صورة ",style: customtextStyle(20.0, kTextColor,),textAlign: TextAlign.center,),
                Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: InkWell(
                      child: CircleAvatar(
                        child:_image == null
                            ? Icon(Icons.add_a_photo,color: kMainColor)
                            : Image.file(_image),
                        backgroundColor: Colors.grey[200],
                        radius: 60,
                      ),
                      onTap: () => getImag()),
                ),
                Padding(
                    padding: const EdgeInsets.only(right:13.0,left:13),
                    child: Container(
                      margin: const EdgeInsets.only(top: 10.0, bottom: 10.0),
                      height: 50.0,

                      decoration: new BoxDecoration(
                          border: Border.all(color: kMainColor),
                          borderRadius:
                          new BorderRadius.all(new Radius.circular(5.7))),
                      child: cate_list == null
                          ? Center(
                        child: CircularProgressIndicator(),
                      )
                          : ListTile(
                        title: new DropdownButton(
                          items: cate_list.map((item) {
                            return new DropdownMenuItem(
                                child: new Text(item.Book_cat_name,style: customtextStyle(15.0, kthirdColor),),
                                value: item.Book_cat_id
                            );
                          }).toList(),
                          style: Theme.of(context).textTheme.subhead,
                          isExpanded: true,
                          hint: Text('تحديد القسم',
                            style: customtextStyle(15.0, kthirdColor),),
                          onChanged: (newVal) {
                            setState(() {
                              _cateidValue = newVal;
                              print(_cateidValue.toString());
                            });
                          },
                          value: _cateidValue,
                        ),
                      ),
                    )),
                Padding(
                  padding: EdgeInsets.symmetric(horizontal: 32),
                  child: Material(
                    color: kCardColor,
                    elevation: 2.0,
                    borderRadius: BorderRadius.all(Radius.circular(25)),
                    child: TextFormField(
                      controller: controlerp_name,
                      onChanged: (String value) {},
                      validator: (x) => x.isEmpty ? "هذا الحقل ضروري" : null,
                      cursorColor: kMainColor,
                      decoration: InputDecoration(
                          enabledBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          focusedBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          hintText: "اسم المنتج",
                          /*  hintStyle:
                      CustomStyle().textStyle(14.0, Colors.black),
                   */
                          prefixIcon: Material(
                            color: kCardColor,
                            elevation: 0,
                            borderRadius:
                            BorderRadius.all(Radius.circular(30)),
                            child: Icon(
                              Icons.person,
                              color: kMainColor,
                            ),
                          ),
                          contentPadding: EdgeInsets.symmetric(
                              horizontal: 25, vertical: 13)),
                    ),
                  ),
                ),
                SizedBox(
                  height: 20,
                ),
                Padding(
                  padding: EdgeInsets.symmetric(horizontal: 32),
                  child: Material(
                    color: kCardColor,
                    elevation: 2.0,
                    borderRadius: BorderRadius.all(Radius.circular(25)),
                    child: TextFormField(
                      controller: controlerp_price,
                      onChanged: (String value) {},
                      validator: (x) => x.isEmpty ? "هذا الحقل ضروري" : null,
                      cursorColor:kMainColor,
                      decoration: InputDecoration(
                          enabledBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          focusedBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          hintText: "سعر المنتج",
                          /*  hintStyle:
                      CustomStyle().textStyle(14.0, Colors.black),
                   */
                          prefixIcon: Material(
                            color: kCardColor,
                            elevation: 0,
                            borderRadius:
                            BorderRadius.all(Radius.circular(30)),
                            child: Icon(
                              Icons.attach_money,
                              color: kMainColor,
                            ),
                          ),
                          contentPadding: EdgeInsets.symmetric(
                              horizontal: 25, vertical: 13)),
                    ),
                  ),
                ),
                SizedBox(
                  height: 20,
                ),
                Padding(
                  padding: EdgeInsets.symmetric(horizontal: 32),
                  child: Material(
                    color: kCardColor,
                    elevation: 2.0,
                    borderRadius: BorderRadius.all(Radius.circular(25)),
                    child: TextFormField(
                      controller: controlerp_quntity,
                      validator: (x) => x.isEmpty ? "هذا الحقل ضروري" : null,
                      onChanged: (String value) {},
                      cursorColor: kMainColor,
                      decoration: InputDecoration(
                          enabledBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          focusedBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          hintText: "الكمية المتوفرة",
                          /*  hintStyle:
                      CustomStyle().textStyle(14.0, Colors.black),
                   */
                          prefixIcon: Material(
                            color: kCardColor,
                            elevation: 0,
                            borderRadius:
                            BorderRadius.all(Radius.circular(30)),
                            child: Icon(
                              Icons.equalizer,
                              color: kMainColor,
                            ),
                          ),
                          contentPadding: EdgeInsets.symmetric(
                              horizontal: 25, vertical: 13)),
                    ),
                  ),
                ),
                SizedBox(
                  height: 20.0,
                ),
                Padding(
                  padding: EdgeInsets.symmetric(horizontal: 32),
                  child: Material(
                    color: kCardColor,
                    elevation: 2.0,
                    borderRadius: BorderRadius.all(Radius.circular(25)),
                    child: TextFormField(
                      controller: controlerp_descrption,
                      onChanged: (String value) {},
                      cursorColor: kMainColor,
                      validator: (x) => x.isEmpty ? "هذا الحقل ضروري" : null,
                      decoration: InputDecoration(
                          enabledBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          focusedBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          hintText: "وصف المنتج",
                          /*  hintStyle:
                      CustomStyle().textStyle(14.0, Colors.black),
                   */
                          prefixIcon: Material(
                            color: kCardColor,
                            elevation: 0,
                            borderRadius:
                            BorderRadius.all(Radius.circular(30)),
                            child: Icon(
                              Icons.description,
                              color: kMainColor,
                            ),
                          ),
                          contentPadding: EdgeInsets.symmetric(
                              horizontal: 25, vertical: 13)),
                    ),
                  ),
                ),
                SizedBox(
                  height: 20.0,
                ),
                Padding(
                  padding: EdgeInsets.symmetric(horizontal: 32),
                  child: Material(
                    color: kCardColor,
                    elevation: 2.0,
                    borderRadius: BorderRadius.all(Radius.circular(25)),
                    child: TextFormField(
                      controller: controlerp_author,
                      onChanged: (String value) {},
                      cursorColor: kMainColor,
                      validator: (x) => x.isEmpty ? "هذا الحقل ضروري" : null,
                      decoration: InputDecoration(
                          enabledBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          focusedBorder: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(25),
                              borderSide: BorderSide(color: kthirdColor)),
                          hintText: "الكاتب",
                          /*  hintStyle:
                      CustomStyle().textStyle(14.0, Colors.black),
                   */
                          prefixIcon: Material(
                            color: kCardColor,
                            elevation: 0,
                            borderRadius:
                            BorderRadius.all(Radius.circular(30)),
                            child: Icon(
                              Icons.person,
                              color: kMainColor,
                            ),
                          ),
                          contentPadding: EdgeInsets.symmetric(
                              horizontal: 25, vertical: 13)),
                    ),
                  ),
                ),
                SizedBox(
                  height: height*.05,
                ),
                FlatButton(
                  child: Container(
                    decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(20),
                      gradient: LinearGradient(
                        begin: Alignment.centerLeft,
                        end: Alignment.centerRight,
                        colors: [
                          kMainColor,
                          kthirdColor,
                        ],
                      ),
                    ),
                    height: height*0.07,
                    width: widht*.5,
                    child: Center(
                      child: Text(
                        "حفظ المنتج",
                          style:customtextStyle(15.0, kTextColor)
                      ),
                    ),
                  ),
                  onPressed: ()async {
                    if (fkey.currentState.validate()) {
                      if (_image == null) {
                        Service()
                            .confirm(context, "يرجى إدراج الصورة ");
                      } else {
                        var url2 =
                            "https://bbooksmarket.000webhostapp.com/bookMarketApi/saveImage.php";

                        List<int> imageBytes = _image.readAsBytesSync();
                        String imageB64 = base64Encode(imageBytes);
                        var response;
                        response = await http
                            .post(url2, body: {
                          "name": basename(_image.path),
                          "image": imageB64,
                        })
                            .timeout(Duration(
                          seconds: 40,
                        ))
                            .catchError((e) async {});
                        SharedPreferences prefs = await SharedPreferences.getInstance();
                        print("user${prefs.getInt("userid")}");
                        await Service().shop(prefs.getInt("userid").toString());
                        print("ali${prefs.getInt("shopid")}");
                        SpinKitDoubleBounce(
                          color: Colors.white,
                          size: 100,
                        );
                        Service().addProduct(
                            context,
                            controlerp_name.text,
                            "https://giftsmarket.000webhostapp.com/GiftMarketApi/img/${basename(_image.path)}",
                            controlerp_price.text,
                            controlerp_quntity.text,
                            controlerp_descrption.text,
                            controlerp_author.text,
                            prefs.getInt("shopid").toString(),
                            _cateidValue.toString());
                      }
                    }
                  },
                ),
                SizedBox(
                  height: height*.05,
                ),
              ],
            ),
          ),
        ),
        )

      ),
    );
  }
}
