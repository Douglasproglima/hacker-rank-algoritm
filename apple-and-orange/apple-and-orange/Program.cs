using System;
using System.Collections.Generic;
using System.Linq;

namespace apple_and_orange
{
    internal class Program
    {
        /*
         * Complete the 'countApplesAndOranges' function below.
         *
         * The function accepts following parameters:
         *  1. INTEGER s
         *  2. INTEGER t
         *  3. INTEGER a
         *  4. INTEGER b
         *  5. INTEGER_ARRAY apples
         *  6. INTEGER_ARRAY oranges
         */

        public static void countApplesAndOranges(int startPoint, int endLocation, int locationAppleTree, int locationOrangeTree, List<int> apples, List<int> oranges)
        {
            int appleCounter = 0, 
                orangeCounter = 0, 
                locationAppleTreeSumApple, 
                locationAppleTreeSumOrange;
            
            foreach (var apple in apples)
            {
                locationAppleTreeSumApple = locationAppleTree + apple;
                if (locationAppleTreeSumApple >= startPoint && locationAppleTreeSumApple <= endLocation)
                    appleCounter++;
            }
            Console.WriteLine(appleCounter);

            foreach (var orange in oranges)
            {
                locationAppleTreeSumOrange = locationOrangeTree + orange;
                if (locationAppleTreeSumOrange >= startPoint && locationAppleTreeSumOrange <= endLocation)
                    orangeCounter++;
            }
            Console.WriteLine(orangeCounter);
        }

        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int startPoint = Convert.ToInt32(firstMultipleInput[0]);

            int endLocation = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            countApplesAndOranges(startPoint, endLocation, a, b, apples, oranges);
        }
    }
}
