using System;
using System.Threading;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Result();
            var result = player.GetResult();
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
            var bet = new Bet();
            int betCategoryResult = bet.GetBetCategory();
            if (betCategoryResult == 1)
            {
                if (int.Parse(player._result[0]) == bet.GetNumberBet()) Console.WriteLine("You Won!!!");
                else Console.WriteLine("You Lost!");
            }
            if (betCategoryResult == 2)
            {
                if (player._result[1] == bet.GetEvenOddBet()) Console.WriteLine("You Won!!!");
                else Console.WriteLine("You Lost!");
            }            
            if (betCategoryResult == 3)
            {
                if (player._result[2] == bet.GetRedBlackBet()) Console.WriteLine("You Won!!!");
                else Console.WriteLine("You Lost!");
            }            
            if (betCategoryResult == 4)
            {
                if (player._result[3] == bet.GetHighLowBet()) Console.WriteLine("You Won!!!");
                else Console.WriteLine("You Lost!");
            }            
            if (betCategoryResult == 5)
            {
                if (int.Parse(player._result[4]) == bet.GetDozenBet()) Console.WriteLine("You Won!!!");
                else Console.WriteLine("You Lost!");
            }            
            if (betCategoryResult == 6)
            {
                if (int.Parse(player._result[5]) == bet.GetColumnBet()) Console.WriteLine("You Won!!!");
                else Console.WriteLine("You Lost!");
            }
            if (betCategoryResult == 7)
            {
                if (int.Parse(player._result[6]) == bet.GetStreetBet()) Console.WriteLine("You Won!!!");
                else Console.WriteLine("You Lost!");
            }
            if (betCategoryResult == 8)
            {
                if (int.Parse(player._result[7]) == bet.GetDoubleBet()) Console.WriteLine("You Won!!!");
                else Console.WriteLine("You Lost!");
            }
        }
    }
}