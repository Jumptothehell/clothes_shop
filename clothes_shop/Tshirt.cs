using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothes_shop
{
    class Tshirt
    {
        public string size;
        public string color;
        public float cost;
        public string image;

        public Tshirt(string sh_size, string sh_color, float sh_cost, string sh_image)
        {
            size = sh_size;
            color = sh_color;
            cost = sh_cost;
            image = sh_image;
        }

    }
}
