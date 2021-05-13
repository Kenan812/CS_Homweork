using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_5
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team();

            while (true)
            {
                try
                {
                    Console.WriteLine("Choose worker:\n(1) Builder\n(2) Team Leader\n(3) Fast skip");
                    int c = Int32.Parse(Console.ReadLine());

                    if (c == 1)
                    {
                        team.Worker.Work(ref house);
                    }

                    else if (c == 2)
                    {
                        team.TeamLeader.Work(ref house);
                    }

                    else if (c == 3) break;

                    Console.WriteLine("Enter any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    if (house.WindowCount == 4) break;  // when house is ready
                }

                catch(Exception e)
                {
                    Console.WriteLine(e.Message + "\n" + e.TargetSite);
                }
            }

            Console.WriteLine("Building ready");
            house.Print();

        }
    }
}
