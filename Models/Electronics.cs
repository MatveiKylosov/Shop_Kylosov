using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Кылосов.Models
{
    public class Electronics : Shop
    {
        public Electronics() { }
        public string DrivingSpeed { get; set; }
        public int IdShop { get; set; }

        public Electronics(string Name, int Price, int Id, string DrivingSpeed) : base(Id, Name, Price)
            => this.DrivingSpeed = DrivingSpeed;
    }
}
