using System;

namespace Algortihms_And_Data_structure
{
    public class Stack
    {
        const int MAX = 100;

        int top;
        string[] stack = new string[MAX];
        public Stack()
        {
            top = -1;
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }


        public void Push(string newdata)
        {
            if (top >= MAX - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                top++;
                stack[top] = newdata;
            }
        }

        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                string value = stack[top--];
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
        public PrintStack()
        {
            if (top < 0)
            {
                return Console.WriteLine("Stack Underflow");
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    return Console.WriteLine(stack[i]);
                }
            }
        }

    }
}