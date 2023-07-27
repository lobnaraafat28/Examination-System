using System.Diagnostics;

namespace Exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string y;

            Subject subject = new Subject(10, "C#");
            subject.CreateExam();
            Console.Clear();
            do
            {
                Console.WriteLine("Do you Want to start the Exam? insert (yes) or (no)");
                y = Console.ReadLine();
            } while (y.ToLower() != "yes" && y.ToLower() != "no");
            if (y.ToLower() == "yes")
            {
                subject.ExamT.ShowExam();
              
                Console.WriteLine("-------------- *Good Luck* ----------------");
            }
            else
            {
				Console.Clear();
				Console.WriteLine("Good Bye");
			}
                
        }
    }
}