

class ShopModel{
  int Book_Shop_id;
  String Book_Shop_name;
  String Book_Shop_img;
  String Book_Shop_address;
  String Book_Shop_phone;
  String Book_Shop_email;
  int Book_Shop_state;

  ShopModel.fromMap(Map<String,dynamic>map){
    Book_Shop_id=int.parse(map["Book_Shop_id"]);
    Book_Shop_name=map["Book_Shop_name"];
    Book_Shop_img=map["Book_Shop_img"];
    Book_Shop_address=map["Book_Shop_address"];
    Book_Shop_phone=map["Book_Shop_phone"];
    Book_Shop_email=map["Book_Shop_email"];
    Book_Shop_state=int.parse(map["Book_Shop_state"]);
  }
}