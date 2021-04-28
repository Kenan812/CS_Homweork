using System;

namespace CS_Hw1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1

            /*
            string c;
            int count = 0;

            while(true)
            {
                c = Console.ReadLine();

                if (c.StartsWith(" ")) count++;

                if (c.StartsWith(".")) break;

            }

            Console.WriteLine("Count: " + count);
            */

            #endregion



            #region Task 2


            /*
            Console.Write("Enter ticket number(6-digit): ");
            string num_tmp = Console.ReadLine();

            if (num_tmp.Length != 6)
                Console.WriteLine("Provided number is not 6-digit");
            

            else
            {
                int num = Int32.Parse(num_tmp);

                if ( ((num / 100000) + (num / 10000 % 10) + (num / 1000 % 10) ) == ( (num / 100 % 10) + (num / 10 % 10) + (num % 10) ) ) 
                    Console.WriteLine("This ticket is happy");

                else Console.WriteLine("This ticket is not happy");
            }
            */

            #endregion



            #region Task 3

            /*

            Console.WriteLine("Enter non letter to exit");
            int s;

            while(true)
            {
                Console.Write("Enter letter: ");
                s = Console.Read();

                if (s >= 97 && s <= 122)
                    s -= 32;
                else if (s >= 65 && s <= 90)
                    s += 32;
                else break;

                Console.WriteLine($"Result: {(char)s}");
                Console.ReadLine();
            }
            
            */

            #endregion



            #region Task 4


            /*
            string A_tmp, B_tmp;
            Console.Write("Enter A: ");
            A_tmp = Console.ReadLine();

            Console.Write("Enter B: ");
            B_tmp = Console.ReadLine();

            int A = Int32.Parse(A_tmp);
            int B = Int32.Parse(B_tmp);


            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(i + " ");

                Console.WriteLine();
            }
            */


            #endregion



            #region Task 5


            /*
            Console.Write("Enter number: ");
            string n = Console.ReadLine();

            Console.Write("Reversed number: ");
            for (int i = n.Length - 1; i >= 0; i--)
                Console.Write(n[i]);

            Console.WriteLine();
            */


            #endregion

        }
    }
}
