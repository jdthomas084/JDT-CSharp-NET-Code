using System;
using System.Collections;

/*
CARD CLASS, Authored by Joshua D. Thomas,
M.S., I.S.T - Internet/Web Design (Anticipated 2027)

C# Console Application - Initialize a Deck of Cards
CARD.CS - Joshua D. Thomas

This program initializes a customized Deck of Playing Cards.

One Day, I might turn this into a full-featured Turn-based game...

joshuad_thomas@comcast.net
Tools Used: grey matter, VS Code, Debugging skills
*/

namespace MyConsoleApp
{
    class Card
    {
        public Card()
        {
            this.Rank = -1;
            this.Suit = -1;
            this.Facing = false;
        }

        public Card(int rnk, int sut)
        {           
            this.Rank = rnk;     
            this.Suit = sut;
            this.Facing = false;
            this.str_Rank = set_Rank_string(rnk);
            this.str_Suit = set_Suit_string(sut);
        }

        int Rank;
        int Suit;
        bool Facing;
        string str_Rank;
        string str_Suit;

        public int get_Rank(){
            return this.Rank;
        }

        public string get_Rank_str(){
            return this.str_Rank;
        }

        public int get_Suit(){
            return this.Suit;
        }

        public string get_Suit_str(){
            return this.str_Suit;
        }

        public bool get_Facing(){
            return this.Facing;
        }

        public void set_Facing(){
            this.Facing = !this.Facing;
        }

        private string set_Suit_string(int s){
            switch(s){
                case 14: return "CLUBS";
                case 15: return "DIAMONDS";
                case 16: return "HEARTS";
                case 17: return "SPADES";
                case 18: return "SWORDS";
                case 19: return "JAVELINS";
                case 20: return "STARS";
                case 21: return "ARCS";
                case 22: return "ORBS";
                case 23: return "BATTLESHIPS";
                case 24: return "GREAT DANES";
                case 25: return "FLYING EAGLES";
                default: return "INVALID";
                    break;
            }
        }

        private string set_Rank_string(int r){
            switch(r){
                case 1: return "ACE";
                case 2: return "DEUCE";
                case 3: return "THREE";
                case 4: return "FOUR";
                case 5: return "FIVE";
                case 6: return "SIX";
                case 7: return "SEVEN";
                case 8: return "EIGHT";
                case 9: return "NINE";
                case 10: return "TEN";
                case 11: return "JACK";
                case 12: return "QUEEN";
                case 13: return "KING";
                default: return "INVALID";
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList deck = new ArrayList();
            
            int counter = 0;
            for (int s = 25; s >= 14; s--)
            {
                for (int r = 1; r < 14; r++)
                {
                    Card tmpCard = new Card(r, s);
                    deck.Add(tmpCard);
                    System.Console.WriteLine(tmpCard.get_Rank_str() + " of " + tmpCard.get_Suit_str() + " facing " + tmpCard.get_Facing() + ".");
                }
            }

            System.Console.WriteLine("Deck Initialized.");

        }
    }
}
