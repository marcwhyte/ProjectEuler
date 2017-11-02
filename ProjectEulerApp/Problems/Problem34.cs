using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEulerApp.Problems
{
    class Problem34 : UtilityMethods, IProblem
    {
        private string _name = "Problem 34";
        private string _title = "Digit factorials";
        private string _description = "145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145."
            + Environment.NewLine + Environment.NewLine
            + "Find the sum of all numbers which are equal to the sum of the factorial of their digits."
            + Environment.NewLine + Environment.NewLine
            + "Note: as 1! = 1 and 2! = 2 are not sums they are not included.";
        string _requiredAnswer = "40730";
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
            BigInteger sum = 0;
            BigInteger test = Factorial(2);
            BigInteger number = 3;
            BigInteger limit = 8 * Factorial(9);
            while (number < limit)
            {
                List<int> digits = GetDigits(number);
                BigInteger sumDigits = 0;
                foreach (int digit in digits)
                {
                    sumDigits += Factorial(digit);
                }

                if (sumDigits == number)
                {
                    sum += number;
                }
                number++;
            }

            return sum;
        }
    }
}
