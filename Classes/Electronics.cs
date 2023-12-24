using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Кылосов.Classes
{
    public class Electronics : Shop
    {
        public double BatterCapacity { get; set; }
        public string DrivingSpeed { get; set; }
        public Electronics(string Name, int Price, double BatterCapacity = 0) : base (Name, Price)
            => this.BatterCapacity = BatterCapacity;

        public Electronics(string Name, int Price, string DrivingSpeed) : base(Name, Price)
            => this.DrivingSpeed = DrivingSpeed;
    }
}
