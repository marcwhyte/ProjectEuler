using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

        public static int[] ESieve(int upperLimit)
        {
            int sieveBound = (int)(upperLimit - 1) / 2;
            int upperSqrt = ((int)(Math.Sqrt(upperLimit) - 1) / 2);

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++)
            {
                if (PrimeBits.Get(i))
                {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j+= 2 * i + 1)
                    {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++)
            {
                if (PrimeBits.Get(i))
                {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers.ToArray();
        }

        public static int[,] readInputTo2DArray(string filename)
        {
            int lines = 0;
            string line;
            string[] linePieces;

            StreamReader r = new StreamReader(filename);
            while (r.ReadLine() != null)
            {
                lines++;
            }

            int[,] inputSquare = new int[lines, lines];
            r.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = r.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int i = 0; i < linePieces.Length; i++)
                {
                    inputSquare[j, i] = int.Parse(linePieces[i]);
                }
                j++;
            }

            r.Close();

            return inputSquare;
        }

        public static int GetNumDivisors(BigInteger number)
        {
            int numDivisors = 0;
            BigInteger sqrt = (BigInteger)Math.Sqrt((double)number);

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    numDivisors += 2;
                }
            }
            if (sqrt * sqrt == number)
            {
                numDivisors--;
            }
            return numDivisors;
        }
    }
}
