using System;
using System.Collections.Generic;

namespace clothes_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //สั่งซื้อเสื้อ --> ให้ข้อมูลชื่อ อีเมล ที่อยู่ --> แสดงราคา
            Shopcart Orderlist = new Shopcart(null);

            Tshirt Lred = new Tshirt("L", "Red", 500, "L Red shirt");
            Tshirt Mblack = new Tshirt("M", "Black", 750, "M Black shirt");
            Tshirt Swhite = new Tshirt("S", "White", 625, "S white shirt");

            Orderlist.addOrder(Lred);
            Orderlist.addOrder(Mblack);
            Orderlist.addOrder(Swhite);

            string nameuser = "Jame";
            string UserEmail = "Jame@gmail.com";

            User Jame = new User(nameuser, UserEmail, null);

            string street = "131 /75 Phutthamonthon";
            string city = "Nakhon Pathom";
            string zipcode = "10180";

            Address homeliving = new Address(street, city, zipcode);
            
            Jame.Addcart(homeliving);
            Jame.shopping.AddHouseUser(street, city, zipcode);

            Orderlist.Showcost();
        }


    }
}
