

class Product{
  int Book_Product_id;
  String Book_Product_name;
  String Book_Product_img;
  int Book_Product_price;
  int Book_Product_quntity;
  String Book_Product_descrption;
  String Book_Product_author;
  int Book_Product_shopid;
  int Book_Product_categoryid;

  Product.fromMap(Map<String,dynamic>map){
    Book_Product_id=int.parse(map["Book_Product_id"]);
    Book_Product_name=map["Book_Product_name"];
    Book_Product_img=map["Book_Product_img"];
    Book_Product_price=int.parse(map["Book_Product_price"]);
    Book_Product_quntity=int.parse(map["Book_Product_quntity"]);
    Book_Product_descrption=map["Book_Product_descrption"];
    Book_Product_author=map["Book_Product_author"];
    Book_Product_shopid=int.parse(map["Book_Product_shopid"]);
    Book_Product_categoryid=int.parse(map["Book_Product_categoryid"]);

  }
}