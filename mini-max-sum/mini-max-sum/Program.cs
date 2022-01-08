using System;
using System.Collections.Generic;
using System.Linq;

namespace mini_max_sum
{
    internal class Program
    {
        public static void miniMaxSum(List<int> numbers)
        {
            int minimumNumber = 0; 
            minimumNumber = numbers.Min();

            int maximumNumber = 0; 
            maximumNumber = numbers.Max();

            List<int> maximumNumberTemp = new List<int>(numbers);
            maximumNumberTemp.Remove(minimumNumber);

            int maximumTotal = maximumNumberTemp.Sum();

            List<int> minimumNumberTemp = new List<int>(numbers);
            minimumNumberTemp.Remove(maximumNumber);

            int minimumTotal = minimumNumberTemp.Sum();

            Console.WriteLine(minimumTotal + " " + maximumTotal);
        }

        static void Main(string[] args)
        {
            string result = Console.ReadLine().TrimEnd();
            List<string> resultList = result.Split(' ').ToList();
            List<int> numbers = resultList.Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            miniMaxSum(numbers);
        }
    }
}
