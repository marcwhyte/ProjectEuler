using System;
using System.Numerics;

namespace ProjectEulerApp.Problems
{
    class Problem36 : UtilityMethods, IProblem
    {
        private string _name = "Problem 36";
        private string _title = "Double-base palindromes";
        private string _description = "The decimal number, 585 = 10010010012 (binary), is palindromic in both bases."
            + Environment.NewLine + Environment.NewLine
            + "Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2."
            + Environment.NewLine + Environment.NewLine
            + "(Please note that the palindromic number, in either base, may not include leading zeros).";
        string _requiredAnswer = "872187";
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

            int i = 1;

            while (i < 1000000)
            {
                if (IsPalindrome(i) && IsPalindrome(ToBinary(i)))
                {
                    answer += i;
                }
                i++;
            }

            return answer;
        }
    }
}
