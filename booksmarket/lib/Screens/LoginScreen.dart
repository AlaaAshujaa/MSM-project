import 'dart:convert';
import 'dart:io';

import 'package:booksmarket/Helper/Service.dart';
import 'package:booksmarket/Screens/MainScreen.dart';
import 'package:booksmarket/Widgets/Clipping_Class.dart';
import 'package:booksmarket/constants.dart';
import "package:flutter/material.dart";
import 'package:flutter_svg/flutter_svg.dart';

import '../main.dart';
import 'HomeScreen.dart';
import 'RegisterScreen.dart';

class LoginScreen extends StatefulWidget {
  @override
  _LoginScreenState createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen> {
  GlobalKey<FormState> fkey = new GlobalKey();
  TextEditingController controleruser_email = new TextEditingController();
  TextEditingController controleruser_pass = new TextEditingController();

  @override
  Widget build(BuildContext context) {
    double height = MediaQuery.of(context).size.height;
    double widht = MediaQuery.of(context).size.width;

    return SafeArea(
      child: Directionality(
          textDirection: TextDirection.rtl,
          child: Scaffold(
            backgroundColor: kCardColor,
            body: Padding(
              padding: const EdgeInsets.only(left:20.0,right: 20.0,top: 40.0,bottom: 20.0),
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
                child: Form(
                    key: fkey,
                    child: ListView(
                      children: <Widget>[
                        Padding(
                          padding: const EdgeInsets.all(8.0),
                          child: Container(
                            height: height*.4,
                              width: widht,
                              child: SvgPicture.asset("assets/icons/book.svg")),
                        ),
                        SizedBox(height: height*.03,),
                        Padding(
                          padding: EdgeInsets.symmetric(horizontal: 32),
                          child: Material(
                            elevation: 2.0,
                            color: kCardColor,
                            borderRadius: BorderRadius.all(Radius.circular(30)),
                            child: TextFormField(
                              controller: controleruser_email,
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
                                  hintText: "الإيميل",
                                  /*  hintStyle:
                      CustomStyle().textStyle(14.0, Colors.black),
                   */
                                  prefixIcon: Material(
                                    color: kCardColor,
                                    elevation: 0,
                                    borderRadius:
                                        BorderRadius.all(Radius.circular(30)),
                                    child: Icon(
                                      Icons.email,
                                      color: kMainColor,
                                    ),
                                  ),
                                  contentPadding: EdgeInsets.symmetric(
                                      horizontal: 25, vertical: 13)),
                            ),
                          ),
                        ),
                        SizedBox(
                          height: height * .02,
                        ),
                        Padding(
                          padding: EdgeInsets.symmetric(horizontal: 32),
                          child: Material(
                            color: kCardColor,
                            elevation: 2.0,
                            borderRadius: BorderRadius.all(Radius.circular(30)),
                            child: TextFormField(
                              controller: controleruser_pass,
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
                                  hintText: "كلمة السر",
                                  /* hintStyle:
                      CustomStyle().textStyle(14.0, Colors.black),
                    */
                                  prefixIcon: Material(
                                    color: kCardColor,
                                    elevation: 0,
                                    borderRadius:
                                        BorderRadius.all(Radius.circular(30)),
                                    child: Icon(
                                      Icons.lock,
                                      color: kMainColor,
                                    ),
                                  ),
                                  contentPadding: EdgeInsets.symmetric(
                                      horizontal: 25, vertical: 13)),
                            ),
                          ),
                        ),
                        SizedBox(
                          height: height * .1,
                        ),
                        Padding(
                            padding: EdgeInsets.symmetric(horizontal: 32),
                            child: Container(
                              decoration: BoxDecoration(
                                  borderRadius: BorderRadius.all(Radius.circular(50)),
                                  color: kthirdColor),
                              child: FlatButton(
                                shape: RoundedRectangleBorder(
                                  borderRadius: BorderRadius.circular(20),
                                ),
                                child: Text(
                                  "تسجيل الدخول",
                                  style: customtextStyle(20.0, kTextColor),
                                ),
                                onPressed: () async {
                                  if (fkey.currentState.validate()) {
                                    Service().LoginData(
                                        context,
                                        controleruser_email.text,
                                        controleruser_pass.text);
                                  }
                                },
                              ),
                            )),
                        SizedBox(
                          height: height*.03,
                        ),

                        Row(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: <Widget>[
                            Text(
                              "لايوجد لديك حساب ؟ ",
                              style: TextStyle(
                                  color: Colors.black,
                                  fontSize: 15,
                                  fontWeight: FontWeight.normal),
                            ),
                            InkWell(
                              onTap: () {
                                Navigator.of(context).push(new MaterialPageRoute(
                                    builder: (cox) => RegisterScreen()));
                              },
                              child: Text("انشاء حساب ",
                                  style: TextStyle(
                                      color: kMainColor,
                                      fontWeight: FontWeight.w500,
                                      fontSize: 12,
                                      decoration: TextDecoration.underline)),
                            )
                          ],
                        ),
                        SizedBox(
                          height: height*.03,
                        ),
                      ],
                    )),
              ),
            ),
          )),
    );
  }
}
