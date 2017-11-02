using System;
using System.Numerics;

namespace ProjectEulerApp.Problems
{
    class Problem37 : UtilityMethods, IProblem
    {
        private string _name = "Problem 37";
        private string _title = "Multiples of 3 and 5";
        private string _description = "The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3."
            + Environment.NewLine + Environment.NewLine
            + " Find the sum of the only eleven primes that are both truncatable from left to right and right to left."
            + Environment.NewLine + Environment.NewLine
            + "NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.";
        string _requiredAnswer = "748317";
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
            int count = 0;
            BigInteger answer = 0;
            int number = 13;

            while (count < 11)
            {
                if (IsPrime(number))
                {
                    bool cont = true;
                    int originalNumber = number;
                    // Remove digits right-to-left
                    while (number > 0)
                    {
                        number = number / 10;
                        if (number > 0 && !IsPrime(number))
                        {
                            cont = false;
                            break;
                        }
                    }

                    // Remove digits left-to-right
                    number = originalNumber;
                    while (number > 0 && cont == true)
                    {
                        number = Convert.ToInt32(number % Math.Pow(10, NumDigits(number) - 1));
                        if (number > 0 && !IsPrime(number))
                        {
                            cont = false;
                            break;
                        }
                    }


                    if (cont)
                    {
                        answer += originalNumber;
                        count++;
                    }

                    number = originalNumber;
                }
                number++;
            }

            return answer;
        }
    }
}
