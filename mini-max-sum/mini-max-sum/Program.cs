using System;
using System.Collections.Generic;
using System.Linq;

namespace mini_max_sum
{
    internal class Program
    {
        public static void miniMaxSum(List<int> numbers)
        {
            long total = 0;
            long[] numbersTemp = new long[numbers.Count];

            for (int indice = 0; indice < numbers.Count; indice++)
            {
                total = numbers.Sum(x => (long)x) - numbers[indice];
                numbersTemp[indice] = total;
            }

            long minimumTotal = numbersTemp.Min();
            long maximumTotal = numbersTemp.Max();

            Console.WriteLine($"{minimumTotal} {maximumTotal}");
        }

        static void Main(string[] args)
        {
            string result = Console.ReadLine().TrimEnd();
            List<string> resultList = result.Split(' ').ToList();
            List<int> numbers = resultList.Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            /*Realized tests:
             * Input: 1 2 3 4 5         Ouput: 10 14
             * Input: 7 69 2 221 8974   Ouput: 299 9271
             */

            miniMaxSum(numbers);
        }
    }
}
