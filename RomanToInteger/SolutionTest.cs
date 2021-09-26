using System;
using Xunit;

namespace RomanToInteger
{
    public class SolutionTest
    {
        [Fact]
        public void TestCase1()
        {
            Solution solution = new Solution();
            var result = solution.RomanToInt("III");

            Assert.Equal(3, result);
        }

        [Fact]
        public void TestCase2()
        {
            Solution solution = new Solution();
            var result = solution.RomanToInt("IV");

            Assert.Equal(4, result);
        }

        [Fact]
        public void TestCase3()
        {
            Solution solution = new Solution();
            var result = solution.RomanToInt("IX");

            Assert.Equal(9, result);
        }

        [Fact]
        public void TestCase4()
        {
            Solution solution = new Solution();
            var result = solution.RomanToInt("LVIII");

            Assert.Equal(58, result);
        }

        [Fact]
        public void TestCase5()
        {
            Solution solution = new Solution();
            var result = solution.RomanToInt("MCMXCIV");

            Assert.Equal(1994, result);
        }
    }
}
