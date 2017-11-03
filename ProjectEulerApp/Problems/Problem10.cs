using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerApp.Problems
{
    class Problem10 : UtilityMethods, IProblem
    {
        private string _name = "Problem 10";
        private string _title = "Summation of primes";
        private string _description = "The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17."
            + Environment.NewLine + Environment.NewLine
            + "Find the sum of all the primes below two million.";
        string _requiredAnswer = "142913828922";
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
            int[] primes = ESieve(2000000);

            foreach (int prime in primes)
            {
                answer += prime;
            }
            
            return answer;
        }
    }
}
