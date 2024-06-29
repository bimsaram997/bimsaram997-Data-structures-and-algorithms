using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVersion
{
    public class CustomStack
    {
        public static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        public CustomStack() {
            top = -1;
        }
        bool IsEmpty()
        {
            return top < 0;
        }

        public bool Push (int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine(" Stack over flow");
                return false;
            }else
            {
                stack[++top] = data;
                return true;
            }
        }

        public int Pop () { 
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            } else
            {
                int value = stack[top--];
                return value;
            }
        }

        public void Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }else
            {
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
            }
        }

        public void PrintStack()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            } else
            {
                Console.WriteLine("Items in the stack: ");
                for(int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
