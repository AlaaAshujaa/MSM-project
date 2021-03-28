import 'package:flutter/material.dart';

class CategoryModel {

  int Book_cat_id;
  String Book_cat_name;
  String Book_cat_img;
  int Book_cat_totel;


/*
  String imageUrl, categoryName;
  Color color;*/


  CategoryModel.fromMap(Map<String,dynamic>map){
    Book_cat_id=int.parse(map["Book_cat_id"]);
    Book_cat_name=map["Book_cat_name"];
    Book_cat_img=map["Book_cat_img"];
    Book_cat_totel=int.parse(map["Book_cat_total"]);

  }
}
