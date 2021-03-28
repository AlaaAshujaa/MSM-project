import 'package:booksmarket/Helper/Category_Data.dart';
import 'package:booksmarket/Helper/Service.dart';
import 'package:booksmarket/Models/Category_Model.dart';
import 'package:booksmarket/Models/ProductModel.dart';
import 'package:booksmarket/Models/Productt.dart';
import 'package:booksmarket/Screens/Product_Cat_id.dart';
import 'package:booksmarket/Widgets/Category_Card.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';
import '../constants.dart';
import 'DetailsScreen.dart';

class MainScreen extends StatefulWidget {
  @override
  _MainScreenState createState() => _MainScreenState();
}

class _MainScreenState extends State<MainScreen> {
  bool _loading = true;
  bool loading = true;
  List<Productt> productt_list = [];

  void getproductList() async {
    Service service = Service();
    await service.loadpList();
    productt_list = service.ProducttList;
    setState(() {
      loading = false;
    });
  }

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
    getproductList();
  }

  @override
  Widget build(BuildContext context) {
    double height = MediaQuery.of(context).size.height;
    double widht = MediaQuery.of(context).size.width;
    return SafeArea(
      child: Directionality(
        textDirection: TextDirection.rtl,
        child: Scaffold(
          body: Stack(children: [
            Padding(
              padding: EdgeInsets.symmetric(horizontal: 10, vertical: 10),
              child: SingleChildScrollView(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.stretch,
                  children: <Widget>[
                    SizedBox(
                      height: height * .03,
                    ),
                    Padding(
                      padding: const EdgeInsets.only(right: 10.0),
                      child: Text(
                        "الاقــسام",
                        textAlign: TextAlign.right,
                        style: customtextStyle(20.0, kTextColor),
                      ),
                    ),
                    SizedBox(height: height * .02),
                    SizedBox(
                      height: height * .2,
                      child: _loading == false
                          ? ListView.builder(
                              scrollDirection: Axis.horizontal,
                              itemCount: cate_list.length,
                              itemBuilder: (context, index) => GestureDetector(
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
                                child: CategoriesCard(
                                  image: cate_list[index].Book_cat_img,
                                  title: cate_list[index].Book_cat_name,
                                  color: cate_list.elementAt(1) == true
                                      ? kMainColor
                                      : kMainColor,
                                ),
                              ),
                            )
                          : Center(
                              child: CircularProgressIndicator(),
                            ),
                    ),
                    Padding(
                      padding: const EdgeInsets.all(10),
                      child: Text(
                        "الكتــب الأكثر مبيــعاً",
                        textAlign: TextAlign.right,
                        style: customtextStyle(20.0, kTextColor),
                      ),
                    ),
                    SizedBox(
                      height: height * .01,
                    ),
                    loading == false
                        ? ListView.builder(
                            shrinkWrap: true,
                            physics: ClampingScrollPhysics(),
                            scrollDirection: Axis.vertical,
                            itemCount: productt_list.length,
                            itemBuilder: (ctx, index) {
                              return GestureDetector(
                                onTap: ()=>Navigator.of(
                                  context)
                                  .push(new MaterialPageRoute(
                                //here we are pasting values of products to the products details page
                                builder: (context) =>
                                    DetailsScreen(cate_id: productt_list[index].Book_Product_id,),),),
                                child: Padding(
                                  padding: const EdgeInsets.all(8.0),
                                  child: Card(
                                    color: kCardColor,
                                    shape: RoundedRectangleBorder(
                                      borderRadius: BorderRadius.all(
                                        Radius.circular(30),
                                      ),
                                    ),
                                    child: Container(
                                      child: Row(
                                        children: <Widget>[
                                          Expanded(
                                            child: ClipRRect(
                                              borderRadius: BorderRadius.only(
                                                topRight: Radius.circular(30),
                                                bottomRight: Radius.circular(30),
                                              ),
                                              child: Image.network(
                                                  productt_list[index]
                                                      .Book_Product_img),
                                            ),
                                          ),
                                          SizedBox(
                                            width: widht * .03,
                                          ),
                                          Flexible(
                                            child: Column(
                                              children: <Widget>[
                                                Text(
                                                  productt_list[index]
                                                      .Book_Product_name,
                                                  style: customtextStyle(
                                                      15.0, kTextColor),
                                                ),
                                                SizedBox(
                                                  height: height * .02,
                                                ),
                                                Row(
                                                  children: <Widget>[
                                                    Icon(
                                                      Icons.person,
                                                      color: kMainColor,
                                                    ),
                                                    SizedBox(
                                                      width: widht * .03,
                                                    ),
                                                    Flexible(
                                                        child: Text(
                                                      productt_list[index]
                                                          .Book_Product_author,
                                                      style: textStyle(
                                                          15.0, kTextColor),
                                                    )),
                                                  ],
                                                ),
                                                SizedBox(
                                                  height: height * .02,
                                                ),
                                                Padding(
                                                  padding: const EdgeInsets.only(
                                                      right: 18.0),
                                                  child: Text(
                                                    productt_list[index]
                                                        .Book_Product_price
                                                        .toString(),
                                                    style: customtextStyle(
                                                        20.0, kTextColor),
                                                  ),
                                                ),
                                              ],
                                            ),
                                          ),
                                          Expanded(
                                            child: IconButton(
                                              onPressed: () => Navigator.of(
                                                      context)
                                                  .push(new MaterialPageRoute(
                                                      //here we are pasting values of products to the products details page
                                                      builder: (context) =>
                                                          DetailsScreen(cate_id: productt_list[index].Book_Product_id,),),),
                                              icon: Icon(Icons.arrow_forward_ios),
                                            ),
                                          )
                                        ],
                                      ),
                                    ),
                                  ),
                                ),
                              );
                            })
                        : Center(
                            child: CircularProgressIndicator(),
                          ),
                  ],
                ),
              ),
            ),
          ]),
        ),
      ),
    );
  }
}
