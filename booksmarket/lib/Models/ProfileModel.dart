class ProfileModel{
  int user_id;
  String user_name;
  String user_phone;
  String user_address;
  String user_password;
  String user_email;
  String user_img;

  ProfileModel.fromMap(Map<String,dynamic>map){
    user_id=int.parse(map["user_id"]);
    user_name=map["user_name"];
    user_img=map["user_img"];
    user_phone=map["user_phonenumber"];
    user_address=map["user_address"];
    user_password=map["user_password"];
    user_email=map["user_email"];

  }

}