using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Adv_Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Student Grade Manager
            ////Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            ////Print the collection
            //Console.Write("Grades : ");
            //foreach (var item in grades)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            ////Print the Count
            //Console.WriteLine($"Count of Grades : {grades.Count}");
            //Console.WriteLine();

            ////Print the first and last grade
            //Console.WriteLine($"First grade is: {grades.FirstOrDefault()}");
            //Console.WriteLine($"Last grade is: {grades.LastOrDefault()}");
            //Console.WriteLine();

            ////Sort the grades ascending
            //grades.Sort();

            ////Print the sorted grades
            //Console.Write("Sorted Grades : ");
            //foreach (var item in grades)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //// Get the first grade above 90
            //int _above_90 = 0;
            //for(int i = 0; i < grades.Count; i++)
            //{
            //    if (grades[i] > 90)
            //    {
            //        _above_90 = grades[i];
            //        break;
            //    }
            //}
            //Console.WriteLine($"The fist element above 90 is: {_above_90}");
            //Console.WriteLine();

            ////Get all grades below 75 (failing grades)
            //List<int> failingGrades = new List<int>();
            //for(int i = 0; i < grades.Count; i++)
            //{
            //    if (grades[i] < 75)
            //    {
            //        failingGrades.Add(grades[i]);
            //    }
            //}

            //Console.Write("The failing Grades is: ");
            //foreach (var item in failingGrades)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            ////Remove all failing grades (below 75)
            //foreach (var item in failingGrades)
            //{
            //    grades.Remove(item);
            //}

            ////print grades after remove failing grades
            //Console.Write("Sorted Grades After Remove failing grades: ");
            //foreach (var item in grades)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            ////Check if any grade equals 100
            //Console.Write("Check if any grade equals 100 : ");
            //Console.WriteLine(grades.Contains(100));
            //Console.WriteLine();

            ////Create a List<string> where each grade becomes "Grade: X"
            //List<string> StringGrades = new List<string>();

            //foreach (var grade in grades)
            //{
            //    StringGrades.Add($"Grade: {grade}");
            //}

            ////print string grades
            //Console.WriteLine("String grades: ");
            //foreach(var item in StringGrades)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            //Console.WriteLine();

            #endregion

            #region Leaderboard
            //Create a leaderboard that automatically sorts players by score.
            SortedDictionary<int, string> leaderBoard = new SortedDictionary<int, string>();

            //Add items to leaderboard
            leaderBoard.Add(500, "Ahmed");
            leaderBoard.Add(200, "Sara");
            leaderBoard.Add(800, "Ali");
            leaderBoard.Add(350, "Mona");

            //Print all entries
            Console.Write("All entries: ");
            foreach (var item in leaderBoard)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Access the first key and first value 
            Console.WriteLine(leaderBoard.FirstOrDefault());
            Console.WriteLine(leaderBoard.LastOrDefault());
            Console.WriteLine();

            //Check if score 500 exists
            Console.Write("Check if 500 exists: ");
            Console.Write(leaderBoard.ContainsKey(500));
            Console.WriteLine();
            Console.WriteLine();

            //Safely get the player with score 999
            if (leaderBoard.ContainsKey(999))
                Console.WriteLine(leaderBoard[999]);

            //Remove the player with score 200 
            leaderBoard.Remove(200);

            //print the updated list
            Console.Write("All entries: ");
            foreach (var item in leaderBoard)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            #endregion
        }
    }
}
