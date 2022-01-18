using System;
using System.Collections.Generic;
using System.IO;

namespace time_conversion
{
    internal class Program
    {
        public static string timeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }

        static void Main(string[] args)
        {
            /*
             * Complete the 'timeConversion' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts STRING s as parameter.
             */

            string second = Console.ReadLine();

            Console.WriteLine(timeConversion(second));
        }
    }
}
