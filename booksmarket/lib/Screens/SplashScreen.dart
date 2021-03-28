import 'dart:async';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:booksmarket/constants.dart';
import 'HomeScreen.dart';
import 'IntroScreen.dart';
import 'LoginScreen.dart';

class SplashScreen extends StatefulWidget {
  @override
  _SplashScreenState createState() => _SplashScreenState();
}

class _SplashScreenState extends State<SplashScreen> {
  Future checkFirstSeen() async {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    bool _seen = (prefs.getBool('seen') ?? false);
    if (_seen) {
      if (prefs.getInt('status') == 1) {
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
      } else {
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
      }
    } else {
      prefs.setBool('seen', true);
      Navigator.of(context).pushReplacement(
          new MaterialPageRoute(builder: (context) => new IntroScreen()));
    }
  }

  initState() {
    Timer(Duration(seconds: 5), () {
      checkFirstSeen();
    });
  }

  @override
  Widget build(BuildContext context) {
    return Directionality(
      textDirection: TextDirection.rtl,
      child: Scaffold(
          body: Container(
        decoration: BoxDecoration(
            image: DecorationImage(
          image: AssetImage(
            'assets/img/33.jpg',
          ),
          fit: BoxFit.fill,
        )),
        child: Center(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: <Widget>[
              Padding(
                  padding: const EdgeInsets.only(bottom: 10.0),
                  child: CircleAvatar(
                    backgroundImage: AssetImage(
                      "assets/img/logo.jpg",
                    ),
                    backgroundColor: Color(0xFFc2d0d0),
                    radius: 100.0,
                  )),
              Text(
                "متجــر لبيع الكــتب",
                style: customtextStyle(20.0,kTextColor),
              )
            ],
          ),
        ),
      )),
    );
  }
}
