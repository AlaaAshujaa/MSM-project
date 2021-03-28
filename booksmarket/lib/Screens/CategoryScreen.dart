import 'package:booksmarket/Helper/Service.dart';
import 'package:booksmarket/Models/Category_Model.dart';
import 'package:booksmarket/Screens/Product_Cat_id.dart';
import 'package:flutter/material.dart';

import '../constants.dart';

class CategoryScreen extends StatefulWidget {
  @override
  _CategoryScreenState createState() => _CategoryScreenState();
}

class _CategoryScreenState extends State<CategoryScreen> {

  bool _loading = true;
  List<CategoryModel> cate_list = [];

  void getcateList() async {
    Service service = Service();
    await service.loadCateList();
    cate_list = service.cateList;
    setState(() {
      _loading = false;
    });
  }

  @override
  void initState() {
    super.initState();
    getcateList();
  }

  @override
  Widget build(BuildContext context) {
    double height = MediaQuery.of(context).size.height;
    double widht = MediaQuery.of(context).size.width;

    return SafeArea(
      child: Directionality(
        textDirection: TextDirection.rtl,
        child: Scaffold(
            body: ListView(
              children: <Widget>[
                GridView.builder(
                  physics: ClampingScrollPhysics(),
                    shrinkWrap: true,
                    itemCount: cate_list.length,
                    gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                        crossAxisCount: 2),
                    itemBuilder: (ctx, index) {
                      return _loading==false?Padding(
                        padding: const EdgeInsets.all(8.0),
                        child: GestureDetector(
                          onTap: () {
                            print(
                                "samarid${cate_list[index].Book_cat_id}");
                            Navigator.of(context).push(
                                new MaterialPageRoute(
                                    builder: (context) =>
                                    new Product_Cat_id(
                                      cate_id: cate_list[index]
                                          .Book_cat_id,
                                    )));
                          },
                          child: Card(
                            color: kCardColor,
                            shape: RoundedRectangleBorder(
                              borderRadius: BorderRadius.all(
                                Radius.circular(15),
                              ),
                            ),
                            child: Column(
                              children: <Widget>[
                                Padding(
                                  padding: const EdgeInsets.all(8.0),
                                  child: Container(
                                    width: 90,
                                    height: 90,
                                    decoration: BoxDecoration(
                                        borderRadius: BorderRadius.all(Radius.circular(5.0)),
                                        image: DecorationImage(
                                            image: NetworkImage(
                                                cate_list[index].Book_cat_img),
                                            fit: BoxFit.fill)),
                                  ),
                                ),
                                SizedBox(
                                  height: height * .02,
                                ),
                                Flexible(
                                  child: Row(
                                    children: <Widget>[
                                      Padding(
                                        padding: const EdgeInsets.only(right: 4.0),
                                        child: Icon(Icons.category,color: kMainColor,),
                                      ),
                                      SizedBox(
                                        width: widht * .02,
                                      ),
                                      Text(
                                        cate_list[index].Book_cat_name,
                                        style: customtextStyle(15.0, kTextColor),
                                      ),
                                    ],
                                  ),
                                ),
                                SizedBox(
                                  height: height * .02,
                                ),

                              ],
                            ),
                          ),
                        ),
                      )
                          :Center(child: CircularProgressIndicator(),);
                    }),
              ],
            )),
      ),
    );
  }
}
