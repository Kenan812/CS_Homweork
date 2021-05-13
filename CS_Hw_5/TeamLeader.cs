using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Hw_5.Interfaces;

namespace CS_Hw_5
{
    class TeamLeader : IWorker
    {
        public bool Work(ref House house)
        {
            int c = 0;

            c += house.BasementCount + house.DoorCount + house.WallsCount + house.RoofCount + house.WindowCount;

            Console.WriteLine($"Basement built: {house.BasementCount}");
            Console.WriteLine($"Walls built: {house.WallsCount}");
            Console.WriteLine($"Roof built: {house.RoofCount}");
            Console.WriteLine($"Door built: {house.DoorCount}");
            Console.WriteLine($"Window built: {house.WindowCount}");

            float p = (float)c / 11 * 100;

            Console.WriteLine($"% of work done: {p}");

            if (c == 11) return true;

            return false;
        }

    }
}
