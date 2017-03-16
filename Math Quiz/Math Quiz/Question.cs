using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Quiz
{
    class Question
    {
        public Question(string fileLocation, string answer)
        {
            this.fileLocation = fileLocation;
            this.answer = answer;
        }

        public string fileLocation;
        public string answer;
    }
}
