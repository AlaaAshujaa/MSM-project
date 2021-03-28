import 'package:flutter/material.dart';

class ClippingClass extends CustomClipper<Path> {
  @override
  Path getClip(Size size) {
    var path = Path();
    path.lineTo(0, size.height);
    path.quadraticBezierTo(
        5, size.height - 50, size.width / 5, size.height - 50);
    path.lineTo(size.width - 80, size.height - 50);
    path.quadraticBezierTo(
        size.width - 10, size.height - 50, size.width, size.height - 90);
    path.lineTo(size.width, 0);
    return path;
  }

  @override
  bool shouldReclip(covariant CustomClipper oldClipper) {
    return false;
  }
}
