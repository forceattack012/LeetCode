using System;
using Xunit;

namespace LengthofLastWord
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            var result = solution.LengthOfLastWord("   fly me   to   the moon  ");
            result = solution.LengthOfLastWordWithTrim("   fly me   to   the moon  ");

            Assert.Equal(4, result);
        }
    }
}
