using System;
using Xunit;

namespace RemoveElement
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            var result = solution.RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            Solution solution = new Solution();
            var result = solution.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
            Assert.Equal(5, result);
        }
    }
}
