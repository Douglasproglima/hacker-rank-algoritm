using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace birthday_cake_candles
{
    internal class Program
    {
        private const string path = "C:\\Users\\dougl\\Desktop";

        public static int birthdayCakeCandles(List<int> candles)
        {
            int result = 0;

            if (candles != null)
            {
                candles = candles.OrderByDescending(x => x).ToList();
                result = candles.Where(x => x == candles.FirstOrDefault()).Count();
            }

            return result;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable(path), true);

            //int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            //string result = Console.ReadLine().TrimEnd();
            //List<string> resultList = result.Split(' ').ToList();

            List<int> candles = new List<int>();//resultList.Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            candles.Add(4);
            candles.Add(4);
            candles.Add(1);
            candles.Add(3);

            int birthday = birthdayCakeCandles(candles);

            Console.WriteLine(birthday);

            //textWriter.WriteLine(birthday);
            //
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
