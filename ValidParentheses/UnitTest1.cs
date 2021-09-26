using System;
using Xunit;

namespace ValidParentheses
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            var result = solution.IsValid("()");

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            Solution solution = new Solution();
            var result = solution.IsValid("()[]{}");

            Assert.True(result);
        }


        [Fact]
        public void Test3()
        {
            Solution solution = new Solution();
            var result = solution.IsValid("(]");

            Assert.False(result);
        }

        [Fact]
        public void Test4()
        {
            Solution solution = new Solution();
            var result = solution.IsValid("([)]");

            Assert.False(result);
        }

        [Fact]
        public void Test5()
        {
            Solution solution = new Solution();
            var result = solution.IsValid("{[]}");

            Assert.True(result);
        }

        [Fact]
        public void TestCase6()
        {
            Solution solution = new Solution();
            var result = solution.IsValid("(([]){})");

            Assert.True(result);
        }
    }
}
