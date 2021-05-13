using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_5
{
    class House
    {
        //
        // Building plan: Basement -> Walls -> Roof -> Door -> Window

        public int BasementCount { get; set; }
        public int WallsCount { get; set; }
        public int RoofCount { get; set; }
        public int DoorCount { get; set; }
        public int WindowCount { get; set; }

        public Basement HouseBasement{ get; set; }
        public Walls HouseWalls{ get; set; }
        public Roof HouseRoof { get; set; }
        public Door HouseDoor { get; set; }
        public Window HouseWindow { get; set; }


        public House()
        {
            BasementCount = 0;
            WallsCount = 0;
            RoofCount = 0;
            DoorCount = 0;
            WindowCount = 0;

            HouseBasement = new Basement();
            HouseWalls = new Walls();
            HouseRoof = new Roof();
            HouseDoor = new Door();
            HouseWindow = new Window();
        }

        
        public void Print()
        {
            Console.WriteLine($"                       {(char)9632} ");
            Console.WriteLine($"                     {(char)9632}   {(char)9632}");
            Console.WriteLine($"                   {(char)9632}       {(char)9632}");
            Console.WriteLine($"                 {(char)9632}           {(char)9632}");
            Console.WriteLine($"               {(char)9632}               {(char)9632}");
            Console.WriteLine($"             {(char)9632}                   {(char)9632}");
            Console.WriteLine($"           {(char)9632}                       {(char)9632}");
            Console.WriteLine($"         {(char)9632}                           {(char)9632}");
            Console.WriteLine($"       {(char)9632}                               {(char)9632}");
            Console.WriteLine($"     {(char)9632}                                   {(char)9632}");
            
            Console.Write("   ");
            for (int i = 0; i < 21; i++)
            {
                Console.Write($"{(char)9632} ");
            }
            Console.WriteLine();



            for (int i = 0; i < 15; i++)
            {
                Console.Write("   ");
                if (i == 2 || i == 5)
                {
                    Console.Write($"{(char)9632}");
                    Console.Write($"\t   {(char)9632} {(char)9632} {(char)9632} {(char)9632}           {(char)9632} {(char)9632} {(char)9632} {(char)9632}\t   ");
                    Console.Write($"{(char)9632}");
                }
                else if (i > 2 && i < 5)
                {
                    Console.Write($"{(char)9632}");
                    Console.Write($"\t   {(char)9632}     {(char)9632}           {(char)9632}     {(char)9632}\t   ");
                    Console.Write($"{(char)9632}");
                }


                else if (i == 10)
                {
                    Console.Write($"{(char)9632}");
                    Console.Write($"\t\t   {(char)9632} {(char)9632} {(char)9632} {(char)9632} {(char)9632} \t\t   ");
                    Console.Write($"{(char)9632}");
                }

                else if (i == 12)
                {
                    Console.Write($"{(char)9632}");
                    Console.Write($"\t\t   {(char)9632}  {(char)9632}    {(char)9632} \t\t   ");
                    Console.Write($"{(char)9632}");
                }

                else if (i > 10)
                {
                    Console.Write($"{(char)9632}");
                    Console.Write($"\t\t   {(char)9632}       {(char)9632} \t\t   ");
                    Console.Write($"{(char)9632}");
                }

                else
                {
                    Console.Write($"{(char)9632}\t\t\t\t\t   {(char)9632}");
                }
                Console.WriteLine();
            }





            Console.Write("   ");
            for (int i = 0; i < 21; i++)
            {
                Console.Write($"{(char)9632} ");
            }
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }


    }
}
