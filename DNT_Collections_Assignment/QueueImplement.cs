using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Collections_Assignment
{
    internal class QueueImplement
    {
       public static void Main()
       {
            Queue que = new Queue();
            
            que.Enqueue("Pankaj");
            que.Enqueue(1);
            que.Enqueue(10.5);
            que.Enqueue(true);
            que.Enqueue('A');

            Console.WriteLine("Count : {0}", que.Count);
            Console.WriteLine();

            Console.WriteLine("Element in Queue : ");
            

            foreach (object obj in que)
            Console.WriteLine(obj);
            Console.WriteLine();

            Console.WriteLine("End element of Queue : {0}", que.Peek());
            Console.WriteLine();

            object TopElement = que.Dequeue();
            Console.WriteLine("Removing End element of Queue = {0}\nNow End element of Queue = {1}\n", TopElement, que.Peek());
            if (que.Contains("Pankaj")) Console.WriteLine("Pankaj Found");
            else Console.WriteLine("Pankaj Not found");

            Object[] ob = que.ToArray();
            Console.WriteLine();
            foreach (object obj in ob)
            Console.WriteLine(obj);
            que.TrimToSize();
            que.Clear();
            Console.WriteLine();
            Console.WriteLine("Count : {0}", que.Count);
            
            Console.ReadLine();
        }       
    }
}
