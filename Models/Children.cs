using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Кылосов.Models
{
    public class Children : Shop
    {
        public int Age { get; set; }
        public int IdShop { get; set; }
        public Children() { }
        public Children(string Name, int Price, int Age, int IdShop) : base(IdShop, Name, Price)
        {
            this.Age = Age;
            this.IdShop = IdShop;
        }
    }
}
