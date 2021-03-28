import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';

import '../constants.dart';

class CategoriesCard extends StatelessWidget {
  final String image, title;
  final Color color;


  const CategoriesCard({
    Key key,
    this.image,
    this.title,
    this.color

  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: EdgeInsets.symmetric(horizontal: 15),
      child: Column(
        children: [
          Container(
            height: 65,
            width: 65,
            decoration: BoxDecoration(
                color: color, borderRadius: BorderRadius.circular(35)),
            child: Center(
              child: Image.network(
                image,
                width: 45,
                height: 45,
              ),
            ),
          ),
          SizedBox(
            height: 5,
          ),
          Text(
            title,
            style: TextStyle(
                fontSize: 15, fontWeight: FontWeight.w600, color: kTextColor),
          )
        ],
      ),
    );
  }
}
