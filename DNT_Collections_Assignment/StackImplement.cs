using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Collections_Assignment
{
    internal class StackImplement
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public StackImplement()
        {
            top = -1;
        }
        public bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
        static void Main(string[] args)
        {        
            StackImplement stc = new StackImplement();

            stc.Push(10);
            stc.Push(20);
            stc.Push(30);
            stc.Push(40);
            stc.PrintStack();
            stc.Peek();
            Console.WriteLine("Item popped from Stack : {0}", stc.Pop());
            stc.PrintStack();
        }
    }
}
    
    


