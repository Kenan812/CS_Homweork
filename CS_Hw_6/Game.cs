using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CS_Hw_6
{

    /*  For Car Race  */


    class Game
    {
        public delegate void GameDelegate(Car c);
        public event GameDelegate showWinner;


        private List<Car> cars = new List<Car>();  // max 4 cars

        public int Time { get; set; }


        public Game()
        {
            cars.Add(new SportCar("2014 Koenigsegg One:1", 121));
            cars.Add(new Truck("Ram 1500", 29));
            cars.Add(new Bus("Minibus", 22));
            cars.Add(new PassengerCar("Tesla Model X", 58));

            Time = 0;
        }


        public void Start()
        {
            showWinner += PrintWinner;

            for(int i = 0; i < cars.Count; i++)
            {
                cars[i].startRace += PrepareToStart;
                cars[i].PrepareCar(cars[i]);
            }


            while(true)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();


                PrintGameBoard();
                Time++;

                for (int i = 0; i < cars.Count; i++)
                {
                    cars[i].Move(Time);

                    if (cars[i].PosX >= 1000)
                    {
                        cars[i].PosX = 1000;
                        Console.Clear(); 
                        PrintGameBoard();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        showWinner?.Invoke(cars[i]);
                        return;
                    }
                }
            }
        }


        public void PrintGameBoard()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\tCARS AND THEIR POSITIONS\n\n");


            for (int i = 0; i < cars.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t{cars[i].Name}\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Position: {(int)cars[i].PosX}\n\n");
            }
        }

        public void PrepareToStart(Car c)
        {
            Console.WriteLine(c);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ready for race\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintWinner(Car c)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t<<The winner is>>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(c);
        }
    }
}
