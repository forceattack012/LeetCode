using System;
using Xunit;

namespace MaxMin
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] numbers = new int[]
            {
                3,2,1

            };
            Solution solution = new Solution();
            var x = solution.orderNumbersBySeclectionSort(numbers);

            Assert.Equal(x, new int[] { 1,2,3 });
        }
    }
}
