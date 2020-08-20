using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Bet
    {
        public int GetBetCategory()
        {
            Console.WriteLine("Select a Number to select a bet type");
            Console.WriteLine("1. Numbers");
            Console.WriteLine("2. Evens/Odds");
            Console.WriteLine("3. Reds/Blacks");
            Console.WriteLine("4. Lows/Highs");
            Console.WriteLine("5. Dozens");
            Console.WriteLine("6. Columns");
            Console.WriteLine("7. Street");
            Console.WriteLine("8. Double Row");
            Console.WriteLine("9. Split");
            Console.WriteLine("10. Corner");
            int result = int.Parse(Console.ReadLine());
            if (result < 1 || result > 10)
            {
                Console.WriteLine("Your number is not a valid choice.");
                return GetBetCategory();
            }
            return result;  
        }
        public int GetNumberBet()
        {
            Console.WriteLine("Select a Number");
            Console.WriteLine("0: 0      1: 1     2: 2     3: 3     4: 4     5: 5     6: 6     7: 7     8: 8     9: 9");
            Console.WriteLine("10: 10    11: 11   12: 12   13: 13   14: 14   15: 15   16: 16   17: 17   18: 18   19: 19");
            Console.WriteLine("20: 20    21: 21   22: 22   23: 23   24: 24   25: 25   26: 26   27: 27   28: 28   29: 29");
            Console.WriteLine("30: 30    31: 31   32: 32   33: 33   34: 34   35: 35   36: 36   37: 00");
            int betResult = int.Parse(Console.ReadLine());
            if(betResult < 0 || betResult > 37)
            {
                Console.WriteLine("Your number is not a valid choice.");
                return GetNumberBet();
            }
            return betResult;
        }
        public string GetEvenOddBet()
        {
            Console.WriteLine("Type Even or Odd!");
            string betResult = Console.ReadLine();
            betResult = betResult.ToLower();
            Console.WriteLine(betResult);
            if(betResult != "even" && betResult != "odd")
            {
                Console.WriteLine("Your input is not a valid choice.");
                return GetEvenOddBet();
            }
            return betResult;
        }
        public string GetRedBlackBet()
        {
            Console.WriteLine("Select Red or Black!");
            string betResult = Console.ReadLine();
            betResult = betResult.ToLower();
            if (betResult != "red" && betResult != "black")
            {
                Console.WriteLine("Your input is not a valid choice.");
                return GetRedBlackBet();
            }
            return betResult;
        }
        public string GetHighLowBet()
        {
            Console.WriteLine("Select High or Low!");
            string betResult = Console.ReadLine();
            betResult = betResult.ToLower();
            if (betResult != "high" && betResult != "low")
            {
                Console.WriteLine("Your input is not a valid choice.");
                return GetHighLowBet();
            }
            return betResult;
        }
        public int GetDozenBet()
        {
            Console.WriteLine("Select a Dozens!");
            Console.WriteLine("1: 1-12      2: 13-24        3: 25-36");
            int betResult = int.Parse(Console.ReadLine());
            if(betResult < 1 || betResult > 3)
            {
                Console.WriteLine("Your input is not a valid choice.");
                return GetDozenBet();
            }
            return betResult;
        }
        public int GetColumnBet()
        {
            Console.WriteLine("Select a Column!");
            Console.WriteLine("1: 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34");
            Console.WriteLine("2: 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35");
            Console.WriteLine("3: 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36");
            int betResult = int.Parse(Console.ReadLine());
            if(betResult < 1 || betResult > 3)
            {
                Console.WriteLine("Your input is not a valid choice.");
                return GetColumnBet();
            }
            return betResult;
        }
        public int GetStreetBet()
        {
            Console.WriteLine("Select a Street!");
            Console.WriteLine("1: 1, 2, 3");
            Console.WriteLine("2: 4, 5, 6");
            Console.WriteLine("3: 7, 8, 9");
            Console.WriteLine("4: 10, 11, 12");
            Console.WriteLine("5: 13, 14, 15");
            Console.WriteLine("6: 16, 17, 18");
            Console.WriteLine("7: 19, 20, 21");
            Console.WriteLine("8: 22, 23, 24");
            Console.WriteLine("9: 25, 26, 27");
            Console.WriteLine("10: 28, 29, 30");
            Console.WriteLine("11: 31, 32, 33");
            Console.WriteLine("12: 34, 35, 36");
            int betResult = int.Parse(Console.ReadLine());
            if(betResult < 1 || betResult > 12)
            {
                Console.WriteLine("Your input is not a valid choice.");
                return GetStreetBet();
            }
            return betResult;
        }
        public int GetDoubleBet()
        {
            Console.WriteLine("Select a Double Row!");
            Console.WriteLine("1: 1, 2, 3, 4, 5, 6");
            Console.WriteLine("2: 7, 8, 9, 10, 11, 12");
            Console.WriteLine("3: 13, 14, 15, 16, 17, 18");
            Console.WriteLine("4: 19, 20, 21, 22, 23, 24");
            Console.WriteLine("5: 25, 26, 27, 28, 29, 30");
            Console.WriteLine("6: 31, 32, 33, 34, 35, 36");
            int betResult = int.Parse(Console.ReadLine());
            if(betResult < 1 || betResult > 6)
            {
                Console.WriteLine("Your input is not a valid choice.");
                return GetDoubleBet();
            }
            return betResult;
        }
        public int[] GetSplitBet()
        {
            Console.WriteLine("Select a Split by submitting each number!");
            Console.WriteLine("1 |2 | 3");
            Console.WriteLine("--------");
            Console.WriteLine("4 |5 | 6");
            Console.WriteLine("--------");
            Console.WriteLine("7 |8 | 9");
            Console.WriteLine("--------");
            Console.WriteLine("10|11|12");
            Console.WriteLine("--------");
            Console.WriteLine("13|14|15");
            Console.WriteLine("--------");
            Console.WriteLine("16|17|18");
            Console.WriteLine("--------");
            Console.WriteLine("19|20|21");
            Console.WriteLine("--------");
            Console.WriteLine("22|23|24");
            Console.WriteLine("--------");
            Console.WriteLine("25|26|27");
            Console.WriteLine("--------");
            Console.WriteLine("28|29|30");
            Console.WriteLine("--------");
            Console.WriteLine("31|32|33");
            Console.WriteLine("--------");
            Console.WriteLine("34|35|36");
            Console.WriteLine("Please enter the First number.");
            int betResult1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Second number.");
            int betResult2 = int.Parse(Console.ReadLine());
            if (betResult1 == 0)
            {
                Console.WriteLine("Cannot Split with 0 or 00. Please try again.");
                return GetSplitBet();
            }
            else if (betResult1 % 3 != 0)
            {
                if (betResult2 == (betResult1 + 1) || betResult2 == (betResult1 + 3) || betResult2 == (betResult1 - 1) || betResult2 == (betResult1 - 3))
                {
                    return new int[] { betResult1, betResult2 };
                }
                else
                {
                    Console.WriteLine("You cannot split those 2 numbers. Please try again");
                    return GetSplitBet();
                }

            }
            else
            {
                if (betResult2 == (betResult1 + 3) || betResult2 == (betResult1 - 3))
                {
                    return new int[] { betResult1, betResult2 };
                }
                else
                {
                    Console.WriteLine("You cannot split those 2 numbers. Please try again");
                    return GetSplitBet();
                }
            }
        }
        public int[] GetCorner()
        {
            Console.WriteLine("Select a Corner!");
            int[] result = new int[4];
            int[,] cornerMatrix = new int[22,4]
            {
                { 1, 2, 4, 5 },
                { 2, 3, 5, 6 },
                { 4, 5, 7, 8 },
                { 5, 6, 8, 9 },
                { 7, 8, 10, 11},
                { 8, 9, 11, 12},
                { 10, 11, 13, 14},
                { 11, 12, 14, 15},
                { 13, 14, 16 ,17},
                { 14, 15, 17, 18},
                { 16, 17, 19, 20},
                { 17, 18, 20, 21},
                { 19, 20, 22, 23},
                { 20, 21, 23, 24},
                { 22, 23, 25, 26},
                { 23, 24, 26, 27},
                { 25, 26, 28, 29},
                { 26, 27, 29, 30},
                { 28, 29, 31, 32},
                { 29, 30, 32, 33},
                { 31, 32, 34, 35},
                { 32, 33, 35, 36}
            };
            for(int i = 0; i < 22; i++)
            {
                Console.Write($"{i}: ");
                for(int j = 0; j < 4; j++)
                {
                    Console.Write($"{cornerMatrix[i,j]}, ");
                }
                    Console.WriteLine();
            }
            int betResult = int.Parse(Console.ReadLine());
            if(betResult < 0 || betResult > 21)
            {
                Console.WriteLine("Your input is not a valid choice.");
                return GetCorner();
            }
            for(int i = 0; i < result.Length; i++) result[i] = cornerMatrix[betResult, i];
            return result;
        }
        public string PlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            string playAgain = Console.ReadLine();
            playAgain = playAgain.ToLower();
            if (playAgain != "y" && playAgain != "n" && playAgain != "yes" && playAgain != "no")
            {
                Console.WriteLine("Please enter a valid response of Yes(Y) or No(N)");
                return PlayAgain();
            }
                return playAgain;
        }
    }
}