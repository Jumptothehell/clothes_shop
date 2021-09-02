using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothes_shop
{
    class User
    {
        public string name;
        public string email;
        public Shopcart shopping;

        public User(string username, string useremail, Shopcart userbuying)
        {
            name = username;
            email = useremail;
            shopping = userbuying;
        }

        public Shopcart Addcart(Address HOUSE)
        {
            shopping = new Shopcart(HOUSE);
            return shopping;
        }
    }
}
