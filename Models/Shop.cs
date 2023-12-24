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

        public string Photo;
        
        public Shop()
        {

        }

        public Shop(int Id, string Name, int Price, string photo)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            Photo = photo;
        }
    }
}
