import 'package:booksmarket/Helper/Service.dart';
import 'package:booksmarket/Models/ProfileModel.dart';
import 'package:booksmarket/Screens/HomeScreen.dart';
import 'package:booksmarket/Screens/MainScreen.dart';
import 'package:booksmarket/Screens/cartScreen.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../constants.dart';

class ProfileScreen extends StatefulWidget {
  int user_id;
  ProfileScreen(this.user_id);
  @override
  _ProfileScreenState createState() => _ProfileScreenState();
}

class _ProfileScreenState extends State<ProfileScreen> {
  bool _loading = true;
  List<ProfileModel> profile_list = [];

  void loadProfile() async {
    Service service = Service();
    await service.Profile(widget.user_id);
    profile_list = service.profileList;
    setState(() {
      _loading = false;
    });
  }

  @override
  void initState() {
    super.initState();
    loadProfile();
  }

  @override
  Widget build(BuildContext context) {
    SharedPreferences prefs;
    getdata() async {
      prefs = await SharedPreferences.getInstance();
    }

    double height = MediaQuery.of(context).size.height;
    double widht = MediaQuery.of(context).size.width;

    return Directionality(
        textDirection: TextDirection.rtl,
        child: Scaffold(
          backgroundColor: kCardColor,
          appBar: AppBar(
            title: Text(
              "متجـر للـكتـب",
              textAlign: TextAlign.center,
              style: customtextStyle(20.0, kMainColor),
            ),
            elevation: 0,
            leading: GestureDetector(
              onTap: () async{

                  SharedPreferences prefs =
                      await SharedPreferences.getInstance();
                  Navigator.of(context).pushReplacement(
                    new MaterialPageRoute(
                      builder: (context) => new HomeScreen(
                        prefs.getInt("userType"),
                        prefs.getInt("user_id"),
                        prefs.getString("username"),
                        prefs.getString("user_email"),
                        prefs.getString("user_img"),
                      ),
                    ),
                  );

              },
              child: Icon(
                Icons.arrow_forward_ios,
              ),
            ),
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
          body: Stack(
            children: <Widget>[
              Padding(
                padding: EdgeInsets.symmetric(horizontal: 10, vertical: 10),
                child: SingleChildScrollView(
                  child: Column(
                    children: <Widget>[
                      ListView.builder(
                        itemCount: profile_list.length,
                        shrinkWrap: true,
                        physics: ClampingScrollPhysics(),
                        scrollDirection: Axis.vertical,
                        itemBuilder: (ctx, index) {
                          return Column(
                            children: <Widget>[
                              CircleAvatar(
                                backgroundImage: NetworkImage(
                                  profile_list[index].user_img,
                                ),
                                backgroundColor: Color(0xFFc2d0d0),
                                radius: 100.0,
                              ),
                            ],
                          );
                        },
                      ),
                      SizedBox(
                        height: height * .03,
                      ),
                      ListView.builder(
                        itemCount: profile_list.length,
                        shrinkWrap: true,
                        physics: ClampingScrollPhysics(),
                        scrollDirection: Axis.vertical,
                        itemBuilder: (ctx, index) {
                          return Padding(
                            padding:
                                const EdgeInsets.only(right: 15.0, left: 15),
                            child: Card(
                              shape:  RoundedRectangleBorder(
                                borderRadius: BorderRadius.all(
                                  Radius.circular(30),
                                ),
                              ),
                              color: Colors.grey[100],
                              child: ListTile(
                                title: Text(
                                  profile_list[index].user_name,
                                  style: customtextStyle(25.0, kTextColor),
                                ),
                                leading: Icon(
                                  Icons.person,
                                  color: kMainColor,
                                ),
                              ),
                            ),
                          );
                        },
                      ),
                      SizedBox(
                        height: height * .03,
                      ),
                      ListView.builder(
                        itemCount: profile_list.length,
                        shrinkWrap: true,
                        physics: ClampingScrollPhysics(),
                        scrollDirection: Axis.vertical,
                        itemBuilder: (ctx, index) {
                          return Padding(
                            padding:
                                const EdgeInsets.only(right: 15.0, left: 15),
                            child: Card(
                              shape:  RoundedRectangleBorder(
                                borderRadius: BorderRadius.all(
                                  Radius.circular(30),
                                ),
                              ),
                              color: Colors.grey[100],
                              child: ListTile(
                                title: Text(
                                  profile_list[index].user_email ?? "not null",
                                  style: customtextStyle(25.0, kTextColor),
                                ),
                                leading: Icon(
                                  Icons.email,
                                  color: kMainColor,
                                ),
                              ),
                            ),
                          );
                        },
                      ),
                      SizedBox(
                        height: height * .03,
                      ),
                      ListView.builder(
                        itemCount: profile_list.length,
                        shrinkWrap: true,
                        physics: ClampingScrollPhysics(),
                        scrollDirection: Axis.vertical,
                        itemBuilder: (ctx, index) {
                          return Padding(
                            padding:
                                const EdgeInsets.only(right: 15.0, left: 15),
                            child: Card(
                              shape:  RoundedRectangleBorder(
                                borderRadius: BorderRadius.all(
                                  Radius.circular(30),
                                ),
                              ),
                              color: Colors.grey[100],
                              child: ListTile(
                                title: Text(
                                  profile_list[index].user_phone,
                                  style: customtextStyle(25.0, kTextColor),
                                ),
                                leading: Icon(
                                  Icons.phone,
                                  color: kMainColor,
                                ),
                              ),
                            ),
                          );
                        },
                      ),
                      SizedBox(
                        height: height * .03,
                      ),
                      ListView.builder(
                        itemCount: profile_list.length,
                        shrinkWrap: true,
                        physics: ClampingScrollPhysics(),
                        scrollDirection: Axis.vertical,
                        itemBuilder: (ctx, index) {
                          return Padding(
                            padding:
                                const EdgeInsets.only(right: 15.0, left: 15),
                            child: Card(
                              shape:  RoundedRectangleBorder(
                                borderRadius: BorderRadius.all(
                                  Radius.circular(30),
                                ),
                              ),
                              color: Colors.grey[100],
                              child: ListTile(
                                title: Text(
                                  profile_list[index].user_password,
                                  style: customtextStyle(25.0, kTextColor),
                                ),
                                leading: Icon(
                                  Icons.lock,
                                  color: kMainColor,
                                ),
                              ),
                            ),
                          );
                        },
                      ),
                      SizedBox(
                        height: height * .03,
                      ),
                      ListView.builder(
                        itemCount: profile_list.length,
                        shrinkWrap: true,
                        physics: ClampingScrollPhysics(),
                        scrollDirection: Axis.vertical,
                        itemBuilder: (ctx, index) {
                          return Padding(
                            padding:
                                const EdgeInsets.only(right: 15.0, left: 15),
                            child: Card(
                              shape:  RoundedRectangleBorder(
                                borderRadius: BorderRadius.all(
                                  Radius.circular(30),
                                ),
                              ),
                              color: Colors.grey[100],
                              child: ListTile(
                                title: Text(
                                  profile_list[index].user_address,
                                  style: customtextStyle(25.0, kTextColor),
                                ),
                                leading: Icon(
                                  Icons.location_on,
                                  color: kMainColor,
                                ),
                              ),
                            ),
                          );
                        },
                      ),
                    ],
                  ),
                ),
              )
            ],
          ),
        ));
  }
}
