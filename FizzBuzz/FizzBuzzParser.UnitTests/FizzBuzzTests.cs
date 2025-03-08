using System;
using NUnit.Framework;

namespace FizzBuzzParser.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]
        public void ReturnFizz_OnlyDivisibleBy3(int input, string expected)
        {
            FizzBuzzParser parser = new FizzBuzzParser();
            String result = parser.Parse(input);
            Assert.AreEqual(expected, result);
        }

        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(25, "Buzz")]
        public void ReturnBuzz_OnlyDivisibleBy5(int input, string expected)
        {
            FizzBuzzParser parser = new FizzBuzzParser();
            String result = parser.Parse(input);
            Assert.AreEqual(expected, result);
        }
        
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(45, "FizzBuzz")]
        [TestCase(60, "FizzBuzz")]
        public void ReturnFizzBuzz_DivisibleBy5And3(int input, string expected)
        {
            FizzBuzzParser parser = new FizzBuzzParser();
            String result = parser.Parse(input);
            Assert.AreEqual(expected, result);
        }
        
        
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        public void ReturnNumber_NotDivisibleBy5Nor3(int input, string expected)
        {
            FizzBuzzParser parser = new FizzBuzzParser();
            String result = parser.Parse(input);
            Assert.AreEqual(expected, result);
        }
    }
}