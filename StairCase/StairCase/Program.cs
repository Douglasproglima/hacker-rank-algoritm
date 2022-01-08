using System;
using System.Text;

namespace StairCase
{
    internal class Program
    {
        public static void staircase(int size)
        {
            int level = size - 1;
            for (int indiceA = 1; indiceA <= size; indiceA++)
            {
                StringBuilder str = new StringBuilder();

                for (int indiceB = 0; indiceB < level; indiceB++)
                {
                    str.Append(" ");
                }

                for (int indiceB = 0; indiceB < size - level; indiceB++)
                {
                    str.Append("#");
                }

                level -= 1;
                Console.WriteLine(str.ToString());
            }
        }

        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine().Trim());

            staircase(size);
        }
    }
}
