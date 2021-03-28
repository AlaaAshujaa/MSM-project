import 'dart:convert';
import 'dart:io';
import 'package:booksmarket/Helper/Service.dart';
import 'package:booksmarket/constants.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';
import 'package:http/http.dart' as http;
import 'package:image_picker/image_picker.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:path/path.dart';

class RegisterScreen extends StatefulWidget {
  @override
  _RegisterScreenState createState() => _RegisterScreenState();
}

class _RegisterScreenState extends State<RegisterScreen> {
  GlobalKey<FormState> fkey = new GlobalKey();

  TextEditingController controleruser_email = new TextEditingController();
  TextEditingController controleruser_name = new TextEditingController();
  TextEditingController controleruser_pass = new TextEditingController();
  TextEditingController controleruser_phon = new TextEditingController();
  TextEditingController controleruser_address = new TextEditingController();

  File _image;
  final picker = ImagePicker();
  getImag() async {
    final pickedFile = await picker.getImage(source: ImageSource.gallery);
    if (pickedFile != null) {
      _image = File(pickedFile.path);
      setState(() {});
    }
  }

  @override
  Widget build(BuildContext context) {

    double height = MediaQuery.of(context).size.height;
    double widht = MediaQuery.of(context).size.width;

    return SafeArea(
      child: Directionality(
          textDirection: TextDirection.rtl,
          child: Scaffold(
              backgroundColor: Colors.white,
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
                        SizedBox(height: height*.03,),
                        Padding(
                          padding: const EdgeInsets.all(8.0),
                          child: InkWell(
                              child: CircleAvatar(
                                child:_image == null
                                    ? Icon(Icons.add_a_photo,color: kMainColor,)
                                    : Image.file(_image),
                                backgroundColor:kCardColor,
                                radius: 60,
                              ),
                              onTap: () => getImag()),
                        ),
                        SizedBox(height: height*.02,),
                        Padding(
                          padding: EdgeInsets.symmetric(horizontal: 32),
                          child: Material(
                            elevation: 2.0,
                            color: kCardColor,
                            borderRadius: BorderRadius.all(Radius.circular(30)),
                            child: TextFormField(

                              controller: controleruser_name,
                              onChanged: (String value) {},
                              validator: (x) => x.isEmpty ? "هذا الحقل ضروري" : null,
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
                                  hintText: "الاسم",
                                  /*  hintStyle:
                      CustomStyle().textStyle(14.0, Colors.black),
                   */
                                  prefixIcon: Material(
                                    color: kCardColor,
                                    elevation: 0,
                                    borderRadius:
                                    BorderRadius.all(Radius.circular(30)),
                                    child: Icon(
                                      Icons.person,
                                      color: kMainColor,
                                    ),
                                  ),
                                  contentPadding: EdgeInsets.symmetric(
                                      horizontal: 25, vertical: 13)),
                            ),
                          ),
                        ),
                        SizedBox(
                          height: height*.03,
                        ),
                        Padding(
                          padding: EdgeInsets.symmetric(horizontal: 32),
                          child: Material(
                            elevation: 2.0,
                            color: kCardColor,
                            borderRadius: BorderRadius.all(Radius.circular(30)),
                            child: TextFormField(
                              keyboardType: TextInputType.emailAddress,
                              controller: controleruser_email,
                              onChanged: (String value) {},
                              validator: (x) => x.isEmpty ? "هذا الحقل ضروري" : null,
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
                          height: height*.03,
                        ),
                        Padding(
                          padding: EdgeInsets.symmetric(horizontal: 32),
                          child: Material(
                            elevation: 2.0,
                            color: kCardColor,
                            borderRadius: BorderRadius.all(Radius.circular(30)),
                            child: TextFormField(
                              keyboardType: TextInputType.phone,
                              controller: controleruser_phon,
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
                                  hintText: "رقم الهاتف",
                                  /*  hintStyle:
                      CustomStyle().textStyle(14.0, Colors.black),
                   */
                                  prefixIcon: Material(
                                    color: kCardColor,
                                    elevation: 0,
                                    borderRadius:
                                    BorderRadius.all(Radius.circular(30)),
                                    child: Icon(
                                      Icons.phone_iphone,
                                      color: kMainColor,
                                    ),
                                  ),
                                  contentPadding: EdgeInsets.symmetric(
                                      horizontal: 25, vertical: 13)),
                            ),
                          ),
                        ),
                        SizedBox(
                          height: height*.03,
                        ),
                        Padding(
                          padding: EdgeInsets.symmetric(horizontal: 32),
                          child: Material(
                            elevation: 2.0,
                            color: kCardColor,
                            borderRadius: BorderRadius.all(Radius.circular(30)),
                            child: TextFormField(
                              keyboardType: TextInputType.visiblePassword,
                              controller: controleruser_pass,
                              onChanged: (String value) {},
                              cursorColor: kMainColor,
                              validator: (x) => x.isEmpty ? "هذا الحقل ضروري" : null,
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
                                  /*  hintStyle:
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
                          height:height*.03,
                        ),
                        Padding(
                          padding: EdgeInsets.symmetric(horizontal: 32),
                          child: Material(
                            elevation: 2.0,
                            color: kCardColor,
                            borderRadius: BorderRadius.all(Radius.circular(30)),
                            child: TextFormField(
                             keyboardType: TextInputType.text,
                              controller: controleruser_address,
                              onChanged: (String value) {},
                              cursorColor:kMainColor,
                              validator: (x) => x.isEmpty ? "هذا الحقل ضروري" : null,
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
                                  hintText: "العنوان",
                                  /*  hintStyle:
                      CustomStyle().textStyle(14.0, Colors.black),
                   */
                                  prefixIcon: Material(
                                    color: kCardColor,
                                    elevation: 0,
                                    borderRadius:
                                    BorderRadius.all(Radius.circular(30)),
                                    child: Icon(
                                      Icons.location_on,
                                      color: kMainColor,
                                    ),
                                  ),
                                  contentPadding: EdgeInsets.symmetric(
                                      horizontal: 25, vertical: 13)),
                            ),
                          ),
                        ),
                        SizedBox(
                          height: height*.05,
                        ),
                        FlatButton(
                          onPressed: ()async {
                            if (fkey.currentState.validate()) {
                              if (_image == null) {
                                Service()
                                    .confirm(context, "يرجى إدراج الصورة ");
                              } else {
                                var url2 =
                                    "https://bbooksmarket.000webhostapp.com/bookMarketApi/saveImage.php";

                                List<int> imageBytes = _image.readAsBytesSync();
                                String imageB64 = base64Encode(imageBytes);
                                var response;
                                response = await http
                                    .post(url2, body: {
                                  "name": basename(_image.path),
                                  "image": imageB64,
                                })
                                    .timeout(Duration(
                                  seconds: 40,
                                ))
                                    .catchError((e) async {});
                                Service().addData(
                                    context,
                                    controleruser_name.text,
                                    "https://bbooksmarket.000webhostapp.com/bookMarketApi/img/${basename(_image.path)}",
                                    controleruser_pass.text,
                                    controleruser_email.text,
                                    controleruser_phon.text,
                                    controleruser_address.text);
                              }
                            }
                          },
                            child: Container(
                            decoration: BoxDecoration(
                              borderRadius: BorderRadius.circular(20),
                              gradient: LinearGradient(
                                begin: Alignment.centerLeft,
                                end: Alignment.centerRight,
                                colors: [
                                  kMainColor,
                                  kthirdColor,
                                ],
                              ),
                            ),
                            height: height*0.07,
                            width: widht*.5,
                            child: Center(
                              child: Text(
                                "إنشاء حساب",
                                  style: customtextStyle(20.0, kTextColor)
                              ),
                            ),
                          ),
                        ),
                         SizedBox(
                          height: height*.05,
                        ),
                      ],
                    ),
                  ),
                ),
              ))),
    );
  }
}
