using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerApp.Problems
{
    class Problem3 : UtilityMethods, IProblem
    {
        private string _name = "Problem 3";
        private string _title = "Largest prime factor";
        private string _description = "The prime factors of 13195 are 5, 7, 13 and 29."
            + Environment.NewLine + Environment.NewLine
            + "What is the largest prime factor of the number 600851475143 ?";
        string _requiredAnswer = "6857";
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
            BigInteger number = 600851475143;
            BigInteger newNum = number;
            BigInteger answer = 0;

            int counter = 2;
            while (counter * counter <= newNum)
            {
                if (newNum % counter == 0)
                {
                    newNum = newNum / counter;
                    answer = counter;
                }
                else
                {
                    counter = (counter == 2) ? 3 : counter + 2;
                }
            }
            if (newNum > answer)
            {
                answer = newNum;
            }
            return answer;
        }
    }
}
