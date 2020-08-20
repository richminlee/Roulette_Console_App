using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Play
    {
        public static void PlayRoulette(int bankRoll)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                   88                                      ");
            Console.WriteLine("                                   88              ,d      ,d              ");
            Console.WriteLine("                                   88              88      88              ");
            Console.WriteLine("8b,dPPYba,  ,adPPYba,  88       88 88  ,adPPYba, MM88MMM MM88MMM, adPPYba, ");
            Console.WriteLine("88P\'   \"Y8 a8P     Y8a 88       88 88 a8P_____88   88      88   a8P_____88 "); 
            Console.WriteLine("88         8b       88 88       88 88 8PP          88      88   8PP       ");
            Console.WriteLine("88         \"8a,   ,a8\" \"8a,   ,a88 88 \"8b,   ,aa   88,     88,  \"8b,   ,aa "); 
            Console.WriteLine("88          `\"YbbdP\"\'   `\"YbbdP\'Y8 88  `\"Ybbd8\"\'   \"Y888   \"Y888 `\"Ybbd8\"\' ");
            Console.WriteLine();
            Console.WriteLine();
            var player = new Result();
            var result = player.GetResult();
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}
            var bet = new Bet();
            int betCategoryResult = bet.GetBetCategory();
            Console.WriteLine("Please Enter a Bet Amount!");
            int betAmount = int.Parse(Console.ReadLine());
            if (betAmount > bankRoll)
            {
                Console.WriteLine($"You do not have enough money! You have {bankRoll}");
                PlayRoulette(bankRoll);
            }
            if (betCategoryResult == 1)
            {
                if (int.Parse(player._result[0]) == bet.GetNumberBet())
                {
                    bankRoll += betAmount * 35;
                    Console.WriteLine($"You Won!!! You have ${bankRoll}");
                }
                else
                {
                    bankRoll -= betAmount;
                    Console.WriteLine($"You Lost! You have ${bankRoll}");
                }
            }
            if (betCategoryResult == 2)
            {
                if (player._result[1] == bet.GetEvenOddBet())
                {
                    bankRoll += betAmount;
                    Console.WriteLine($"You Won!!! You have ${bankRoll}");
                }
                else
                {
                    bankRoll -= betAmount;
                    Console.WriteLine($"You Lost! You have ${bankRoll}");
                }
            }
            if (betCategoryResult == 3)
            {
                if (player._result[2] == bet.GetRedBlackBet())
                {
                    bankRoll += betAmount;
                    Console.WriteLine($"You Won!!! You have ${bankRoll}");
                }
                else
                {
                    bankRoll -= betAmount;
                    Console.WriteLine($"You Lost! You have ${bankRoll}");
                }
            }
            if (betCategoryResult == 4)
            {
                if (player._result[3] == bet.GetHighLowBet())
                {
                    bankRoll += betAmount;
                    Console.WriteLine($"You Won!!! You have ${bankRoll}");
                }
                else
                {
                    bankRoll -= betAmount;
                    Console.WriteLine($"You Lost! You have ${bankRoll}");
                }
            }
            if (betCategoryResult == 5)
            {
                if (int.Parse(player._result[4]) == bet.GetDozenBet())
                {
                    bankRoll += betAmount * 2;
                    Console.WriteLine($"You Won!!! You have ${bankRoll}");
                }
                else
                {
                    bankRoll -= betAmount;
                    Console.WriteLine($"You Lost! You have ${bankRoll}");
                }
            }
            if (betCategoryResult == 6)
            {
                if (int.Parse(player._result[5]) == bet.GetColumnBet())
                {
                    bankRoll += betAmount * 2;
                    Console.WriteLine($"You Won!!! You have ${bankRoll}");
                }
                else
                {
                    bankRoll -= betAmount;
                    Console.WriteLine($"You Lost! You have ${bankRoll}");
                }
            }
            if (betCategoryResult == 7)
            {
                if (int.Parse(player._result[6]) == bet.GetStreetBet())
                {
                    bankRoll += betAmount * 11;
                    Console.WriteLine($"You Won!!! You have ${bankRoll}");
                }
                else
                {
                    bankRoll -= betAmount;
                    Console.WriteLine($"You Lost! You have ${bankRoll}");
                }
            }
            if (betCategoryResult == 8)
            {
                if (int.Parse(player._result[7]) == bet.GetDoubleBet())
                {
                    bankRoll += betAmount * 5;
                    Console.WriteLine($"You Won!!! You have ${bankRoll}");
                }
                else
                {
                    bankRoll -= betAmount;
                    Console.WriteLine($"You Lost! You have ${bankRoll}");
                }
            }
            if (betCategoryResult == 9)
            {
                int[] betResult = bet.GetSplitBet();
                if (int.Parse(player._result[0]) == betResult[0] || int.Parse(player._result[0]) == betResult[1])
                {
                    bankRoll += betAmount * 17;
                    Console.WriteLine($"You Won!!! You have ${bankRoll}");
                }
                else
                {
                    bankRoll -= betAmount;
                    Console.WriteLine($"You Lost! You have ${bankRoll}");
                }
            }
            if (betCategoryResult == 10)
            {
                int[] betResult = bet.GetCorner();
                if (int.Parse(player._result[0]) == betResult[0] ||
                    int.Parse(player._result[0]) == betResult[1] ||
                    int.Parse(player._result[0]) == betResult[2] ||
                    int.Parse(player._result[0]) == betResult[3])
                {
                    bankRoll += betAmount * 8;
                    Console.WriteLine($"You Won!!! You have ${bankRoll}");
                }
                else
                {
                    bankRoll -= betAmount;
                    Console.WriteLine($"You Lost! You have ${bankRoll}");
                }
            }
            if(bankRoll == 0)
            {
                Console.WriteLine("You have no more money. Thank you for playing!");
                return;
            }
            string playAgain = bet.PlayAgain();
            if (playAgain == "y" || playAgain == "yes")
            {
                PlayRoulette(bankRoll);
            }
            else
            {
                Console.WriteLine("Thank you for playing! Press any key to exit!");
            }
        }
    }
}
