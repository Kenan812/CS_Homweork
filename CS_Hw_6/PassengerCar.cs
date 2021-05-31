using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_6
{
    class PassengerCar : Car
    {
        public PassengerCar(string name, int speed) : base(name, speed) { }

        public PassengerCar() : base() { }


        public override string ToString()
        {
            return base.ToString() + $"\nType: Passenger Car";
        }

    }
}
