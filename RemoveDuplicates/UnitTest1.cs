using System;
using Xunit;

namespace RemoveDuplicates
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            var result = solution.RemoveDuplicates(new int[] { 1, 1, 2 });

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            Solution solution = new Solution();
            var result = solution.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });

            Assert.Equal(5, result);
        }
    }
}
