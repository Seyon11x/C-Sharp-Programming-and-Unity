using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("----------------------------Welcome to the Casino--------------------------");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card firstCardForPlayer1 = deck.TakeTopCard();
            Card firstCardForPlayer2 = deck.TakeTopCard();
            Card firstCardForPlayer3 = deck.TakeTopCard();

            Card secondCardForPlayer1 = deck.TakeTopCard();
            Card secondCardForPlayer2 = deck.TakeTopCard();
            Card secondCardForPlayer3 = deck.TakeTopCard();

            // flip all the cards over
            firstCardForPlayer1.FlipOver();
            firstCardForPlayer2.FlipOver();
            firstCardForPlayer3.FlipOver();

            secondCardForPlayer1.FlipOver();
            secondCardForPlayer2.FlipOver();
            secondCardForPlayer3.FlipOver();

            // print the cards for player 1
            Console.WriteLine("Player 1 Cards:");
            Console.WriteLine(firstCardForPlayer1.Rank + " of " + firstCardForPlayer1.Suit);
            Console.WriteLine(secondCardForPlayer1.Rank + " of " + secondCardForPlayer1.Suit);

            // print the cards for player 2
            Console.WriteLine("Player 2 Cards:");
            Console.WriteLine(firstCardForPlayer2.Rank + " of " + firstCardForPlayer2.Suit);
            Console.WriteLine(secondCardForPlayer2.Rank + " of " + secondCardForPlayer2.Suit);

            // print the cards for player 3
            Console.WriteLine("Player 3 Cards:");
            Console.WriteLine(firstCardForPlayer3.Rank + " of " + firstCardForPlayer3.Suit);
            Console.WriteLine(secondCardForPlayer3.Rank + " of " + secondCardForPlayer3.Suit);

            Console.WriteLine();
        }
    }
}
