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
        public Sport(string Name, int Price, string Size) : base (Name, Price)
        {
            this.Size = Size;
        }
    }
}
