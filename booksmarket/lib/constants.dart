import 'package:flutter/material.dart';

/*
c2d0d0
54676d
9bafb0
453E73*/

const kMainColor= Color(0xFFe2a188);
const kthirdColor = Color(0xFFf0bba6);
const kSecondaryColor = Color(0xFFe7e4df);
const kCardColor = Color(0xFFfcf3ef);
const kTextColor = Colors.black54;
const kActiveColor = Color(0xFFa8a5a5);

TextStyle customtextStyle(var fontSize,var fontColor) {
  return TextStyle(
      fontSize: fontSize,
      fontFamily: 'AraHamah1964R',
      fontWeight: FontWeight.bold,
      color: fontColor);
}
TextStyle textStyle(var fontSize,var fontColor) {
  return TextStyle(
      fontSize: fontSize,
      fontFamily: 'AraHamah1964R',
      color: fontColor);
}