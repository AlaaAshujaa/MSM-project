import 'package:booksmarket/Helper/Service.dart';
import 'package:booksmarket/Models/ProductModel.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../constants.dart';
import 'cartScreen.dart';

class DetailsScreen extends StatefulWidget {
  int cate_id,shop_id;
  DetailsScreen({this.cate_id,this.shop_id});
  @override
  _DetailsScreenState createState() => _DetailsScreenState();
}

class _DetailsScreenState extends State<DetailsScreen> {

  bool _loading = true;
  String url;
  List<ProductModel> p_list = [];

  void loadP() async {
    Service service = Service();
    await service.p_id_list(widget.cate_id);
    p_list = service.p_list_id;
    setState(() {
      _loading = false;
    });
  }

  @override
  void initState() {
    super.initState();
    loadP();
    getShared();

  }
  SharedPreferences prefs;

  getShared() async {
    prefs = await SharedPreferences.getInstance();
    print(prefs.getInt("userType"));
    setState(() {

    });
  }

  @override
  Widget build(BuildContext context) {
    double height = MediaQuery.of(context).size.height;
    double widht = MediaQuery.of(context).size.width;
    return Directionality(
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
        body: _loading == false
            ?p_list==null?Center(child:Text("no data"),):ListView.builder(
            itemCount: p_list.length,
            itemBuilder: (ctx,index){
              return Column(
                children: <Widget>[
                  Container(
                    height: height * .5,
                    child: GridTile(
                      child: Container(
                        color: kSecondaryColor,
                        child: Image(
                          image: NetworkImage(
                            p_list[index].Book_Product_img,
                          ),
                        ),
                      ),
                      footer: Container(
                        color: Colors.white70,
                        child: ListTile(
                          leading: Padding(
                            padding: const EdgeInsets.all(4.0),
                            child: Text(
                              p_list[index].Book_Product_name,
                              style: customtextStyle(20.0, kTextColor),
                            ),
                          ),
                          title: new Row(
                            children: <Widget>[
                              Padding(padding: const EdgeInsets.all(20.0)),
                              Expanded(
                                child: Text(

                                  p_list[index].Book_Product_price.toString(),
                                  style: customtextStyle(25.0, kTextColor),
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                  ),
                  SizedBox(
                    width: MediaQuery.of(context).size.width,
                    child: Padding(
                      padding: const EdgeInsets.all(30),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text("الوصــف",
                              style: customtextStyle(30.0, kMainColor)),
                          SizedBox(
                            height: height * .02,
                          ),
                          Text(
                             p_list[index].Book_Product_descrption,
                              style: textStyle(18.0, kTextColor)),
                          SizedBox(
                            height: height * .05,
                          ),
                          Row(
                            children: <Widget>[
                              // ============ the size button============
                              Expanded(
                                child: MaterialButton(
                                    onPressed: () {
              Navigator.of(context).pushReplacement(
              new MaterialPageRoute(
              builder: (context) => CartScreen())
              );
              },
                                    elevation: 3.0,
                                    color: kMainColor,
                                    textColor: Colors.white,
                                    child: new Text(
                                      "اشتــري الآن",
                                      style: customtextStyle(20.0, kTextColor),
                                    )),
                              ),
                              new IconButton(
                                  icon: Icon(
                                    Icons.add_shopping_cart,
                                    color: kMainColor,
                                  ),
                                  onPressed: () {}),
                              new IconButton(
                                  icon: Icon(
                                    Icons.favorite_border,
                                    color: kMainColor,
                                  ),
                                  onPressed: () {
                                  setState(() {
                                    Icon(Icons.favorite,color: Colors.red,);

                                  });  }
                              )
                            ],
                          ),
                        ],
                      ),
                    ),
                  ),
                ],
              );
            }):Center(child: CircularProgressIndicator(),),
      ),
    );
  }
}
/**/