import 'package:booksmarket/Helper/Service.dart';
import 'package:booksmarket/Models/ProductModel.dart';
import 'package:booksmarket/Screens/EditProduct.dart';
import 'package:booksmarket/constants.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';

import 'DetailsScreen.dart';

class Product_Cat_id extends StatefulWidget {
  int cate_id,shop_id;
  Product_Cat_id({this.cate_id,this.shop_id});
  @override
  _Product_Cat_idState createState() => _Product_Cat_idState();
}

class _Product_Cat_idState extends State<Product_Cat_id> {


  bool _loading = true;
  String url;
  List<ProductModel> p_list = [];
  void getcatepList() async {
    print("samar${widget.cate_id}");
    if(widget.cate_id!=null){
      url="https://bbooksmarket.000webhostapp.com/bookMarketApi/productListWithSectionId.php?Book_Product_categoryid=${widget.cate_id}";
    }else{
      url="https://bbooksmarket.000webhostapp.com/bookMarketApi/productListWithShopIdId.php?Book_Product_shopid=${widget.shop_id}";
    }

    Service service = Service();
    await service.loadProductList(url);
    p_list = service.ProductList;
    setState(() {
      _loading = false;
    });
  }
  SharedPreferences prefs;
  @override
  void initState() {
    super.initState();
    getcatepList();
    getShared();
  }
  getShared() async {
    prefs = await SharedPreferences.getInstance();
    print(prefs.getInt("userType"));
    setState(() {

    });
  }
  String _menu_item;
  static const menuItms=<String>[
    'تحديث',
    'حذف',
  ];

  final List<PopupMenuItem<String>> _popUpMenuItems= menuItms
      .map((String value) => PopupMenuItem<String>(
    value: value,
    child: Text(value),
  ),
  ).toList();


  @override
  Widget build(BuildContext context) {
    double height = MediaQuery.of(context).size.height;
    double widht = MediaQuery.of(context).size.width;
    return Directionality(
      textDirection: TextDirection.rtl,
      child: Scaffold(
        appBar: AppBar(),
        body: Stack(
          children: <Widget>[
            Padding(
              padding: EdgeInsets.symmetric(horizontal: 10,vertical: 10),
              child: SingleChildScrollView(
                child: Column(
                  children: <Widget>[
                SizedBox(
                height: height * .03,
                ),
                  Padding(
                    padding: const EdgeInsets.only(right: 8.0),
                    child: Text(
                      "الكتب المتوفرة",
                      textAlign: TextAlign.right,
                      style: customtextStyle(20.0, kTextColor),
                    ),
                  ),
                    _loading == false
                        ?p_list==null?Center(child:Text("no data"),):ListView.builder(
                        shrinkWrap: true,
                        physics: ClampingScrollPhysics(),
                        scrollDirection: Axis.vertical,
                        itemCount: p_list.length,
                        itemBuilder: (ctx,index){
                          return  GestureDetector(
                            onTap: ()=>Navigator.of(context)
                                .push(new MaterialPageRoute(
                              //here we are pasting values of products to the products details page
                                builder: (context) =>
                                    DetailsScreen(cate_id: p_list[index].Book_Product_id,))),
                            child: Padding(

                              padding: const EdgeInsets.all(15.0),
                              child: Card(


                                  color: kCardColor,
                                  shape: RoundedRectangleBorder(
                                    borderRadius: BorderRadius.all(
                                      Radius.circular(30),
                                    ),
                                  ),
                                  child: Container(
                                    child: Row(
                                      children: <Widget>[
                                        Expanded(
                                          flex:2,
                                          child: ClipRRect(
                                            borderRadius: BorderRadius.only(
                                              topRight: Radius.circular(30),
                                              bottomRight: Radius.circular(30),
                                            ),
                                            child: Image.network(p_list[index].Book_Product_img),
                                          ),
                                        ),
                                        SizedBox(
                                          width: widht * .03,
                                        ),
                                        Flexible(
                                          flex: 3,
                                          child: Column(
                                            children: <Widget>[
                                              Text(
                                                p_list[index].Book_Product_name,
                                                style: customtextStyle(
                                                    15.0, kTextColor),
                                              ),
                                              SizedBox(
                                                height: height * .02,
                                              ),
                                              Row(
                                                children: <Widget>[
                                                  Icon(
                                                    Icons.person,
                                                    color: kMainColor,
                                                  ),
                                                  SizedBox(
                                                    width: widht * .03,
                                                  ),
                                                  Flexible(
                                                      child: Text(
                                                        p_list[index].Book_Product_author,
                                                        style:
                                                        textStyle(15.0, kTextColor),
                                                      )),
                                                ],
                                              ),
                                              SizedBox(
                                                height: height * .02,
                                              ),
                                              Padding(
                                                padding: const EdgeInsets.only(
                                                    right: 18.0),
                                                child: Text(
                                                  p_list[index].Book_Product_price.toString(),
                                                  style: customtextStyle(
                                                      20.0, kTextColor),
                                                ),
                                              ),
                                            ],
                                          ),
                                        ),
                                        Expanded(

                                          child: IconButton(
                                            onPressed: () => Navigator.of(context)
                                                .push(new MaterialPageRoute(
                                              //here we are pasting values of products to the products details page
                                                builder: (context) =>
                                                    DetailsScreen(cate_id: p_list[index].Book_Product_id,))),
                                            icon: Icon(Icons.arrow_forward_ios),
                                          ),
                                        ),
                                        prefs.getInt('userType') == 2

                                            && p_list[index].Book_Product_shopid==
                                            prefs.getInt('shopid')
                                            ? PopupMenuButton<String>(
                                          onSelected: (String newValue){
                                            _menu_item =newValue;
                                            if(_menu_item=='حذف'){
                                              Service().deleteProduct(context,p_list[index].Book_Product_id.toString());

                                              setState(() {
                                                p_list.removeAt(index);
                                              });
                                            }else{
                                              Navigator.push(context,MaterialPageRoute(builder: (context){
                                                return EditProduct(p_list[index],p_list[index].Book_Product_id);
                                              }));
                                            }
                                            Scaffold.of(context).showSnackBar(
                                              SnackBar(content: Text('$_menu_item'),
                                              ),
                                            );
                                          },
                                          itemBuilder: (BuildContext context)=> _popUpMenuItems,
                                        ): Padding(
                                          padding: const EdgeInsets.only(left:5.0),
                                          child: Icon(Icons.favorite_border,color: kthirdColor,),
                                        ),

                                      ],
                                    ),
                                  )),
                            ),
                          );
                        }):Center(child: CircularProgressIndicator(),),

                  ],
                ),
              ),
            )
          ],
        ) ),
    );
  }
}

/*
ListTile(
leading:Image.network(p_list[index].Book_Product_img),
title: Text(p_list[index].Book_Product_name),
subtitle: Text(p_list[index].Book_Product_descrption),
trailing: prefs.getInt('userType') == 2
&& p_list[index].Book_Product_shopid==
prefs.getInt('shopid')
?new PopupMenuButton<String>(
onSelected: (String newValue){
_menu_item =newValue;
if(_menu_item=='Delete'){
Service().deleteProduct(context,p_list[index].Book_Product_id.toString());

setState(() {
p_list.removeAt(index);
});
}else{
Navigator.push(context,MaterialPageRoute(builder: (context){
return EditProduct(p_list[index],p_list[index].Book_Product_id);
}));
}
Scaffold.of(context).showSnackBar(
SnackBar(content: Text('$_menu_item'),
),
);
},
itemBuilder: (BuildContext context)=> _popUpMenuItems,
): Icon(Icons.favorite_border,color: kthirdColor,),
),
*/
