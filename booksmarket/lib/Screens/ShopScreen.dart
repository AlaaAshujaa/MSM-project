import 'package:booksmarket/Helper/Service.dart';
import 'package:booksmarket/Models/Shop_Model.dart';
import 'package:booksmarket/Screens/Product_Cat_id.dart';
import 'package:booksmarket/constants.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class ShopScreen extends StatefulWidget {
  @override
  _ShopScreenState createState() => _ShopScreenState();
}

class _ShopScreenState extends State<ShopScreen> {

  bool _loading = true;
  List<ShopModel> shop_list = [];

  void getshopList() async {
    Service service = Service();
    await service.loadshopList();
    shop_list = service.shopeList;
    setState(() {
      _loading = false;
    });
  }

  @override
  void initState() {
    super.initState();
    getshopList();
  }



  @override
  Widget build(BuildContext context) {
    double height = MediaQuery.of(context).size.height;
    double widht = MediaQuery.of(context).size.width;

    return SafeArea(
      child: Directionality(
        textDirection: TextDirection.rtl,
        child: Scaffold(
            body: ListView(
          children: <Widget>[
            GridView.builder(
                shrinkWrap: true,
                itemCount: shop_list.length,
                gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                    crossAxisCount: 2),
                itemBuilder: (ctx, index) {
                  return _loading==false?Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: GestureDetector(
                      onTap: (){

                        Navigator.of(context).push(new
                        MaterialPageRoute(builder: (context) =>
                        new Product_Cat_id(shop_id: shop_list[index].Book_Shop_id,)));
                      },
                      child: Card(
                        color: kCardColor,
                        shape: RoundedRectangleBorder(
                          borderRadius: BorderRadius.all(
                            Radius.circular(15),
                          ),
                        ),
                        child: Column(
                          children: <Widget>[
                          Padding(
                            padding: const EdgeInsets.all(8.0),
                            child: Container(
                            height: 90.0,
                            width: 130.0,
                            decoration: BoxDecoration(
                                borderRadius: BorderRadius.all(Radius.circular(5.0)),
                                image: DecorationImage(
                                    image: NetworkImage(
                                        shop_list[index].Book_Shop_img),
                                    fit: BoxFit.fill)),
                        ),
                          ),
                             SizedBox(
                              height: height * .02,
                            ),
                            Flexible(
                              child: Row(
                                children: <Widget>[
                                  Padding(
                                    padding: const EdgeInsets.only(right: 4.0),
                                    child: Icon(Icons.store),
                                  ),
                                  SizedBox(
                                    width: widht * .02,
                                  ),
                                  Text(
                                   shop_list[index].Book_Shop_name,
                                    style: customtextStyle(15.0, kTextColor),
                                  ),
                                ],
                              ),
                            ),
                            SizedBox(
                              height: height * .02,
                            ),
                            Row(
                              children: <Widget>[
                                Padding(
                                  padding: const EdgeInsets.only(right: 4.0),
                                  child: Icon(Icons.phone),
                                ),
                                SizedBox(
                                  width: widht * .02,
                                ),
                                Expanded(
                                  child: Text(
                                    shop_list[index].Book_Shop_phone,
                                    style: customtextStyle(15.0, kTextColor),
                                  ),
                                ),
                              ],
                            )
                          ],
                        ),
                      ),
                    ),
                  )
                      :Center(child: CircularProgressIndicator(),);
                }),
          ],
        )),
      ),
    );
  }
}
