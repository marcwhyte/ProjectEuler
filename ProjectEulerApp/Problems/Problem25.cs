using System;
using System.Numerics;

namespace ProjectEulerApp.Problems
{
    class Problem25 :UtilityMethods, IProblem
    {
        private string _name = "Problem 25";
        private string _title = "1000-digit Fibonacci number";
        private string _description = "The Fibonacci sequence is defined by the recurrence relation:"
            + Environment.NewLine + Environment.NewLine
            + "        Fₙ = Fₙ−1 + Fₙ−2, where F₁ = 1 and F₂ = 1."
            + Environment.NewLine + Environment.NewLine
            + "Hence the first 12 terms will be:"
            + Environment.NewLine + Environment.NewLine
            + "        F₁ = 1\n        F₂ = 1\n        F₃ = 2\n        F₄ = 3\n        F₅ = 5\n        F₆ = 8\n"
            + "        F₇ = 13\n        F₈ = 21\n        F₉ = 34\n        F₁₀ = 55\n        F₁₁ = 89\n        F₁₂ = 144"
            + Environment.NewLine + Environment.NewLine
            + "The 12th term, F₁₂, is the first term to contain three digits."
            + Environment.NewLine + Environment.NewLine
            + "What is the index of the first term in the Fibonacci sequence to contain 1000 digits?";
        string _requiredAnswer = "4782";
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

            BigInteger f = 2;
            BigInteger previous1 = 1;
            BigInteger previous2 = 1;
            BigInteger i = 3;

            while (NumDigits(f) < 1000)
            {
                f = previous1 + previous2;

                previous2 = previous1;
                previous1 = f;
                i++;
            }

            answer = i - 1;

            return answer;
        }
    }
}
