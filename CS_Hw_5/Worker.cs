using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Hw_5.Interfaces;

namespace CS_Hw_5
{
    class Worker : IWorker
    {
        public bool Work(ref House house)
        {
            bool isWalls = false;
            bool isRoof = false;
            bool isDoor = false;
            bool isWindow = false;


            Console.WriteLine("Starting Check...");
            System.Threading.Thread.Sleep(1000);

            if (house.BasementCount == 0)
            {
                Console.WriteLine("Basement not ready");
                house.HouseBasement.Build();
                house.BasementCount++;
            }
            else
            {
                Console.WriteLine("Basement ready!");
                isWalls = true;
            }

            System.Threading.Thread.Sleep(1000);
            if (isWalls)
            {
                if (house.WallsCount < 4)
                {
                    Console.WriteLine("\nWalls not ready");
                    house.HouseWalls.Build();
                    house.WallsCount++;
                }
                else
                {
                    Console.WriteLine("Walls ready!");
                    isRoof = true;
                }
            }


            System.Threading.Thread.Sleep(1000);
            if (isRoof)
            {
                if (house.RoofCount == 0)
                {
                    Console.WriteLine("\nRoof not ready");
                    house.HouseRoof.Build();
                    house.RoofCount++;
                }
                else
                {
                    Console.WriteLine("Roof ready!");
                    isDoor = true;
                }
            }


            System.Threading.Thread.Sleep(1000);
            if (isDoor)
            {
                if (house.DoorCount == 0)
                {
                    Console.WriteLine("\nDoor not ready");
                    house.HouseDoor.Build();
                    house.DoorCount++;
                }
                else
                {
                    Console.WriteLine("Door ready!");
                    isWindow = true;
                }
            }


            System.Threading.Thread.Sleep(1000);
            if (isWindow)
            {
                if (house.WindowCount < 4)
                {
                    Console.WriteLine("\nWindow not ready");
                    house.HouseWindow.Build();
                    house.WindowCount++;
                }
                else
                {
                    Console.WriteLine("Windows ready!");
                    return true;
                }
            }

            return false;
        }
    }
}
