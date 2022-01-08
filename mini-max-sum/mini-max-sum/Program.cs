using System;
using System.Collections.Generic;
using System.Linq;

namespace mini_max_sum
{
    internal class Program
    {
        public static void miniMaxSum(List<int> _numbers)
        {
            /*
             
             long sum = 0;
             long[] chk = new long[arr.Count]; 
            
             for (int i = 0; i < arr.Count ; i++) 
            { 
                sum = arr.Sum(x => (long)x) - arr[i]; 
                chk[i] = sum;
            }

            Console.WriteLine(chk.Min() + " " + chk.Max());
             */

            List<long> numbers = new List<long>();

            foreach (int number in _numbers)
                numbers.Add(Convert.ToInt64(number));

            numbers.Sort();

            long minimumNumber = 0; 
            minimumNumber = numbers.Min();

            long maximumNumber = 0; 
            maximumNumber = numbers.Max();

            List<long> maximumNumberTemp = new List<long>(numbers);
            maximumNumberTemp.Remove(minimumNumber);

            long maximumTotal = maximumNumberTemp.Sum();

            List<long> minimumNumberTemp = new List<long>(numbers);
            minimumNumberTemp.Remove(maximumNumber);

            long minimumTotal = minimumNumberTemp.Sum();

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
