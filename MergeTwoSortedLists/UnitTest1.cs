using Xunit;

namespace MergeTwoSortedLists
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            ListNode list1 = new ListNode();
            ListNode list2 = new ListNode(0);
            var merge = solution.MergeTwoLists(list1, list2);
            Assert.Equal(0, merge.val);
        }
    }
}