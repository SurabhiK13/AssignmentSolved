using System;
namespace Assignment9_2D_Array_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int numStudents = int.Parse(Console.ReadLine());
            const int numSubjects = 5;
            int[,] stdMarks = new int[numStudents, numSubjects];

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Enter marks for Student {i + 1}:");
                for (int j = 0; j < numSubjects; j++)
                {
                    stdMarks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] ranks = FindStudentsRank(stdMarks);
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Rank of Student {i + 1} is {ranks[i]}");
            }
        }

        public static int[] FindStudentsRank(int[,] stdMarks)
        {
            int numStudents = stdMarks.GetLength(0);
            int[] totalMarks = new int[numStudents];
            int[] ranks = new int[numStudents];

            for (int i = 0; i < numStudents; i++)
            {
                for (int j = 0; j < stdMarks.GetLength(1); j++)
                {
                    totalMarks[i] += stdMarks[i, j];
                }
            }

            for (int i = 0; i < numStudents; i++)
            {
                ranks[i] = 1; 
                for (int j = 0; j < numStudents; j++)
                {
                    if (totalMarks[i] < totalMarks[j])
                    {
                        ranks[i]++; 
                    }
                }
            }
            return ranks; 
        }
    }

}
