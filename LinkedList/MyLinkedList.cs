using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyLinkedList
    {
        object _value;
        MyLinkedList next;

        public MyLinkedList()
        {
            _value = null;
            next = null;
        }

        public MyLinkedList(int val)
        {
            _value = val;
            next = null;
        }

        public int Get(int index)
        {
            if(next == null)
            {
                return -1;
            }

            var node = getNodeByIndex(index);
            if(node == null)
            {
                return -1;
            }

            return (int)node._value;
        }

        private MyLinkedList getNodeByIndex(int index)
        {
            int count = 0;
            var currentNode = next;

            while (currentNode != null && count != index)
            {
                count++;
                currentNode = currentNode.next;
            }

            if (count != index)
            {
                return null;
            }

            return currentNode;
        }

        public void AddAtHead(int val)
        {
            MyLinkedList newNode = new MyLinkedList(val);
            if(next == null)
            {
                next = newNode;
                return;
            }
            newNode.next = next;
            next = newNode;
        }

        public void AddAtTail(int val)
        {
            MyLinkedList newNode = new MyLinkedList(val);
            if(next == null)
            {
                next = newNode;
                return;
            }

            var lastNode = getLastNode();
            lastNode.next = newNode;
        }

        private MyLinkedList getLastNode()
        {
            var lastNode = next;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }

            return lastNode;
        }

        public void AddAtIndex(int index, int val)
        {
            var node = getNodeByIndex(index);
            var prevNode = getPrevNodeByIndex(index);

            if (node == null || prevNode ==null)
            {
                return;
            }

            MyLinkedList newNode = new MyLinkedList(val);
            prevNode.next = newNode;
            newNode.next = node;
        }

        private MyLinkedList getPrevNodeByIndex(int index)
        {
            var tempNode = next;
            MyLinkedList prevNode = null;
            int count = 0;
            while(tempNode != null && index != count)
            {
                prevNode = tempNode;
                tempNode = tempNode.next;
                count++;
            }

            if(count!= index)
            {
                return null;
            }

            return prevNode;
        }

        public void DeleteAtIndex(int index)
        {
            var node = getNodeByIndex(index);
            MyLinkedList prevNode = getPrevNodeByIndex(index);
            if (node == null || prevNode == null)
            {
                return;
            }

            if (node._value != prevNode.next._value)
            {
                return;
            }
            prevNode.next = node.next;

        }
    }
}
