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

        /*
                CustomStack Stack
                CustomStack customStack= new CustomStack();
                customStack.Push(10);
                customStack.Push(20);
                customStack.Push(30);
                customStack.Push(40);
                customStack.Push(50);

                customStack.PrintStack();
                customStack.Peek();
                Console.WriteLine("Item popped from Stack : {0}", customStack.Pop());
                customStack.PrintStack();*/

        /* Queue<int > queue = new Queue<int>();
         queue.Enqueue(1);
         queue.Enqueue(2);
         queue.Enqueue(3);
         queue.Enqueue(4);
         queue.Enqueue(5);
         queue.Dequeue();
         Console.WriteLine(queue.Contains(5));

         foreach(var item in queue)
         {
             Console.WriteLine(item + ", ");
         }*/

        CustomQueue queue = new CustomQueue();

        queue.enqueue(10);
        queue.enqueue(20);
        queue.enqueue(30);
        queue.enqueue(40);
        queue.enqueue(50);

        queue.printQueue();

        queue.dequeue();
        queue.printQueue();

        queue.enqueue(60);
        queue.printQueue();

        Console.WriteLine("Front item is: " + queue.peek());

        while (!queue.isEmpty())
        {
            queue.dequeue();
            queue.printQueue();
        }

        queue.dequeue();

    }
}