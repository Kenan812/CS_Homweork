using CS_Hw_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS_Hw_5
{
    class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Starting building Roof...");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Roof was succcessfully built.");
        }
    }
}
