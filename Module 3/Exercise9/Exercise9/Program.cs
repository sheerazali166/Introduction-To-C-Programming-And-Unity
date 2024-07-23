using System;

namespace Exercise9
{
    /// <summary>
    /// Exercise 9 solution
    /// </summary>

    class MainClass
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>

        public static void Main(string[] args)
        {

            // create a new deck and tell the deck to print itself
            Deck deck = new Deck();
            deck.Print();
            Console.WriteLine();


            // tell the deck to shuffle and print itself
            deck.Shuffle();
            deck.Print();
            Console.WriteLine();

            // take the top card from the deck and print the card rank and suit
            Card cardZOne0One = deck.TakeTopCard();
            Console.WriteLine("First Card: " + cardZOne0One.Rank + " of " + cardZOne0One.Suit);


            // take the top card from the deck and print the card rank and suit
            Card cardTwo = deck.TakeTopCard();
            Console.WriteLine("Second Card: " + cardTwo.Rank + " of " + cardTwo.Suit);

        }
    }
}
