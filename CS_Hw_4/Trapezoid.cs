using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_4
{
    class Trapezoid : Figure
    {
        public override void Print()
        {
            Console.WriteLine("\t   **********");
        
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (j == 10 - i) Console.Write("*");
                    else if (j == 20 + i) Console.Write(" *");
                    else Console.Write(" ");

                }


                Console.WriteLine();
            }
            
            Console.WriteLine("********************************");
        }

    }
}
