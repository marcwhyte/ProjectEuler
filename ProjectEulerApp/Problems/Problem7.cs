using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerApp.Problems
{
    class Problem7 : IProblem
    {
        private string _name = "Problem 7";
        private string _title = "10001st prime";
        private string _description = "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13."
            + Environment.NewLine + Environment.NewLine
            + "What is the 10 001st prime number?";
        private string _requiredAnswer = "104743";
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
            int i = 0;
            bool isPrime = true;

            while (i <= 10001)
            {
                answer++;

                for (int j = 0; j <= answer; j++)
                {
                    isPrime = true; // Move initialization to here
                    for (int k = 2; k < Math.Sqrt(j); k++) // you actually only need to check up to sqrt(i)
                    {
                        if (j % k == 0) // you don't need the first condition
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    // isPrime = true;
                }
                if (isPrime)
                {
                    i++;
                }

            }

            return answer;
        }
    }
}
