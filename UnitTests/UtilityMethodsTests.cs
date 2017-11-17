using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using ProjectEulerApp;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UtilityMethodsTests : UtilityMethods
    {
        [TestMethod]
        public void NumDigits_FourDigitNumber_4()
        {
            // Arrange
            BigInteger input = 1234;
            int expected = 4;
            int result;

            // Act
            result = NumDigits(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetDigits_FourDigits_1234()
        {
            // Arrange
            BigInteger input = 1234;
            List<int> expected = new List<int> { 1, 2, 3, 4 };
            List<int> result = new List<int>();           

            // Act
            result = GetDigits(input);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Factorial_12_479001600()
        {
            // Arrange
            int input = 12;
            BigInteger expected = 479001600;
            BigInteger result;

            // Act
            result = Factorial(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToBinary_1234_10011010010()
        {
            // Arrange
            int input = 1234;
            string expected = "10011010010";
            string result;

            // Act
            result = ToBinary(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPalindrome_1234int_False()
        {
            // Arrange
            int input = 1234;
            bool expected = false;
            bool result;

            // Act
            result = IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPalindrome_1234321int_True()
        {
            // Arrange
            int input = 1234321;
            bool expected = true;
            bool result;

            // Act
            result = IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPalindrome_1234string_False()
        {
            // Arrange
            string input = "1234";
            bool expected = false;
            bool result;

            // Act
            result = IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPalindrome_1234321string_True()
        {
            // Arrange
            string input = "1234321";
            bool expected = true;
            bool result;

            // Act
            result = IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPrime_79_True()
        {
            // Arrange
            BigInteger input = 79;
            bool expected = true;
            bool result;

            // Act
            result = IsPrime(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNumDivisors_20_6()
        {
            // Arrange
            BigInteger input = 20;
            int expected = 6;
            int result;

            // Act
            result = GetNumDivisors(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
