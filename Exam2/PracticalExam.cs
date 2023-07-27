using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam2
{
    class PracticalExam : Exam
    {
        public Question[] Questions { get; set; }
        public PracticalExam(int TimeOfExam, int numberOfQuestions):base(TimeOfExam, numberOfQuestions) { }
        public override void SetQuestions(int number)
        {
            Questions = new MCQQuestion[number];
            int M, R;
            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("MCQ:");
                    Questions[i] = new MCQQuestion();
                    Console.WriteLine($"Please insert the Body of Question ({i+1})");
                    Questions[i].Body = Console.ReadLine();
                    do
                    {
                        Console.WriteLine("Please insert the Mark of Question");

                    } while (!int.TryParse(Console.ReadLine(), out M));
                    Questions[i].Mark = M;
                    Questions[i].AnswerList = AnswerInitialization.Insert(2);

                    do
                    {
                        Console.WriteLine("Please Write the number of right answer");

                    } while (!int.TryParse(Console.ReadLine(), out R) || (R < 1 || R > 4));
                    Questions[i].RightAnswer = R;
                    Questions[i].Header = "MCQ";

                }
               
            }
        }

        public override void ShowExam()
        {
            int answerId;
            Console.Write("Practical Exam-");
            Console.WriteLine($"Time: {TimeOfExam} Min");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
			Stopwatch sw = Stopwatch.StartNew();
			sw.Start();

            if (Questions != null)
            {

                foreach (var question in Questions)
                {

                    Console.WriteLine(question.Header);
                    Console.WriteLine(question.Body);
                    string[] RightAnswers = new string[NumberOfQuestions];

                    for (int i = 0; i < question.AnswerList?.Length; i++)
                    {
                        Console.WriteLine(question.AnswerList[i].ToString());
                        for (int k = 0; k < NumberOfQuestions; k++)
                        {
                            RightAnswers[k] = question.RightAnswer.ToString();

                        }
                    }
                    do
                    {
                        Console.Write("Enter your answer:");
                        if (sw.Elapsed.TotalSeconds < TimeOfExam * 60)
                            continue;
                        else
                            Console.WriteLine("------------");
							Console.WriteLine("********* Time out **********");
						break;
					} while (!int.TryParse(Console.ReadLine(), out answerId) || (answerId < 1 || answerId > 4));
                    
				}

				Console.WriteLine("The right answers are:");
                
                    foreach (var question in Questions)
                    {

                        AnswerInitialization.Search(question.RightAnswer, question.AnswerList);

                    }

				Console.WriteLine($"The Time you spent: {sw.Elapsed}");


			}

		}

    }
}
