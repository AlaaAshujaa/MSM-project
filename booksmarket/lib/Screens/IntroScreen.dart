import 'dart:convert';
import 'package:flutter/material.dart';
import "package:flutter_swiper/flutter_swiper.dart";
import 'package:booksmarket/Models/IntroModel.dart';
import 'package:booksmarket/constants.dart';

import 'loginScreen.dart';



class IntroScreen extends StatefulWidget {
  @override
  _IntroScreenState createState() => _IntroScreenState();
}

class _IntroScreenState extends State<IntroScreen> {

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Directionality(
        textDirection: TextDirection.rtl,
        child: Scaffold(
          body: Swiper.children(
            autoplay: false,
            index: 0,
            loop: false,
            pagination: new SwiperPagination(
              margin: new EdgeInsets.fromLTRB(0.0, 0.0, 0.0, 40.0),
              builder: new DotSwiperPaginationBuilder(
                  color: Colors.black12,
                  activeColor:kMainColor,
                  size: 6.5,
                  activeSize: 8.0),
            ),
            control: SwiperControl(
              iconPrevious: null,
              iconNext: null,
            ),
            children: _getPages(context),
          ),
        ),
      ),
    );

  }
  List<Widget> _getPages(BuildContext context) {
    List<IntroModel> pages = [

      IntroModel(
        img: "assets/img/book.JPG",
        title: "متجر لبيع الكتــب الكترونياَ",
        description: " ",
      ),

      IntroModel(
          img: "assets/img/intro.png",
          title: "",
          description:
          "قم باختيار المحل الذي تريد الشراء منه وتصنيف الكتاب ليصلك حيت انت!",
          extraWidget: Padding(
            padding: const EdgeInsets.only(left:70.0,right: 70.0),
            child: MaterialButton(child:Text('موفق',
              style: TextStyle(color: Colors.white, fontFamily: "DancingScript"),),
                color:kMainColor,onPressed: (){
                  Navigator.of(context).pushReplacement(
                      new MaterialPageRoute(
                          builder: (cox) => new LoginScreen()));
                }),
          )
      ),
    ];
    List<Widget> widgets = [];
    for (int i = 0; i < pages.length; i++) {
      IntroModel page = pages[i];
      widgets.add(
        new Container(
          color: Colors.white,
          child: ListView(
            children: <Widget>[
              Padding(
                padding: const EdgeInsets.only(top: 70.0),
                child: Image.asset(
                  page.img,
                  height: 300.0,
                  width: 200.0,
                  //color: Color(0xFF019fe2),
                ),
              ),
              Padding(
                padding:
                const EdgeInsets.only(top: 50.0, right: 15.0, left: 15.0),
                child: Text(
                  page.title,
                  softWrap: true,
                  textAlign: TextAlign.center,
                  style: TextStyle(
                    color:kMainColor,
                    decoration: TextDecoration.none,
                    fontSize: 24.0,
                    fontWeight: FontWeight.w700,
                    fontFamily: "AraHamah1964R",
                  ),
                ),
              ),
              Padding(
                padding: const EdgeInsets.all(20.0),
                child: Text(
                  page.description,
                  softWrap: true,
                  textAlign: TextAlign.center,
                  style: TextStyle(
                    color: kMainColor,
                    decoration: TextDecoration.none,
                    fontSize: 15.0,
                    fontWeight: FontWeight.w300,
                    fontFamily: "AraHamah1964R",
                  ),
                ),
              ),
              Padding(
                padding: const EdgeInsets.all(10.0),
                child: page.extraWidget,
              )
            ],
          ),
        ),
      );
    }
    return widgets;
  }
}