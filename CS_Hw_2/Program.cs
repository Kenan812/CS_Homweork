using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_2
{
    partial class Refrigerator
    {
        public static int refrigiratorCount;


        #region Properties

        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public double Height { get; set; }
        public double Volume { get; set; }

        #endregion


        #region Constructers

        public Refrigerator()
        {
            Model = "";
            Color = "";
            Price = 0;
            Height = 0;
            Volume = 0;
            refrigiratorCount++;
        }

        public Refrigerator(string model, string color, int price, double height, double volume)
        {
            Model = model;
            Color = color;
            Price = price;
            Height = height;
            Volume = volume;
            refrigiratorCount++;
        }

        public Refrigerator(string model, string color, int price, double height)
        {
            Model = model;
            Color = color;
            Price = price;
            Height = height;
            refrigiratorCount++;
        }

        public Refrigerator(string model, string color, int price)
        {
            Model = model;
            Color = color;
            Price = price;
            refrigiratorCount++;
        }

        public Refrigerator(string model, string color)
        {
            Model = model;
            Color = color;
            refrigiratorCount++;
        }

        public Refrigerator(string model)
        {
            Model = model;
            refrigiratorCount++;
        }

        static Refrigerator()
        {
            refrigiratorCount = 0;
        }

        #endregion


        #region Methods
        
        
        public void CopyRefrigerator(ref Refrigerator r)
        {
            Model = r.Model;
            Color = r.Color;
            Price = r.Price;
            Height = r.Height;
            Volume = r.Volume;
        }


        public void Print()
        {
            if (!String.IsNullOrEmpty(Model))
                Console.WriteLine($"Model: {Model}");
            else
                Console.WriteLine("Model unknown");


            if (!String.IsNullOrEmpty(Color))
                Console.WriteLine($"Color: {Color}");
            else
                Console.WriteLine("Color unknown");

            if (Price != 0)
                Console.WriteLine($"Price: {Price}");
             else
                Console.WriteLine("Price unknown");

            if (Height != 0)
                Console.WriteLine($"Height: { Height}");
            else Console.WriteLine("Height unknown");

            if (Volume != 0)
                Console.WriteLine($"Volume: {Volume}");
            else
                Console.WriteLine("Volume unknown");
        }


        public double GetVolume(double length, double width)
        {
            if (Height != 0)
                Volume = length * width * Height;
            else
                Console.WriteLine("Height is unknown");

            return Volume;
        }

        public double GetVolume(double length, double width, double height)
        {
            Height = height;
            Volume = length * width * height;
            return Volume; 
        }


        #endregion


    }


    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator[] refrigerators = new Refrigerator[5]
            {
                new Refrigerator("Whirlpool 340 L Frost Free 3 Star Refrigerator", "Black", 2000, 2, 20),
                new Refrigerator("Haier 320 L Frost Free 3 Star Refrigerator", "White", 1500, 2.15),
                new Refrigerator("Samsung 253 L Frost Free 4 Star Refrigerator", "Gray", 1679),
                new Refrigerator(),
                new Refrigerator("Samsung 253 L Frost Free 4 Star Refrigerator", "Black")
            };

            Console.WriteLine($"Total number of refrigerators: {Refrigerator.refrigiratorCount}");

            for (int i = 0; i < refrigerators.Length; i++)
            {
                Console.WriteLine($"Refrigirator #{i + 1}");
                refrigerators[i].Print();
                Console.WriteLine();
            }

            refrigerators[3].CopyRefrigerator(ref refrigerators[0]);
            refrigerators[3].Print();

            Console.WriteLine();
            Console.WriteLine(refrigerators[0].IsOptimalPrice(2000)); 
            Console.WriteLine(refrigerators[0].IsOptimalPrice(1000)); 

        }
    }
}
