using CSharpVersion;
using System;

class Program
{
    static void Main(string[] args)
    {
        //In build collections
        /* Stack<string > stack = new Stack<string>();
          stack.Push("a");
          stack.Push("b");
          stack.Push("c");
          stack.Push("d"); 
          stack.Push("e");
          stack.Push("f");
          stack.Push("g");

          //pop

          stack.Pop();   
          stack.Contains("a");
          foreach(var item in stack)
          {
              Console.WriteLine(item + ",");
          }*/

        CustomStack customStack= new CustomStack();
        customStack.Push(10);
        customStack.Push(20);
        customStack.Push(30);
        customStack.Push(40);
        customStack.Push(50);

        customStack.PrintStack();
        customStack.Peek();
        Console.WriteLine("Item popped from Stack : {0}", customStack.Pop());
        customStack.PrintStack();


    }
}