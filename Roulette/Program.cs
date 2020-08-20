using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Richard's Roulette!");
            Console.WriteLine("You will be starting off with $500!!!");
            Console.WriteLine("All bets must be in dollar increments.");
            Console.WriteLine("Table minimum is $1.");
            int bankRoll = 500;
            Play.PlayRoulette(bankRoll);
        }
    }
}