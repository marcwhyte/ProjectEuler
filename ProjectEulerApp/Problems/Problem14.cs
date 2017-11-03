using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerApp.Problems
{
    class Problem14 : UtilityMethods, IProblem
    {
        private string _name = "Problem 14";
        private string _title = "Longest Collatz sequence";
        private string _description = "The following iterative sequence is defined for the set of positive integers:"
            + Environment.NewLine + Environment.NewLine
            + "        n → n/2 (n is even)\n"
            + "        n → 3n + 1 (n is odd)"
            + Environment.NewLine + Environment.NewLine
            + "Using the rule above and starting with 13, we generate the following sequence:"
            + Environment.NewLine + Environment.NewLine
            + "        13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1"
            + Environment.NewLine + Environment.NewLine
            + "It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1."
            + Environment.NewLine + Environment.NewLine
            + "Which starting number, under one million, produces the longest chain?"
            + Environment.NewLine + Environment.NewLine
            + "NOTE: Once the chain starts the terms are allowed to go above one million.";
        string _requiredAnswer = "";
        private BigInteger _myAnswer;

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

        public string RequiredAnswer
        {
            get { return _requiredAnswer; }
            set { _requiredAnswer = value; }
        }

        public BigInteger MyAnswer
        {
            get { return _myAnswer; }
            set { _myAnswer = value; }
        }

        public BigInteger GetAnswer()
        {
            BigInteger answer = 0;
            BigInteger largestCount = 1;
            
            for (BigInteger i = 1; i < 1000000; i++)
            {
                BigInteger count = 1;
                BigInteger n = i;
                while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    count++;
                }

                if (count > largestCount)
                {
                    answer = i;
                    largestCount = count;
                }
            }

            return answer;
        }
    }
}
