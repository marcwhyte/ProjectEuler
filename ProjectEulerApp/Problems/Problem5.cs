﻿using System;
using System.Numerics;

namespace ProjectEulerApp.Problems
{
    class Problem5 : IProblem
    {
        private string _name = "Problem 5";
        private string _title = "Smallest multiple";
        private string _description = "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder."
            + Environment.NewLine + Environment.NewLine
            + "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
        private string _requiredAnswer = "232792560";
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
            bool isAnswer = false;
            BigInteger answer = 2520;

            while (!isAnswer)
            {
                isAnswer = true;
                answer++;
                for (int i = 1; i <= 20; i++)
                {
                    if (answer % i != 0)
                    {
                        isAnswer = false;
                    }
                }
            }

            return answer;
        }
    }
}
