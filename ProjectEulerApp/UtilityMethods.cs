using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerApp
{
    public class UtilityMethods
    {
        public static int NumDigits(BigInteger number)
        {
            int numDigits = 0;

            while (number > 0)
            {
                number = (number - number % 10) / 10;
                numDigits += 1;
            }

            return numDigits;
        }

        public static List<int> GetDigits(BigInteger number)
        {
            List<int> digits = new List<int>();

            while (number > 0)
            {
                int digit = (int)BigInteger.ModPow(number, 1, 10);
                digits.Add(digit);

                number = (number - digit) / 10;
            }

            return digits;
        }

        public static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;

            if (number == 0 || number == 1)
            {
                factorial = 1;
            }
            else
            {
                for (int i = number; i > 1; i--)
                {
                    factorial *= i;
                }
            }

            return factorial;
        }

        public static string ToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }

        public static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            char[] numberArray = numberString.ToCharArray();
            Array.Reverse(numberArray);
            string reversedString = new string(numberArray);
            if (reversedString == numberString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPalindrome(string number)
        {
            char[] numberArray = number.ToCharArray();
            Array.Reverse(numberArray);
            string reversedString = new string(numberArray);
            if (reversedString == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPrime(BigInteger number)
        {
            bool isPrime = false;

            if (number == 2)
            {
                return true;
            }
            else if (number < 2)
            {
                return false;
            }
            else
            {
                isPrime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }

            return isPrime;
        }

        public static bool IsPentagonal(int number)
        {
            double penTest = (Math.Sqrt(1 + 24 * number) + 1.0) / 6.0;
            return penTest == ((int)penTest);
        }
    }
}
