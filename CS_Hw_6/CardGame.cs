using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_6
{
    class CardGame
    {
        string[] allSuits = new string[4];
        string[] allSymbols = new string[9];

        List<Card> deck = new List<Card>();
        List<Player> players = new List<Player>();


        public CardGame()
        {
            try
            {
                // Crating players
                
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                players.Add(new Player(name));
                Console.WriteLine();

                while (true)
                {
                    Console.Write("Enter name: ");
                    name = Console.ReadLine();
                    players.Add(new Player(name));
                    Console.WriteLine();

                    string ch;
                    Console.WriteLine("Another player?");
                    Console.Write("Enter choice(y/n): ");
                    ch = Console.ReadLine();

                    Console.Clear();
                    if (ch == "n") break;
                }
         
           

                // Creating deck

                allSuits[0] = "\u2663";
                allSuits[1] = "\u2660";
                allSuits[2] = "\u2666";
                allSuits[3] = "\u2665";

                allSymbols[0] = "6";
                allSymbols[1] = "7";
                allSymbols[2] = "8";
                allSymbols[3] = "9";
                allSymbols[4] = "10";
                allSymbols[5] = "J";
                allSymbols[6] = "D";
                allSymbols[7] = "K";
                allSymbols[8] = "A";

                // Forming a deck
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 9; j++)
                        deck.Add(new Card(allSuits[i], allSymbols[j]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                throw;
            }
        }

        public void StartNewGame()
        {
            ShuffleDeck();

            int idx = 0;
            // Distribute cards
            for (int j = 0; j < deck.Count / players.Count; j++)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    players[i].AddCard(deck[idx]);

                    idx++;
                }
            }
        }


        public void GameLoop()
        {
            StartNewGame();

            while (true)
            {
                PrintBoard();

                PlayRound();

                if (CheckForLoser() != -1) DeleteLoser();

                if (players.Count == 1) break;


                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.Write("The winner is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(players[0].Name);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public void PlayRound()
        {
            try
            {
                Random rnd = new Random();
                List<Card> cardsOnTable = new List<Card>();

                int idx;
                Console.Write("\n\nCards on table: ");
                

                // Cards put on table
                for (int i = 0; i < players.Count; i++)
                {
                    idx = rnd.Next(0, players[i].GetCards().Count);

                    Card c = players[i].TakeCard(idx);

                    Console.Write(c + " ");

                    cardsOnTable.Add(c);
                }

                Console.WriteLine();


                // winner takes all cards
                int winner = CompareCards(cardsOnTable);

                Console.WriteLine($"\nThe winner: {players[winner].Name}");
                for (int i = 0; i < cardsOnTable.Count; i++)
                {
                    players[winner].AddCard(cardsOnTable[i]);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }


        // retruns id of loser player
        // if no player lost returns -1
        public int CheckForLoser()
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].GetCards().Count <= 0) return i;
            }

            return -1;
        }

        public void DeleteLoser()
        {
            try
            {
                int idx = CheckForLoser();
                if (idx != -1)
                {
                    players.RemoveAt(idx);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return;
            }
            

        }


        public void PrintBoard()
        {
            PrintDeck();

            for (int i = 0; i < players.Count; i++)
            {
                players[i].PrintPlayer();
            }
        }


        public void PrintDeck()
        {
            for (int i = 0; i < deck.Count; i++)
                Console.Write($"{deck[i]} ");

            Console.WriteLine();
        }


        public void ShuffleDeck()
        {
            Random rnd = new Random();

            deck = deck.OrderBy(x => rnd.Next(0, deck.Count - 1)).ToList();
        }


        // returns the index of the highest card(index of player)
        public int CompareCards(List<Card> cards)
        {
            int res = 0;
            int max = 0;

            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].GetIntValue() > max)
                {
                    max = cards[i].GetIntValue();
                    res = i;
                }
            }

            return res;
        }


    }
}
