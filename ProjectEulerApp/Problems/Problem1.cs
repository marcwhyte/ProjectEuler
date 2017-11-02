using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerApp.Problems
{
    class Problem1 : IProblem
    {
        private string _name = "Problem 1";
        private string _title = "Multiples of 3 and 5";
        private string _description = "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23."
            + Environment.NewLine + Environment.NewLine
            + "Find the sum of all the multiples of 3 or 5 below 1000.";
        private long _requiredAnswer = 233168;
        private long _myAnswer;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public long RequiredAnswer
        {
            get { return _requiredAnswer; }
            set { _requiredAnswer = value; }
        }

        public long MyAnswer
        {
            get { return _myAnswer; }
            set { _myAnswer = value; }
        }

        public long GetAnswer()
        {
            long answer = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    answer += i;
                }
            }

            return answer;
        }
    }
}
