using System;
namespace Assignment10_JaggedArray_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int studentCount = int.Parse(Console.ReadLine());
            int[][] points = new int[studentCount][];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Enter the number of competitions attended by student {i + 1}:");
                int competitionsCount = int.Parse(Console.ReadLine());
                points[i] = new int[competitionsCount];
                Console.WriteLine($"Enter the points for student {i + 1}:");
                for (int j = 0; j < competitionsCount; j++)
                {
                    points[i][j] = int.Parse(Console.ReadLine());
                }
            }
            string result = FindWhoGotMaximumPoints(points);
            Console.WriteLine(result);
        }

        public static string FindWhoGotMaximumPoints(int[][] points)
        {
            int maxPoints = 0;
            int studentIndex = -1;

            for (int i = 0; i < points.Length; i++)
            {
                int totalPoints = 0;
                foreach (int score in points[i])
                {
                    totalPoints += score;
                }

                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    studentIndex = i;
                }
            }
            return $"Student {studentIndex + 1} got maximum points.";
        }
    }

}
