using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_4
{
    class Rhombus : Figure
    {
        public override void Print()
        {
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    if (j == Math.Abs(10 - i) || j == (10 + i)) Console.Write("*");
                    else if (i > 10 && j == 20 - (Math.Abs(10 - i))) Console.Write("*");
                    else Console.Write(" ");

                }

                Console.WriteLine();
            }
        }

    }
}
