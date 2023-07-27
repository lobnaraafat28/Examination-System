using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class TrueAndFalseQuestion:Question
    {
        public bool AnswerTF { get; set; }
        public TrueAndFalseQuestion(string Body, int Mark, int RightId) : base("True | False", Body, Mark, RightId)
        {

        }
        public TrueAndFalseQuestion():base()
        {
            
        }

    }
}
