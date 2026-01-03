using System.Collections;

/*
CARD CLASS, Authored by Joshua D. Thomas,
M.S., I.S.T. - Internet/Web Design (Anticipated 2027)

C# Console Application - Initialize a Deck of Cards
CARD.CS - Joshua D. Thomas

This program initializes a customized Deck of Playing Cards.

One Day, I might turn this into a full-featured Turn-based game...

joshuad_thomas@comcast.net
Tools Used: grey matter, VS Code, Debugging skills
*/

namespace MyConsoleApp
{
    /*
        Lines 24 - 121: Custom CARD CLASS
    */
    
    class Card
    {
        // New CARD Without anything 'passed' to it
        public Card()
        {
            this.Rank = -1;
            this.Suit = -1;
            this.Facing = false;
        }

        // New CARD with 2 [INT] 'passed' to it
        public Card(int rnk, int sut)
        {           
            this.Rank = rnk;     
            this.Suit = sut;
            this.Facing = false;
            this.str_Rank = set_Rank_string(rnk);
            this.str_Suit = set_Suit_string(sut);
        }

        // Declare fields.
        int Rank; // Ace through King
        int Suit;
        bool Facing; // Whether the CARD itself is Known/Revealed
        string str_Rank; // String for the Rank "Ace, Deuce, etc."
        string str_Suit; // String for the Suit "Hearts, Diamonds, Clubs, etc."

        // GET the Rank
        public int get_Rank(){
            return this.Rank;
        }

        // GET the String representation assigned to the Rank
        public string get_Rank_str(){
            return this.str_Rank;
        }

        // GET the Suit
        public int get_Suit(){
            return this.Suit;
        }

        // GET the String representation assigned to the Suit
        public string get_Suit_str(){
            return this.str_Suit;
        }

        // GET whether the CARD is Known/Revealed
        public bool get_Facing(){
            return this.Facing;
        }

        // Negate the Current Facing - "Flip" the CARD
        public void set_Facing(){
            this.Facing = !this.Facing;
        }

        // Assign a String to a particular Suit
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

        // Assign a String to a particular Rank
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

    // Main Program
    class Program
    {
        // Entry Point
        static void Main(string[] args)
        {
            // Declare a new ArrayList, dynamically expanding to accept the Number of CARDs added to it: The "DECK"
            ArrayList deck = new ArrayList();
            ArrayList shuffled_deck = new ArrayList();

            // Nested For Loop to initialize a CARD object and Add it to the DECK
            for (int s = 25; s >= 14; s--)
            {
                for (int r = 1; r < 14; r++)
                {
                    // 1. Declare a New CARD
                    // 2. Add the Card to the DECK
                    // 3. Print a Debugging message to the console to 'test' each CARD
                    
                    Card tmpCard = new Card(r, s);
                    deck.Add(tmpCard);
                    System.Console.WriteLine(tmpCard.get_Rank_str() + " of " + tmpCard.get_Suit_str() + " facing " + tmpCard.get_Facing() + ".");
                }
            }

            // Debugging message written to the Conosole.
            System.Console.WriteLine("Deck Initialized.");

            // Draw a Random CARD.
            Program.DrawRandomCard(deck);

            // Debugging message written to the Conosole.
            System.Console.WriteLine("Card Drawn.");
        }

        public static void DrawRandomCard(ArrayList D)
        {
            //
            Random r = new Random(); // Declare a new RANDOM
            int pos_a = r.Next(D.Count); // Randomize the position the CARD is Drawn from
            Card tempCard = (Card)D[pos_a]; // Declare a new, 'Temporary' CARD and store it
            tempCard.set_Facing(); // Invoke Setter method, Used similarly as an Interface Method, to 'Flip' the CARD

            // Debugging output.
            System.Console.WriteLine(tempCard.get_Rank_str() + " of " + tempCard.get_Suit_str() + " facing " + tempCard.get_Facing() + ".");
        }
    }
}
// END
