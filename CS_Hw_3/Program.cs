using System;
using MyClassLib.WorldOfTanks;

namespace CS_Hw_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] tanks_T_34 = new Tank[5];
            Tank[] tanks_Pantera = new Tank[5];
            


            // Pre Game
            for (int i = 0; i < 5; i++)
            {
                tanks_T_34[i] = new Tank("T-34");
            }

            for (int i = 0; i < 5; i++)
            {
                tanks_Pantera[i] = new Tank("Pantera");
            }


            for (int i = 0; i < 5; i++)
            {
                Battle(tanks_T_34[i], tanks_Pantera[i]);
                Console.WriteLine("Press any key to see the next battle...");
                Console.ReadKey();
                Console.Clear();
            }
        }


        public static void Battle(Tank t1, Tank t2)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("\t\t\tT-34\tPantera");
            Console.WriteLine($"Ammunition Level: \t{t1.AmmunitionLevel}\t{t2.AmmunitionLevel}");
            Console.WriteLine($"Armor Level: \t\t{t1.ArmorLevel}\t{t2.ArmorLevel}");
            Console.WriteLine($"Maneuverability Level:  {t1.ManeuverabilityLevel}\t{t2.ManeuverabilityLevel}");
            Console.WriteLine($"\n\t\tWinner: {t1 * t2}");
            Console.WriteLine("=====================================================\n\n\n");
        }


    }
}
