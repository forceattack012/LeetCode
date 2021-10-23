using System;
using Xunit;

namespace LinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtTail(10);
            myLinkedList.AddAtHead(5);
            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtHead(3);
            myLinkedList.AddAtTail(6);
            myLinkedList.AddAtTail(7);
            var index20 = myLinkedList.Get(20);
            myLinkedList.AddAtHead(1);

            //1 3 4 5 10 6 7 

            myLinkedList.DeleteAtIndex(3);  // 1 3 4 10 6 7
            myLinkedList.AddAtIndex(1, 2);  // 1 2 3 4 10 6 7

            var two = myLinkedList.Get(1);  //3 4 5 10 6 
            Assert.Equal(2, two);
            Assert.Equal(-1, index20);


            myLinkedList.AddAtHead(4);


        }
    }
}
