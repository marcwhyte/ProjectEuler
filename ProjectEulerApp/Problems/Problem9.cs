using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerApp.Problems
{
    class Problem9 : IProblem
    {
        private string _name = "Problem 9";
        private string _title = "Special Pythagorean triplet";
        private string _description = "A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,"
            + Environment.NewLine + Environment.NewLine
            + "        a\xB2 + b\xB2 = c\xB2"
            + Environment.NewLine + Environment.NewLine
            + "For example, 3\xB2 + 4\xB2 = 9 + 16 = 25 = 5\xB2."
            + Environment.NewLine + Environment.NewLine
            + "There exists exactly one Pythagorean triplet for which a + b + c = 1000."
            + Environment.NewLine + Environment.NewLine
            + "Find the product abc.";
        string _requiredAnswer = "31875000";
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
            double c = 0;
            double sumOfSquares = 0;
            BigInteger A;
            BigInteger B;
            BigInteger C;

            for (int a = 0; a < 999; a++)
            {
                for (int b = 0; b < 999; b++)
                {
                    sumOfSquares = a * a + b * b;
                    
                    if (Math.Sqrt(sumOfSquares) % 1 == 0 && Math.Sqrt(sumOfSquares) > b)
                    {
                        c = Math.Sqrt(sumOfSquares);
                        if (a + b + c == 1000)
                        {
                            BigInteger.TryParse(a.ToString(), out A);
                            BigInteger.TryParse(b.ToString(), out B);
                            BigInteger.TryParse(c.ToString(), out C);
                            return A * B * C;
                        }
                    }
                }
            }
            
            return answer;
        }
    }
}
