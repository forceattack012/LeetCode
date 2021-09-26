using System;
using Xunit;

namespace StrStr
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            var result = solution.StrStr("hello", "ll");
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            Solution solution = new Solution();
            var result = solution.StrStr("aaaaa", "bba");
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test3()
        {
            Solution solution = new Solution();
            var result = solution.StrStr("", "");
            Assert.Equal(0, result);
        }
    }
}
