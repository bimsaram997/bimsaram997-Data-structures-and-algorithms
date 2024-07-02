
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVersion
{
    public class CustomPriorityQueue<T>
    {
        private List<(T item, int priority)> elements = new List<(T item, int priority)>();
        
        public void Enqueue(T item, int priority)
        {
          elements.Add((item, priority));
            elements = elements.OrderBy(e => e.priority).ToList();
        }

        public void Dequeue()
        {
            if(!IsEmpty())
            {
                var item = elements[0];
                elements.RemoveAt(0);
                Console.WriteLine(item.item); 
            } else
            {
                Console.WriteLine("Queue underflow");
            }
        }
        public T Peek ()
        {
            if (!IsEmpty())
            {
                var item = elements[0].item;
                return item;
               
            }
            else
            {
                throw new InvalidOperationException("Queue is underflow");
            }
        }
        public T Rear()
        {
            if (!IsEmpty())
            {
                var item = elements[elements.Count-1].item;
                return item;

            }
            else
            {
                throw new InvalidOperationException("Queue is underflow");
            }
        }
        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is underflow");
            }
            else
            {
                foreach (var element in elements)
                {
                    Console.WriteLine($"Item: {element.item}, Priority: {element.priority}");
                }
            }
            Console.WriteLine();
        }
        public bool IsEmpty()
        {
            return elements.Count == 0;
        }
    }
}
