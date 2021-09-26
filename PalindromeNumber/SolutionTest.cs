using System;
using Xunit;

namespace PalindromeNumber
{
    public class SolutionTest
    {
        [Fact]
        public void TestPalindromeCase1()
        {
            Solution solution = new Solution();
            var result = solution.IsPalindrome(121);

            Assert.True(result);
        }

        [Fact]
        public void TestPalindromeCase2()
        {
            Solution solution = new Solution();
            var result = solution.IsPalindrome(-121);

            Assert.False(result);
        }

        [Fact]
        public void TestPalindromeCase3()
        {
            Solution solution = new Solution();
            var result = solution.IsPalindrome(10);

            Assert.False(result);
        }

        [Fact]
        public void TestPalindromeCase4()
        {
            Solution solution = new Solution();
            var result = solution.IsPalindrome(-101);

            Assert.False(result);
        }


        [Fact]
        public void TestPalindromeCase1UseString()
        {
            Solution solution = new Solution();
            var result = solution.isPalindromeUseString(121);

            Assert.True(result);
        }

        [Fact]
        public void TestPalindromeCase2UseString()
        {
            Solution solution = new Solution();
            var result = solution.isPalindromeUseString(-121);

            Assert.False(result);
        }

        [Fact]
        public void TestPalindromeCase3UseString()
        {
            Solution solution = new Solution();
            var result = solution.isPalindromeUseString(10);

            Assert.False(result);
        }

        [Fact]
        public void TestPalindromeCase4UseString()
        {
            Solution solution = new Solution();
            var result = solution.isPalindromeUseString(-101);

            Assert.False(result);
        }
    }
}
