using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_6
{
    class SportCar : Car
    {
        public SportCar(string name, int speed) : base(name, speed) { }

        public SportCar() : base() { }


        public override string ToString()
        {
            return base.ToString() + $"\nType: Sport Car";
        }
    }
}
