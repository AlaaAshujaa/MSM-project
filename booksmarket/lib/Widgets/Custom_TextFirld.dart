import 'package:flutter/material.dart';
import 'package:booksmarket/constants.dart';

class CustomTextField extends StatelessWidget {
  final String hint;
  final IconData icon;
  final Widget control;

  const CustomTextField({Key key, this.hint, this.icon, this.control}) : super(key: key);

  String _errorMessage(String str){
    switch(hint){
      case 'Enter your Name ' : return 'name is emty !';
      case 'Enter your email ' : return 'email is emty !';
      case 'Enter your password ' : return 'password is emty !';
      case 'Enter your photo ' : return 'photo is emty !';
    }
  }

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 30),
      child: TextFormField(
          validator: (value) {
            if (value.isEmpty) {
              return _errorMessage(hint);
              // ignore: missing_return
            }

          },
          cursorColor: kMainColor,
          decoration: InputDecoration(
            hintText: hint,
            prefixIcon: Icon(
              icon,
              color: Colors.black87,
            ),
            filled: true,
            fillColor: Colors.lime[100],
            enabledBorder: OutlineInputBorder(
                borderRadius: BorderRadius.circular(25),
                borderSide: BorderSide(color: Colors.white)),
            focusedBorder: OutlineInputBorder(
                borderRadius: BorderRadius.circular(25),
                borderSide: BorderSide(color: Colors.white)),
            border: OutlineInputBorder(
                borderRadius: BorderRadius.circular(25),
                borderSide: BorderSide(color: Colors.white)),
          )),
    );
  }
}
