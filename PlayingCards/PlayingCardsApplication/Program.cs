using PlayingCards;
using System;
using System.Linq;

namespace PlayingCardsApplication
{
    /// <summary>
    /// A simple application that represents a dealer with a deck of cards.
    /// The dealer can shuffle and sort a standard deck of 52 playing cards.
    /// </summary>
    class Program
    {
        private static Dealer dealer;

        static void Main(string[] args)
        {
            Start();

            Console.WriteLine("Enter new command.");
            string input = Console.ReadLine();

            while (input != "/exit")
            {
                switch (input)
                {
                    case "/shuffle":
                        Shuffle();
                        break;
                    case "/sort":
                        Sort();
                        break;
                    case "/show":
                        Show();
                        break;
                    case "/help":
                        Commands();
                        break;
                    default:
                        Console.WriteLine("Unrecognized command! Enter /help to see avaible commands..");
                        break;
                }

                Console.WriteLine("Enter new command.");
                input = Console.ReadLine();
            }
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// Instantiate objects
        /// </summary>
        private static void Start()
        {
            Commands();
            Console.WriteLine("Initializing onjects....");
            dealer = new Dealer(new StandardDeck());
            Console.WriteLine("Initialization Complete....");
            
        }

        /// <summary>
        /// Display current deck
        /// </summary>
        private static void Show()
        {
            Console.WriteLine("Showing Current Deck...");

            foreach (Card card in dealer.DeckOfCards.Values)
            {
                Console.WriteLine(" {0}\r", card.CardName);
            }
        }

        /// <summary>
        /// Shuffle current deck
        /// </summary>
        private static void Shuffle()
        {
            Console.WriteLine("Shuffling...");

            dealer.Shuffle();

            Console.WriteLine("Shuffling Complete...");
        }

        /// <summary>
        /// Sort current deck in ascending order
        /// </summary>
        private static void Sort()
        {
            Console.WriteLine("Sorting in ascending order...");

            dealer.Sort();

            Console.WriteLine("Sorting Complete...");
        }

        /// <summary>
        /// Displays commands for users
        /// </summary>
        private static void Commands()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("              Valid Commands:                        ");
            Console.WriteLine("                                                     ");
            Console.WriteLine("  /show    - Displays current deck                   ");
            Console.WriteLine("  /shuffle - Randomly shuffles current deck          ");
            Console.WriteLine("  /sort    - Sorts current deck in ascending order   ");
            Console.WriteLine("  /exit    - Exits application                       ");
            Console.WriteLine("  /help    - Displays available commands             ");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
