using System;
using Xunit;

namespace PlusOne
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            var result = solution.PlusOne(new int [] { 1,2,3 });
            Assert.Equal(new int[] { 1, 2, 4 }, result);
        }

        [Fact]
        public void Test2()
        {
            Solution solution = new Solution();
            var result = solution.PlusOne(new int[] { 9 });
            Assert.Equal(new int[] { 1,0 }, result);
        }

        [Fact]
        public void Test3()
        {
            Solution solution = new Solution();
            var result = solution.PlusOne(new int[] { 0 });
            Assert.Equal(new int[] { 1 }, result);
        }

        [Fact]
        public void Test4()
        {
            Solution solution = new Solution();
            var result = solution.PlusOne(new int[] { 1 });
            Assert.Equal(new int[] { 2 }, result);
        }

        [Fact]
        public void Test5()
        {
            Solution solution = new Solution();
            var result = solution.PlusOne(new int[] { 9,9 });
            Assert.Equal(new int[] { 1,0,0 }, result);
        }

        [Fact]
        public void Test6()
        {
            Solution solution = new Solution();
            var result = solution.PlusOne(new int[] { 8, 9, 9, 9 });
            Assert.Equal(new int[] { 9,0,0,0 }, result);
        }
    }
}
