using System;
using Xunit;

namespace LongestCommonPrefix
{
    public class SolutionTest
    {
        [Fact]
        public void TestCase1()
        {
            Solution solution = new Solution();
            var result = solution.LongestCommonPrefix(new string [] { "flower", "flow", "flight" });

            Assert.Equal("fl", result);
        }

        [Fact]
        public void TestCase2()
        {
            Solution solution = new Solution();
            var result = solution.LongestCommonPrefix(new string[] { "dog", "racecar", "car" });

            Assert.Equal("", result);
        }
    }
}
