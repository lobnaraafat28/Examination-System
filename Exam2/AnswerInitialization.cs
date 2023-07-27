using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    static class AnswerInitialization
    {
        const int mcqAnswersCount = 4,tfAnswersCount = 2;
        public static Answer[] Insert(int qtype)
        {
           Answer[] AnsList = new Answer[(qtype == 2) ? mcqAnswersCount : tfAnswersCount];
           if (qtype ==1)
            {
                AnsList[0] = new Answer(1, "True");
                AnsList[1] = new Answer(2, "False");
            }
           else 
            {
                for (int i = 0; i < AnsList.Length; i++)
                {
                    Console.WriteLine($"Insert Choice {i + 1}");
                    Answer ans = new Answer(i +1,Console.ReadLine());
                  
						AnsList[i] = ans;
					
                     
                    
                }
            }
            return AnsList;
        }

        public static void Search(int id, Answer[] A)
        {
            if (A is not null)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (id == A[i].AnswerId)
                        Console.WriteLine(A[i].ToString());

                }
            }
            
        }
    }
}
