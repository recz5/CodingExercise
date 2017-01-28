using PlayingCards;
using System;
using System.Linq;

namespace PlayingCardsApplication
{
    class Program
    {
        private static Dealer dealer;

        static void Main(string[] args)
        {
            Start();

            string input = Console.ReadLine();

            while (input != "/exit")
            {
                if (input == "/shuffle" || args.Contains("/shuffle"))
                {
                    Shuffle();
                }
                else if (input == "/sort" || args.Contains("/sort"))
                {
                    Sort();
                }
                else if (input == "/show" || args.Contains("/show"))
                {
                    Show();
                }
                else if (input == "/help" || args.Contains("/help"))
                {
                    Commands();
                }
                else
                {
                    Console.WriteLine("Unrecognized command! Enter /help to see avaible commands..");
                }

                input = Console.ReadLine();
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }

        /// <summary>
        /// Instantiate objects
        /// </summary>
        private static void Start()
        {
            Console.WriteLine("Initializing onjects....");
            dealer = new Dealer(new StandardDeck());
            Console.WriteLine("Initialization Complete....");
            Commands();
        }

        /// <summary>
        /// Display current deck
        /// </summary>
        private static void Show()
        {
            Console.WriteLine("-- Showing Current Deck --");

            foreach (Card card in dealer.DeckOfCards.Values)
            {
                Console.WriteLine("{0}\r", card.CardName);
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
            Console.WriteLine("Valid Commands:");
            Console.WriteLine("/show - Displays current deck");
            Console.WriteLine("/shuffle - Randomly shuffles current deck");
            Console.WriteLine("/sort - Sorts current deck in ascending order");
            Console.WriteLine("/exit - Exits application");
            Console.WriteLine("/help - Displays available commands");
        }
    }
}
