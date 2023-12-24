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


        public Sport(string Name, int Price, string Size, int IdShop, string Photo) : base (IdShop, Name, Price, Photo)
        {
            this.Size = Size;
            this.IdShop = IdShop;
        }
    }
}
