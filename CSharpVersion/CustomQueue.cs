using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVersion
{
    public class CustomQueue
    {
        public static readonly int MAX = 6;
        private int frontIndex;
        private int backIndex;
        int[] queue = new int[MAX];
        public CustomQueue() {
            frontIndex = 0;
            backIndex = 0;
        }

       public void enqueue(int data)
        {
            if (backIndex > MAX)
            {
                Console.WriteLine(" Queue over flow");
            }
            else {
                queue[backIndex] = data;
                backIndex++;
                Console.WriteLine(data + " Inserted");
            }
        }
        public void dequeue()
        {
            if (frontIndex == backIndex)
            {
                Console.WriteLine("Queue underflow");
            }
            else
            {
                int data = queue[frontIndex];
                frontIndex++;
                Console.WriteLine(data + " Removed");

  
                if (frontIndex == backIndex)
                {
                    frontIndex = 0;
                    backIndex = 0;
                }
            }
            
        }

        public int peek()
        {
            if(frontIndex ==  backIndex)
            {
                throw new InvalidOperationException("Queue is underflow");
            } else
            {
                return queue[frontIndex];
            }
        }

        public void printQueue()
        {
            if (frontIndex == backIndex)
            {
                Console.WriteLine("Queue is underflow");
            } else
            {
                for(int i=frontIndex; i< backIndex; i++)
                {
                    Console.Write(queue[i] + " ");
                }
            }
            Console.WriteLine();
        }
        public bool isEmpty()
        {
            return frontIndex == backIndex;
        }
    }
}
