import 'package:booksmarket/Helper/Category_Data.dart';
import 'package:booksmarket/Models/Category_Model.dart';
import 'package:booksmarket/Screens/AddProduct.dart';
import 'package:booksmarket/Screens/LoginScreen.dart';
import 'package:booksmarket/Screens/ProfileScreen.dart';
import 'package:booksmarket/Screens/ShopScreen.dart';
import 'package:booksmarket/Screens/cartScreen.dart';
import 'package:booksmarket/Widgets/Category_Card.dart';
import 'package:curved_navigation_bar/curved_navigation_bar.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';
import '../constants.dart';
import 'CategoryScreen.dart';

import 'MainScreen.dart';
import 'package:rflutter_alert/rflutter_alert.dart';

class HomeScreen extends StatefulWidget {
  int userType;
  int user_id;
  String user_name,user_img,user_email;

  HomeScreen(this.userType,this.user_id,this.user_name,this.user_img,this.user_email);
  @override
  _HomeScreenState createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  SharedPreferences prefs;
  Future profilescreen()async{
     prefs = await SharedPreferences.getInstance();
    Navigator.of(context).pushReplacement(
         MaterialPageRoute(
          builder: (context) => new ProfileScreen(
            prefs.getInt("userid")
          ),
        ),);
  }
  int _page = 0;
  final _pageOption=[
    MainScreen(),
    ShopScreen(),
    CategoryScreen(),




  ];

About(){
  Alert(
    context: context,
    title: 'حـــول',
    desc: 'Alaa Developer !\n Copy Right @2020.',
    buttons: [
      DialogButton(
        color: kMainColor,
        child: Text(
          "اغلاق",
          style: customtextStyle(15.0, kTextColor),
        ),
        onPressed: () => Navigator.pop(context),
        width: 120,
      )
    ],

  ).show();
}
  @override
  Widget build(BuildContext context) {

    return SafeArea(
      child: Directionality(
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

          drawer:  Drawer(
              child: ListView(
                children: <Widget>[

                  UserAccountsDrawerHeader(
                    decoration: BoxDecoration(
                      color: kMainColor,
                    ),
                    accountName: Text(widget.user_name,style: customtextStyle(25.0,kTextColor)),
                     currentAccountPicture: GestureDetector(
                      child: CircleAvatar(
                        backgroundColor: Colors.grey[300],
                        backgroundImage: NetworkImage("") ,
                      ),
                    ),
                  ),
                  InkWell(
//                    onTap: (){
//                      Navigator.push(
//                          context, MaterialPageRoute(builder: (context) => MainScreen()));
//                    },
                    child: ListTile(
                      title: Text("الصفحة الرئيسية",style: customtextStyle(18.0,kTextColor),),
                      leading: Icon(
                        Icons.home,
                        color: kMainColor,
                        size: 30,
                      ),
                    ),
                  ),
                  InkWell(
                    onTap:profilescreen,
                    child: ListTile(
                      title: Text("الحساب",style: customtextStyle(18.0,kTextColor),),
                      leading: Icon(
                        Icons.person,
                        color: kMainColor,
                        size: 30,
                      ),
                    ),
                  ),
                  InkWell(
                    onTap: (){
                      Navigator.push(
                          context, MaterialPageRoute(builder: (context) => CartScreen()));
                    },
                    child: ListTile(
                      title: Text("سلة المشتريات",style: customtextStyle(18.0,kTextColor),),
                      leading: Icon(
                        Icons.shopping_cart,
                        color: kMainColor,
size: 30,
                      ),
                    ),
                  ),
                  InkWell(
                    child: ListTile(
                      title: Text("المفضلة",style: customtextStyle(18.0,kTextColor)),
                      leading: Icon(
                        Icons.favorite,
                        color: kMainColor,
                        size: 30,
                      ),
                    ),
                  ),
                  InkWell(
                    onTap: ()=>  Navigator.of(context).pushReplacement(
                        new MaterialPageRoute(
                            builder: (cox) => new LoginScreen())),
                    child: ListTile(
                      title: Text("تسجيل الدخول بحساب آخر",style: customtextStyle(18.0,kTextColor)),
                      leading: Icon(
                        Icons.lock_open,
                        color: kMainColor,
                        size: 30,
                      ),
                    ),
                  ),
                  Divider(),
                  InkWell(
                    child: ListTile(
                      title: Text("الاعدادات",style: customtextStyle(18.0,kTextColor)),
                      leading: Icon(
                        Icons.settings,
                        size: 30,
                      ),
                    ),
                  ),
                  InkWell(
                    onTap: (){
                    About();
                    },
                    child: ListTile(
                      title: Text("حول",style: customtextStyle(18.0,kTextColor)),
                      leading: Icon(
                        Icons.help,

                        size: 30,
                      ),
                    ),
                  ),
                ],
              )),
          body:

          _pageOption[_page],

          bottomNavigationBar: CurvedNavigationBar(
            backgroundColor:kthirdColor,
            color:Colors.white,
            buttonBackgroundColor:kSecondaryColor ,
            height: 50,
            animationDuration: Duration(
              milliseconds: 200,
            ),
            index: 0,

            animationCurve: Curves.bounceInOut,
            items: <Widget>[
              Icon(Icons.home, size: 25, color: kActiveColor),
              Icon(Icons.store, size: 25, color: kActiveColor),
              Icon(Icons.category, size: 25, color: kActiveColor),
                 ],
            onTap: (index) {
              //Handle Fbutton tap
              setState(() {
                _page=index;
              });
            },
          ),
          floatingActionButton:widget.userType==2? new FloatingActionButton(
              onPressed: (){
                Navigator.of(context).push(
                    new MaterialPageRoute(builder: (context) =>
                    new AddProduct()));
              },
              backgroundColor:  Color(0x44fe494d),
              child:Icon(Icons.add)):Container(),


        ),
      ),
    );
  }
}
/*
 Container(
                  decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(50),
                      color: Colors.white70,
                      boxShadow: [
                        BoxShadow(
                            color: kMainColor,
                            offset: Offset(1, 1),
                            blurRadius: 10)
                      ]),
                  child: Card(
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.all(
                        Radius.circular(30),
                      ),
                    ),
                    color: Colors.white70,
                    child: ListTile(
                      leading: ClipRRect(
                          borderRadius: BorderRadius.all(
                            Radius.circular(10),
                          ),
                          child: Image.asset(
                            "assets/img/logo.jpg",
                            height: 150,
                            width: 80,
                          )),
                      title: Text("McAfee Labs Threats Report"),
                      subtitle: Text("•	Intel Security commissioned a primary research study to gain a deeper understanding of the ways in which enterprises are using security operations centers"),
                      trailing: Icon(Icons.favorite),
                    ),
                  ),
                )
* */
