using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Hw_6
{
    class Card
    {
        public string Suit { get; set; }

        public string Symbol { get; set; }  // in "\u266 " format


        public Card(string suit, string symbol)
        {
            Suit = suit;
            Symbol = symbol;
        }

        public Card()
        {
            Suit = "";
            Symbol = "";
        }


        public int GetIntValue()
        {
            if (Symbol == "6") return 6;
            if (Symbol == "7") return 7;
            if (Symbol == "8") return 8;
            if (Symbol == "9") return 9;
            if (Symbol == "10") return 10;
            if (Symbol == "J") return 11;
            if (Symbol == "D") return 12;
            if (Symbol == "K") return 13;
         
            return 14;
        }


        public override string ToString()
        {
            return $"{Symbol}{Suit}";
        }
    }
}
