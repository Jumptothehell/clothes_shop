using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothes_shop
{
    class Shopcart
    {
        private List<Tshirt> OrderTshirt;
        private List<float> Totalcost;
        public Address house;

        public Shopcart(Address livighouse)
        {
            OrderTshirt = new List<Tshirt>();
            Totalcost = new List<float>();
            house = livighouse;
        }
        public Address AddHouseUser(string street, string city, string zipcode)
        {
            house = new Address(street, city, zipcode);
            return house;
        }

        public void addOrder(Tshirt Order)
        {
            OrderTshirt.Add(Order);
            Totalcost.Add(Order.cost);
        }

        public void ShowOrder()
        {
            foreach (Tshirt item in OrderTshirt)
            {
                Console.WriteLine(item.size + " "  + item.color + " " + item.cost + "-" + item.image);
            }
        }

        public void Showcost()
        {
            float Allcost = 0;
            for (int i = 0; i < OrderTshirt.Count; i++)
            {
                Allcost += Totalcost[i];
            }
            Console.WriteLine("Total cost = " + Allcost);
        }
        
    }
}
