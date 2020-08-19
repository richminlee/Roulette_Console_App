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
            foreach(var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}