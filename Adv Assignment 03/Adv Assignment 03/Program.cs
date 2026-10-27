using System.Drawing;
using System.Runtime.ExceptionServices;
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
            ////Create a leaderboard that automatically sorts players by score.
            //SortedDictionary<int, string> leaderBoard = new SortedDictionary<int, string>();

            ////Add items to leaderboard
            //leaderBoard.Add(500, "Ahmed");
            //leaderBoard.Add(200, "Sara");
            //leaderBoard.Add(800, "Ali");
            //leaderBoard.Add(350, "Mona");

            ////Print all entries
            //Console.Write("All entries: ");
            //foreach (var item in leaderBoard)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            ////Access the first key and first value 
            //Console.WriteLine(leaderBoard.FirstOrDefault());
            //Console.WriteLine(leaderBoard.LastOrDefault());
            //Console.WriteLine();

            ////Check if score 500 exists
            //Console.Write("Check if 500 exists: ");
            //Console.Write(leaderBoard.ContainsKey(500));
            //Console.WriteLine();
            //Console.WriteLine();

            ////Safely get the player with score 999
            //if (leaderBoard.ContainsKey(999))
            //    Console.WriteLine(leaderBoard[999]);

            ////Remove the player with score 200 
            //leaderBoard.Remove(200);

            ////print the updated list
            //Console.Write("All entries: ");
            //foreach (var item in leaderBoard)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            #endregion

            #region Phone Book
            ////Create a Collection  with 4 contacts (name → phone number)
            //Dictionary<int, string> phoneBook = new Dictionary<int, string>()
            //{
            //    {101,"01586375943" },
            //    {102,"01256347851" },
            //    {103,"01025493578" },
            //    {104,"01188944321" }

            //};

            ////Add a new contact using [] syntax
            //phoneBook[105] = "01158416269";

            ////Try adding a duplicate using .Add()
            //try
            //{
            //    phoneBook.Add(102, "01255594516");
            //}catch(Exception ex)
            //{
            //    Console.WriteLine("This key is exisits already");
            //}
            //Console.WriteLine();

            ////Try adding a duplicate using .TryAdd() 
            //bool valid = phoneBook.TryAdd(102, "01255559347");
            //if (!valid)
            //    Console.WriteLine("This key is exisits already");
            //else
            //    Console.WriteLine("Add successfully");
            //Console.WriteLine();

            ////Search for a contact that doesn’t exist
            //if (phoneBook.TryGetValue(106, out string found))
            //    Console.WriteLine(found);
            //else
            //    Console.WriteLine("This item not found");
            //Console.WriteLine();

            ////Get a contact with a fallback of "Not Found"
            //int id = 105;
            //string contact = phoneBook.TryGetValue(id, out string phone) ? phone : "Not Found";
            //Console.WriteLine(contact);
            //Console.WriteLine();

            ////Print all Keys on one line, then all Values on another line
            //foreach (var item in phoneBook.Keys)
            //{
            //    Console.Write($"{item}  ");
            //}
            //Console.WriteLine();
            //foreach (var item in phoneBook.Values)
            //{
            //    Console.Write($"{item}  ");
            //}
            //Console.WriteLine();
            #endregion

            #region Unique Email Validator
            //Create a HashSet<string> with a case-insensitive comparer
            //HashSet<string> EmailAddress = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com", 
            //    "AHMED@test.com", 
            //    "sara@test.com", 
            //    "Sara@Test.Com"
            //};

            ////print count . Explain why
            //Console.WriteLine(EmailAddress.Count);//2
            //// HashSet Add only Unique Emails


            ////Create two sets: Set A = {1,2,3,4,5} and Set B = {4,5,6,7,8}
            //HashSet<int> A = [1, 2, 3, 4, 5];
            //HashSet<int> B = [4, 5, 6, 7, 8];

            ////Print the result of: UnionWith, IntersectWith, ExceptWith
            //HashSet<int> union = new HashSet<int>(A);

            //union.UnionWith(B);
            //foreach (int i in union)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("--------------------------");

            //union.IntersectWith(B);
            //foreach (int i in union)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("--------------------------");

            //union.ExceptWith(B);
            //foreach (int i in union)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();

            ////Use IsSubsetOf to check if {1,2} is a subset of Set A
            //HashSet<int> C = [1, 2];
            //Console.WriteLine(C.IsSubsetOf(A));

            #endregion

            #region Print Queue Simulator
            //Create a Queue<string> and enqueue 5 documents: "Report.pdf", "Invoice.pdf", "Letter.docx", "Resume.pdf", "Photo.jpg"
            //Queue<string> documents = new Queue<string>();
            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.jpg");


            ////Print the queue contents and Count
            //foreach (var item in documents)
            //{
            //    Console.Write($"{item}  ");
            //}
            //Console.WriteLine();

            //Console.WriteLine($"The count of documents: { documents.Count}");
            //Console.WriteLine();


            ////Use Peek to see which document will print next (without removing)
            //Console.WriteLine(documents.Peek());
            //Console.WriteLine();

            ////Process the queue: **Dequeue** each document and print "Printing: [name]"
            //while (documents.Count > 0)
            //{
            //    string document = documents.Dequeue();
            //    Console.WriteLine($"Printing: {document}");
            //}
            //Console.WriteLine();


            ////Try TryDequeue on the now-empty queue — what happens?
            //if (documents.TryDequeue(out string? x))
            //{
            //    Console.WriteLine($"Printing: {x}");
            //}
            //else
            //{
            //    Console.WriteLine("Queue is empty");
            //}


            #endregion

            #region Browser History (Undo)
            //Create a Stack<string> for browser history
            Stack<string> BrowserHistory = new Stack<string>();

            //Push 5 URLs: "google.com", "github.com", "stackoverflow.com", "youtube.com", "claude.ai"
            BrowserHistory.Push("google.com");
            BrowserHistory.Push("github.com");
            BrowserHistory.Push("stackoverflow.com");
            BrowserHistory.Push("youtube.com");
            BrowserHistory.Push("claude.ai");

            //Use Peek to see the current page (top of stack)
            Console.WriteLine(BrowserHistory.Peek());
            Console.WriteLine();

            //Press "back" 3 times using Pop — print each page you leave
            for (int i = 0; i < 3; i++)
            {
                if (BrowserHistory.Count > 0)
                {
                    string page = BrowserHistory.Pop();
                    Console.WriteLine($"Leaving: {page}");
                }
            }
            Console.WriteLine();

            //Print the current page after going back
            if (BrowserHistory.Count > 0)
            {
                Console.WriteLine($"Current page: {BrowserHistory.Peek()}");
            }
            else
            {
                Console.WriteLine("No pages left");
            }
            Console.WriteLine();


            //Try TryPop on an empty stack — what happens?
            BrowserHistory.Pop();
            BrowserHistory.Pop();
            
            if (BrowserHistory.TryPop(out string? x))
            {
                Console.WriteLine($"Leaving: {x}");
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }

            #endregion
        }
    }
}
