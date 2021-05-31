using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_6
{
    class Bus : Car
    {
        public Bus(string name, int speed) : base(name, speed) { }

        public Bus() : base() { }


        public override string ToString()
        {
            return base.ToString() + $"\nType: Bus";
        }

    }
}
