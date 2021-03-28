import "package:flutter/material.dart";

class IntroModel {
  String img;
  String title;
  String description;
  Widget extraWidget;

  IntroModel({this.img, this.title, this.description, this.extraWidget}) {
    if (extraWidget == null) {
      extraWidget = new Container();
    }
  }
}