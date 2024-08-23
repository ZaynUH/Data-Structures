using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessed_Exersise_1___2
{
    internal class IntegerStack
    {
        // Variables for stack
        private const int maxsize = 10; // max size of stack
        private int top = 0; // curretn top of stack value
        private int[] array = new int[maxsize]; // stores values of Stack

        private int[] inOrderArray = new int[maxsize]; // stores values of Stack (doesnt not change when ordered)

        public void Push(int value)
        {
            // Inserts a value to top of Stack and increases value of top of Stack pointer
            array[top++] = value;
        }

        public int Pop()
        {
            // Removes top value off Stack and lowers value of the top of Stack pointer
            return array[--top];
        }

        public void push(int value)
        {
            // Inserts a value to top of Stack (for In-Order)
            inOrderArray[top] = value;
        }

        public int pop()
        {
            // Removes top off stack (for In-Order)
            return inOrderArray[top];
        }

        public int Peek()
        {
            // Returns top of Stack
            return array[top - 1];
        }

        public bool IsEmpty()
        {
            // Checks if Stack is Empty
            return top == 0;
        }

        public bool IsFull()
        {
            // Checks if Stack is Full
            return top == maxsize;
        }

        public int Count()
        {
            // Returns Stacks current Size
            return top;
        }

        public string Convert()
        {
            // Outputs contents of Stack into a string seperated by a comma
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < top; i++)
            {
                output.Append(array[i] + Environment.NewLine);
            }
            return output.ToString();
        }

        public void SortAscending(IntegerStack stack)
        {
            // Create a temporary stack to hold sorted elements
            IntegerStack temp = new IntegerStack();

            while (!stack.IsEmpty())
            {
                // Pop an element from the original stack
                int curr = stack.Pop();

                // Pop elements from the temporary stack and push them back onto the original stack
                while (!temp.IsEmpty() && temp.Peek() > curr)
                {
                    stack.Push(temp.Pop());
                }

                // Push the current element onto the temporary stack
                temp.Push(curr);
            }

            // Copy the sorted elements back onto the original stack
            while (!temp.IsEmpty())
            {
                stack.Push(temp.Pop());
            }
        }

        public void SortDescending(IntegerStack stack)
        {
            // Create a temporary stack to hold sorted elements
            IntegerStack temp = new IntegerStack();

            while (!stack.IsEmpty())
            {
                // Pop an element from the original stack
                int curr = stack.Pop();

                // Pop elements from the temporary stack and push them back onto the original stack
                while (!temp.IsEmpty() && temp.Peek() < curr)
                {
                    stack.Push(temp.Pop());
                }

                // Push the current element onto the temporary stack
                temp.Push(curr);
            }

            // Copy the sorted elements back onto the original stack
            while (!temp.IsEmpty())
            {
                stack.Push(temp.Pop());
            }
        }

        public void SortInOrder(IntegerStack stack)
        {
            // Outputs the array that stores the In-Order list of Stack Values
            int tempTop = top ;
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }

            for (int i = 0; i < tempTop; i++)
            {
                stack.Push(inOrderArray[i]);
            }
        }
    }
}

