using System;
using System.Collections.Generic;

namespace grading_student
{
    internal class Program
    {
        public static List<int> gradingStudents(List<int> grades)
        {

            for (int index = 0; index < grades.Count; index++)
            {
                var grade = grades[index];
                int next = ((grade / 5) + 1) * 5;

                if (next - grade >= 3 || grade < 38)
                    grades[index] = grade;
                else
                    grades[index] = next;
            }

            return grades;
            }

        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            //grades.Add(4);
            //grades.Add(73);
            //grades.Add(67);
            //grades.Add(38);
            //grades.Add(33);

            List<int> result = gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));
        }
    }
}
