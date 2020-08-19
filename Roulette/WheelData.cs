using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class WheelData
    {
        private readonly string[] _numbers = 
        {
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", 
            "10", "11", "12", "13", "14", "15", "16", "17", "18", 
            "19", "20", "21", "22", "23", "24", "25", "26", "27", 
            "28", "29", "30", "31", "32", "33", "34", "35", "36", "00"
        };
        private readonly string[] _color = 
        { 
            "green", "red", "black", "red", "black", "red", "black", "red", "black", "red", 
            "black", "black", "red", "black", "red", "black", "red", "black", "red", 
            "red", "black", "red", "black", "red", "black", "red", "black", "red", 
            "black", "black", "red", "black", "red", "black", "red", "black", "red", "green",
        };
        public string[] Spin()
        {
            Random random = new Random();
            int winningIndex = random.Next(0, 38);
            string[] result = { _numbers[winningIndex], _color[winningIndex] };
            return result;
        }
    }
}
