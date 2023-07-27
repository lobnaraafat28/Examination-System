using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class FinalExam : Exam
    {
        public Question[] Questions { get; set; }
        public FinalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions) { }

        public override void SetQuestions( int number)
        {
            Questions = new Question[number];
            int M, R, type;
            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    do
                    {
                        Console.WriteLine("Please insert the type of Question: 1 for True | False , 2 for MCQ");

                    } while (!int.TryParse(Console.ReadLine(), out type));
                    if (type == 1)
                    {
                        Questions[i] = new TrueAndFalseQuestion();

                        Console.WriteLine("True | False:");

                        Console.WriteLine($"Please insert the Body of Question ({i+1})");
                        Questions[i].Body = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Please insert the Mark of Question");

                        } while (!int.TryParse(Console.ReadLine(), out M));
                        Questions[i].Mark = M;
                        Questions[i].AnswerList = AnswerInitialization.Insert(type);
                        do
                        {
                            Console.WriteLine("Please Write the number of right answer: 1.True | 2.False");
                            

						} while (!int.TryParse(Console.ReadLine(), out R) || (R <1 || R>2));
                        Questions[i].RightAnswer = R;
                        Questions[i].Header = "True | False";


                    }
                    else if (type == 2)
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

                        Questions[i].AnswerList = AnswerInitialization.Insert(type);                        
                        do
                        {
                            Console.WriteLine("Please Write the number of right answer");

                        } while (!int.TryParse(Console.ReadLine(), out R) || (R < 1 || R > 4));
                        Questions[i].RightAnswer = R;
                        Questions[i].Header = "MCQ";
                    }
                    else
                    {
                        throw new Exception("Invalid Exam Type");
                    }

                }
            }

        }

        public override void ShowExam()
        {
            int Marks = 0, answerId;

            Console.Write("Final Exam-");
            Console.WriteLine($"Time: {TimeOfExam} Min ");
            Console.WriteLine("Number of Questions: " + NumberOfQuestions);
			Stopwatch sw = Stopwatch.StartNew();
			sw.Start();
			if (Questions != null)
            {
                foreach (var question in Questions)
                {
                    Console.WriteLine(question.Header);
                    Console.WriteLine(question.Body);
                    for (int i = 0; i < question.AnswerList?.Length; i++)
                    {
                        Console.WriteLine(question.AnswerList[i].ToString());
                    }
                    do
                    {
                        Console.Write("Enter your answer:");
						
							
					} while (!int.TryParse(Console.ReadLine(), out answerId));


					
                        bool Try = Question.Check(answerId, question.RightAnswer);

                        if (Try)
                        {
                            Marks += question.Mark;
                        }
                        else
                        {
                            Console.WriteLine("Your Answer in incorrect");
                        }
					if (sw.Elapsed.TotalSeconds < TimeOfExam * 60)
						continue;
					else
					{
						Console.WriteLine("------------");
						Console.WriteLine("********* Time out **********");
						break;
					}

				}

                Console.WriteLine("Total marks:" + Marks);
				Console.WriteLine($"The Time you spent: {sw.Elapsed}");
			}

        }


    }
}
