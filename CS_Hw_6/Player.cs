using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_6
{
    class Player
    {
        public string Name { get; set; }

        List<Card> cards = new List<Card>();


        public Player(string name)
        {
            Name = name;
        }

        public Player()
        {
            Name = "";
        }

        public List<Card> GetCards()
        {
            return cards;
        }


        public void AddCard(Card c)
        {
            cards.Add(c);
        }
        

        public Card TakeCard(int index)
        {
            Card c = new Card();
            c = cards[index];
            cards.RemoveAt(index);
            return c;
        }


        public void PrintHand()
        {
            for (int i = 0; i < cards.Count; i++)
                Console.Write($"{cards[i]} ");

            Console.WriteLine();
        }

        //
        // Prints everything about player
        // Used to display hand
        public void PrintPlayer()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.White;

            PrintHand();
            Console.WriteLine($"Number of cards: {cards.Count}\n");
        }
    }
}
