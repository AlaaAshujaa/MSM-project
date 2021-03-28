import 'package:flutter/material.dart';

import '../constants.dart';
import 'DetailsScreen.dart';


class CartScreen extends StatefulWidget {
  @override
  _CartScreenState createState() => _CartScreenState();
}

class _CartScreenState extends State<CartScreen> {
  int plus=1;
  int mins=1;
  @override
  Widget build(BuildContext context) {
    double height = MediaQuery.of(context).size.height;
    double widht = MediaQuery.of(context).size.width;
    return SafeArea(
      child: Directionality(
        textDirection: TextDirection.rtl,
        child: Scaffold(
          backgroundColor: kCardColor,
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
          body: Stack(children: [
            Padding(
              padding: EdgeInsets.symmetric(horizontal: 10, vertical: 10),
              child: SingleChildScrollView(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.stretch,
                  children: <Widget>[
                    SizedBox(
                      height: height * .03,
                    ),
                    Padding(
                      padding: const EdgeInsets.only(right: 10.0),
                      child: Text(
                        "سلة المشتريات",
                        textAlign: TextAlign.right,
                        style: customtextStyle(20.0, kTextColor),
                      ),
                    ),
                    SizedBox(height: height * .02),


                    SizedBox(
                      height: height * .01,
                    ),
                  ListView.builder(
                      itemCount: 4,
                      itemBuilder: (ctx,index){
                    return   Container(
                      child: Row(
                        children: <Widget>[
                          Expanded(
                            child: ClipRRect(
                              borderRadius: BorderRadius.only(
                                topRight: Radius.circular(30),
                                bottomRight: Radius.circular(30),
                              ),
                              child: Image.asset(
                                  "assets/img/1.jpg"),
                            ),
                          ),
                          SizedBox(
                            width: widht * .03,
                          ),
                          Flexible(
                            child: Column(
                              children: <Widget>[
                                Text(
                                  "ادحب ",
                                  style: customtextStyle(
                                      15.0, kTextColor),
                                ),
                                SizedBox(
                                  height: height * .02,
                                ),
                                Row(
                                  children: <Widget>[
                                    Icon(
                                      Icons.monetization_on,
                                      color: kMainColor,
                                    ),
                                    SizedBox(
                                      width: widht * .03,
                                    ),

                                  ],
                                ),
                                SizedBox(
                                  height: height * .02,
                                ),

                              ],
                            ),
                          ),
                          Flexible(
                            child: Row(
                              children: <Widget>[
                                IconButton(
                                  onPressed: ( ){
                                    setState(() {
                                      plus=plus.round();
                                    });
                                  },
                                  icon: Icon( Icons.plus_one,
                                  ),
                                ),
                                SizedBox(
                                  height: height * .01,
                                ),
                                Text(plus.toString()),
                                SizedBox(
                                  height: height * .01,
                                ),
                                IconButton(
                                  onPressed: ( ){
                                    setState(() {
                                      mins=mins.round();
                                    });
                                  },
                                  icon: Icon( Icons.maximize,
                                  ),
                                ),
                                SizedBox(
                                  height: height * .01,
                                ),

                              ],
                            ),
                          ),

                        ],
                      ),
                    );
                  }),
                    Padding(
                      padding: const EdgeInsets.all(10),
                      child: Text(
                        "المجموع",
                        textAlign: TextAlign.right,
                        style: customtextStyle(20.0, kTextColor),
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ]),
        ),
      ),
    );
  }
}
