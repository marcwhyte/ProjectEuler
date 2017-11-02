using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEulerApp.Problems
{
    class Problem30 : UtilityMethods, IProblem
    {
        private string _name = "Problem 30";
        private string _title = "Digit fifth powers";
        private string _description = "Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:"
            + Environment.NewLine + Environment.NewLine
            + "        1634 = 14 + 64 + 34 + 44\n"
            + "        8208 = 84 + 24 + 04 + 84\n"
            + "        9474 = 94 + 44 + 74 + 44"
            + Environment.NewLine + Environment.NewLine
            + "As 1 = 14 is not a sum it is not included."
            + Environment.NewLine + Environment.NewLine
            + "The sum of these numbers is 1634 + 8208 + 9474 = 19316."
            + Environment.NewLine + Environment.NewLine
            + "Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.";
        string _requiredAnswer = "443839";
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
            List<int> test = GetDigits(123456);

            int power = 5;
            BigInteger max = 4 * BigInteger.Pow(9, power);

            BigInteger number = 2;
            BigInteger sum = 0;

            while (number < max)
            {
                List<int> digits = GetDigits(number);
                BigInteger sumOfFourthPowers = 0;
                foreach (int digit in digits)
                {
                    sumOfFourthPowers += BigInteger.Pow(digit, power);
                }

                if (number == sumOfFourthPowers)
                {
                    sum += number;
                }
                number++;
            }

            return sum;
        }
    }
}
