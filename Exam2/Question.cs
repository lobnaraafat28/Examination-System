using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
     class Question
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }

        public int RightAnswer { get; set; }
        public Question(string Body, string Header, int Mark, int RightAnswer)
        {
            this.Body = Body;
            this.Header = Header;
            this.Mark = Mark;
            this.RightAnswer = RightAnswer;

        }

        public Question()
        {
          
        }
        public static bool Check(int AnsId1, int AnsId2)
        {
            if (AnsId1 == AnsId2) return true;
            else return false;
        }

    }
}
