using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamT { get; set; }
        public Subject(int SubId, string name)
        {
            SubjectId = SubId;
            SubjectName = name;

        }
        public void CreateExam()
        {
            int n, Time, Type;
            do
            {
                Console.WriteLine("Please Enter the Type of Exam: 1 for Final | 2 for Practical");

            } while (!(int.TryParse(Console.ReadLine(), out Type) && Type == 1 || Type == 2));
            do
            {
                Console.WriteLine("Please Enter the number of Questions");

            } while (!int.TryParse(Console.ReadLine(), out n));
            do
            {
                Console.WriteLine("Please Enter the Time of Exam in minutes");

            } while (!int.TryParse(Console.ReadLine(), out Time));

            if (Type == 1)
            {
                ExamT = new FinalExam(Time, n);
                ExamT.SetQuestions(n);

            }
            else if (Type == 2)
            {
                ExamT = new PracticalExam(Time, n);
                ExamT.SetQuestions(n);
            }
            else
            {
                Console.WriteLine("Invalid Exam Type");
            }
        }


    }

}

