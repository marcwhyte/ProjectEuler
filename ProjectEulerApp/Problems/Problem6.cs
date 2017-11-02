using System;
using System.Numerics;

namespace ProjectEulerApp.Problems
{
    class Problem6 : IProblem
    {
        private string lineSkip = Environment.NewLine + Environment.NewLine;
        private string _name = "Problem 6";
        private string _title = "Sum square difference";
        private string _description = "The sum of the squares of the first ten natural numbers is,"
            + Environment.NewLine + Environment.NewLine
            + "        1\xB2 + 2\xB2 + ... + 10\xB2 = 385"
            + Environment.NewLine + Environment.NewLine
            + "The square of the sum of the first ten natural numbers is,"
            + Environment.NewLine + Environment.NewLine
            + "        (1 + 2 + ... + 10)\xB2 = 55\xB2 = 3025"
            + Environment.NewLine + Environment.NewLine
            + "Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640."
            + Environment.NewLine + Environment.NewLine
            + "Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";
        private string _requiredAnswer = "25164150";
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
            BigInteger sumOfSquares = 0;
            BigInteger sum = 0;
            BigInteger squareOfSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                sum += i;
            }

            squareOfSum = sum * sum;

            answer = squareOfSum - sumOfSquares;
            return answer;
        }
    }
}
