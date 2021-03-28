import 'package:booksmarket/Screens/LoginScreen.dart';
import 'package:booksmarket/Screens/SplashScreen.dart';
import 'package:curved_navigation_bar/curved_navigation_bar.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'dart:async';
import 'Screens/CategoryScreen.dart';
import 'Screens/DetailsScreen.dart';
import 'Screens/HomeScreen.dart';
import 'Screens/IntroScreen.dart';
import 'Screens/ProfileScreen.dart';
import 'constants.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      theme: ThemeData(

        primaryColor: Colors.white
      ),
      home: SplashScreen(),
    );
  }
}

