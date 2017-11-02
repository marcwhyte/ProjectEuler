using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerApp.Problems
{
    class Problem4 : IProblem
    {
        private string _name = "Problem 4";
        private string _title = "Largest palindrome product";
        private string _description = "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99."
            + Environment.NewLine + Environment.NewLine
            + "Find the largest palindrome made from the product of two 3-digit numbers.";
        private long _requiredAnswer = 906609;
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
            int a = 999;
            int b = 999;
            long product;
            string productString;
            string reverseProductString;

            while (a > 0)
            {
                while (b > 0)
                {
                    product = a * b;
                    productString = product.ToString();
                    reverseProductString = new string(productString.ToCharArray().Reverse().ToArray());

                    if (productString == reverseProductString)
                    {
                        answer = product;
                        break;
                    }
                    b--;
                }
                if (answer > 0)
                {
                    break;
                }
                a--;
            }
            return answer;
        }
    }
}
