using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLogic
{
    public class Shop
    {
        public Item Details { get; set; }
        public int Price { get; set; }

        public Shop(Item details,int price)
        {
            Details = details;
            Price = price;
        }
            
    }
}
