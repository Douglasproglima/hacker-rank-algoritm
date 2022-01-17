using System;
using System.Collections.Generic;
using System.IO;

namespace time_conversion
{
    internal class Program
    {
        private const string PM = "PM";

        public static string timeConversion(string param_second)
        {
            int hour; 
            string timeResult = string.Empty, 
                   minute = string.Empty, 
                   second = string.Empty,
                   getTypeToTime = string.Empty;

            string[] elementTime = param_second.Split(':');
            hour = int.Parse(elementTime[0]);
            minute = elementTime[1];
            second = elementTime[2].Substring(0, 2);
            getTypeToTime = elementTime[2].Substring(2,2);

            if (getTypeToTime == PM)
            {
                if(hour != 12) hour += 12;
                string s = hour.ToString();

                if (s.Length == 1) s = s.PadLeft(hour, '0');

                timeResult = s + ':' + minute + ':' + second;
            }
            else
            {
                if (hour == 12) hour = 0;
                string s = hour.ToString();

                if (s.Length == 1) s = s.PadRight(hour, '0');

                timeResult = '0'+s + ':' + minute + ':' + second;
            }

            return timeResult;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string second = Console.ReadLine();

            //string second = "12:01:00PM"; // Return 12:01:00.
            string second = "12:01:00AM"; //00:01:00

            string result = timeConversion(second);

            Console.WriteLine("Resultado: " + result);

            //textWriter.WriteLine(result);
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
