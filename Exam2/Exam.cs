using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    abstract class Exam
    {
        int timeOfExam;
        int numberOfQuestions;
        public int TimeOfExam
        {
            get { return timeOfExam; }
            set { timeOfExam = value > 0 ? value : 5; }
        }
        public int NumberOfQuestions
        {
            get { return numberOfQuestions; }
            set { numberOfQuestions = value > 0 ? value : 1; }
        }
        public Exam(int TimeOfExam, int numberOfQuestions)
        {
            this.timeOfExam = TimeOfExam;
            this.numberOfQuestions = numberOfQuestions;

        }
        public abstract void SetQuestions( int number);

        public abstract void ShowExam();
    }
}
