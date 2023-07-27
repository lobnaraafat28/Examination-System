using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
     class MCQQuestion:Question
    {
        public MCQQuestion(string Body, int Mark, int RightId) : base("MCQ", Body, Mark, RightId)
        {

        }
        public MCQQuestion():base()
        {
            
        }



    }
}
