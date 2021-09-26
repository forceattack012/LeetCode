using System;
using Xunit;

namespace SearchInsert
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            var result = solution.SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            Solution solution = new Solution();
            var result = solution.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test3()
        {
            Solution solution = new Solution();
            var result = solution.SearchInsert(new int[] { 1, 3, 5, 6 }, 7);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test4()
        {
            Solution solution = new Solution();
            var result = solution.SearchInsert(new int[] { 1, 3, 5, 6 }, 0);
            Assert.Equal(0, result);
        }
    }
}
