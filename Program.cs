using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Praveen");
            stack.Push("Vijay");
            stack.Push("Surya");
            stack.Push("Ajith");
            Console.WriteLine("The number of items are : "+stack.Count);
            stack.Pop();
            foreach(string items in stack)
                Console.WriteLine(items);
            Console.WriteLine("The Peek is " + stack.Peek()); 
            stack.Clear();
            Console.WriteLine("The number of items are : " + stack.Count);
            Console.ReadKey();
            Queue q = new Queue();
            q.Enqueue("Shyam");
            q.Enqueue("Sundar");
            q.Enqueue("Sanjay");
            Console.WriteLine("The number of items are : "+q.Count);
            q.Dequeue();
            foreach (string item in q)
                Console.WriteLine(item);
        }
    }
}
