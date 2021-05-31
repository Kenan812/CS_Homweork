using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_6
{
    class Truck : Car
    {
        public Truck(string name, int speed) : base(name, speed) { }

        public Truck() : base() { }

        public override string ToString()
        {
            return base.ToString() + $"\nType: Truck";
        }

    }
}
