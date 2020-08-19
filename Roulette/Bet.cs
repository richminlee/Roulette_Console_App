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
            return betResult;
        }
        public string GetEvenOddBet()
        {
            Console.WriteLine("Select Even or Odds!");
            string betResult = Console.ReadLine().ToLower();
            return betResult;
        }        
        public string GetRedBlackBet()
        {
            Console.WriteLine("Select Red or Black!");
            string betResult = Console.ReadLine().ToLower();
            return betResult;
        }
        public string GetHighLowBet()
        {
            Console.WriteLine("Select High or Low!");
            string betResult = Console.ReadLine().ToLower();
            return betResult;
        }        
        public int GetDozenBet()
        {
            Console.WriteLine("Select a Dozens!");
            Console.WriteLine("1: 1-12      2: 13-24        3: 25-36");
            int betResult = int.Parse(Console.ReadLine());
            return betResult;
        }        
        public int GetColumnBet()
        {
            Console.WriteLine("Select a Column!");
            Console.WriteLine("1: 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34");
            Console.WriteLine("2: 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35");
            Console.WriteLine("3: 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36");
            int betResult = int.Parse(Console.ReadLine());
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
            return betResult;
        }
    }
}
