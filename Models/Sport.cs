using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Кылосов.Models
{
    public class Sport : Shop
    {
        public string Size;
        public int IdShop { get; set; }
        public Sport() { }


        public Sport(string Name, int Price, string Size, int IdShop) : base (IdShop, Name, Price)
        {
            this.Size = Size;
            this.IdShop = IdShop;
        }
    }
}
