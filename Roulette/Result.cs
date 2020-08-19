using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Result
    {
        private readonly string[] _evenOdd = { "Zero", "Odd", "Even" };
        private readonly string[] _highLow = { "Zero", "Low", "High" };
        private readonly string[] _dozens = { "0", "1", "2", "3" };
        private readonly string[] _columns = { "0", "1", "2", "3" };
        private string[] _result = new string[8];
        public string[] GetResult()
        {
            var player = new WheelData();
            var result = player.Spin();
            int parsedResult = int.Parse(result[0]);
            _result[0] = result[0];
            _result[1] = CheckEvenOdd(parsedResult);
            _result[2] = result[1];
            _result[3] = IsHighLow(parsedResult);
            _result[4] = CheckDozen(parsedResult);
            _result[5] = CheckColumn(parsedResult);
            _result[6] = CheckStreet(parsedResult);
            _result[7] = Check6Num(parsedResult);
            return _result;
        }
        public string IsHighLow(int result)
        {
            if (result == 0) return _highLow[0];
            else if (result < 19) return _highLow[1];
            else return _highLow[2];
        }
        public string CheckEvenOdd(int result)
        {
            if (result == 0) return _evenOdd[0];
            else if (result % 2 == 0) return _evenOdd[2];
            else return _evenOdd[1];
        }
        public string CheckDozen(int result)
        {
            if (result == 0) return _dozens[0];
            else if (result < 13) return _dozens[1];
            else if (result < 25) return _dozens[2];
            else return _dozens[3];
        }
        public string CheckColumn(int result)
        {
            if (result == 0) return _columns[0];
            else if (result % 3 == 1) return _columns[1];
            else if (result % 3 == 2) return _columns[2];
            else return _columns[3];
        }
        public string CheckStreet(int result)
        {
            if (result == 0) return "0";
            else if (result % 3 != 0) return $"{ result / 3 + 1 }";
            else return $"{ result / 3 }";
        }
        public string Check6Num(int result)
        {
            if (result == 0) return "0";
            else if (result % 6 != 0) return $"{ result / 6 + 1 }";
            else return $"{ result / 6 }";
        }
    }
}
