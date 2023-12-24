using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Кылосов.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Shop()
        {

        }
        public Shop(int Id, string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
