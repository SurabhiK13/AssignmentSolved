using System;
using System.Collections;
namespace Assignment22_ArrayList_
{
    public class Program
    {
        public static ArrayList Attendance = new ArrayList()
        {
        "John", "Peter", "Jacob", "Archie", "Sophie", "Veronica", "Elizabeth", "Charles"
        };
        public bool RemoveStudent(string name)
        {
            if (Attendance.Contains(name))
            {
                Attendance.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SortTheAttendance()
        {
            Attendance.Sort();
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("1. Remove student");
            Console.WriteLine("2. Sort attendance");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the student name");
                string studentName = Console.ReadLine();

                if (program.RemoveStudent(studentName))
                {
                    Console.WriteLine("Removed successfully");
                }
                else
                {
                    Console.WriteLine("Remove failed");
                }
            }
            else if (choice == 2)
            {
                program.SortTheAttendance();
                Console.WriteLine("Sorted Attendance List:");
                foreach (string name in Attendance)
                {
                    Console.WriteLine(name);
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }

}
