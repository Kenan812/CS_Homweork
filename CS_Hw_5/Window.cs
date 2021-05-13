using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Hw_5.Interfaces;

namespace CS_Hw_5
{
    class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Starting building Window...");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Window was succcessfully built.");
        }
    }
}
