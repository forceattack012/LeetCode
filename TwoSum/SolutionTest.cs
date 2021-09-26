using System;
using Xunit;

namespace TwoSum
{
    public class SolutionTest
    {
        [Fact]
        public void TestCase1()
        {
            Solution solution = new Solution();
            var result  = solution.TwoSum(new int[] { 2,7,11,15 } ,9);
            
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void TestCase2()
        {
            Solution solution = new Solution();
            var result = solution.TwoSum(new int[] { 3,2,4 }, 6);

            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void TestCase3()
        {
            Solution solution = new Solution();
            var result = solution.TwoSum(new int[] { 3,3 }, 6);

            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void TestCase1UseDictionary()
        {
            Solution solution = new Solution();
            var result = solution.TwoSumUseDictionanry(new int[] { 2, 7, 11, 15 }, 9);

            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void TestCase2UseDictionary()
        {
            Solution solution = new Solution();
            var result = solution.TwoSumUseDictionanry(new int[] { 3, 2, 4 }, 6);

            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void TestCase3UseDictionary()
        {
            Solution solution = new Solution();
            var result = solution.TwoSumUseDictionanry(new int[] { 3, 3 }, 6);

            Assert.Equal(new int[] { 0, 1 }, result);
        }
    }
}
