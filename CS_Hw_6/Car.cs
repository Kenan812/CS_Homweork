using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_Hw_6
{
    abstract class Car
    {
        public delegate void CarStartRaceDelegate(Car c);
        public event CarStartRaceDelegate startRace;

        public string Name { get; set; }

        public int MaxSpeed { get; set; }  // Max speed of car in m/s

        public double PosX { get; set; }  // Current position of the car(ends at 1000m)


        public Car(string name, int speed)
        {
            Name = name;
            MaxSpeed = speed;
            PosX = 0;
        }

        public Car()
        {
            Name = "";
            MaxSpeed = 0;
            PosX = 0;
        }


        // t - seconds passed after start of race
        public void Move(int t)
        {
 ;          PosX += (Math.Sqrt(MaxSpeed) * t) / 2;
        }

        public void PrepareCar(Car c)
        {
            startRace?.Invoke(c);
        }

        public override string ToString()
        {
            return $"Name: {Name}\nMax speed: {MaxSpeed}m/s";
        }
    }
}
