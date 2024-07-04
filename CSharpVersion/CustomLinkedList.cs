using NPOI.POIFS.Crypt.Dsig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVersion
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data) {
        this.data = data;
        this.next =  null;
        }
    }
    public class CustomLinkedList
    {
        Node head;
        Node tail;
        public CustomLinkedList() {
            this.tail = null;
            this.head = null;
        }
        public void addNode(int data)
        {
            Node node = new Node(data);
            if(head== null)
            {
                head = node;
            }else
            {
                tail.next = node;
            }
            tail = node;
        }
    
        public void printLinkedList()
        {
            var current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current= current.next;
            }
        } 
        public int get(int index)
        {
            var current = head;
            var i = 0;
            while (i < index)
            {
                current = current.next;
                i++;
            }
            return current.data;
        }

        public void insertAt(int index, int data)
        {
            if(index == 0)
            {
                Node node = new Node(data);
                node.next = head;
                head = node;
            }else
            {
                Node current = head;
                Node previous = null;
                var i = 0;
                while (i < index)
                {
                    previous = current;
                    current = current.next;
                    i++;
                }
                Node node = new Node(data);
                node.next = current;
                previous.next = node;

            }
        }

        public int removeFrom(int index)
        {
            if (head == null) // Check if the list is empty
            {
                throw new InvalidOperationException("The list is empty.");
            }

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index cannot be negative.");
            }

            if (index == 0) // Remove the head node
            {
                Node node = head;
                head = head.next;
                if (head == null) // If the list is now empty, update tail to null
                {
                    tail = null;
                }
                return node.data;
            }
            else
            {
                Node current = head;
                Node previous = null;
                var i = 0;
                while (i < index && current != null)
                {
                    previous = current;
                    current = current.next;
                    i++;
                }

                if (current == null) // Check if index is out of bounds
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                }

                previous.next = current.next;
                if (current.next == null) // If the removed node was the tail, update tail
                {
                    tail = previous;
                }

                return current.data;
            }
        }
    }
}
