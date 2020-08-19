using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Result
    {
        public string[] _result = new string[8];
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
            _result[7] = CheckDoubleRow(parsedResult);
            return _result;
        }
        public string IsHighLow(int result)
        {
            if (result == 0) return "zero";
            else if (result < 19) return "low";
            else return "high";
        }
        public string CheckEvenOdd(int result)
        {
            if (result == 0) return "zero";
            else if (result % 2 == 0) return "even";
            else return "odd";
        }
        public string CheckDozen(int result)
        {
            if (result == 0) return "0";
            else if (result < 13) return "1";
            else if (result < 25) return "2";
            else return "3";
        }
        public string CheckColumn(int result)
        {
            if (result == 0) return "0";
            else if (result % 3 == 1) return "1";
            else if (result % 3 == 2) return "2";
            else return "3";
        }
        public string CheckStreet(int result)
        {
            if (result == 0) return "0";
            else if (result % 3 != 0) return $"{ result / 3 + 1 }";
            else return $"{ result / 3 }";
        }
        public string CheckDoubleRow(int result)
        {
            if (result == 0) return "0";
            else if (result % 6 != 0) return $"{ result / 6 + 1 }";
            else return $"{ result / 6 }";
        }
    }
}
