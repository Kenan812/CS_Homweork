using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_4
{
    class Rectangle : Figure
    {
        public override void Print()
        {
            Console.WriteLine("***************");

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (j == 0 || j == 14) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************");
        }
    }
}
