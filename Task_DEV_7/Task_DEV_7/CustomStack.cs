using System;

namespace Task_DEV_7
{
        public class CustomStack
    {
        /// <summary>
        /// The class is an array-based stack 
        /// that works like "Last In First Out".
        /// </summary>
        private const int INIT_LENGTH = 10;
        private const string INVALID_RANGE_ERROR_MESSAGE = "There are no elements on the stack.";

        private int[] elements;
        private int count;
        
        public CustomStack()
        {
            elements = new int[INIT_LENGTH];
        }

        public CustomStack(int length)
        {
            elements = new int[length];
        }

        /// <summary>
        /// The method returns the current stack capacity.
        /// </summary>
        /// /// <returns>Returns a array length.</returns>
        public int Capacity()
        {
            return elements.Length;
        }

        /// <summary>
        /// The method returns the actual number of elements on the stack.
        /// </summary>
        /// <returns>Returns a count.</returns>
        public int Count()
        {
            return count;
        }

        /// <summary>
        /// The method checks if the array is empty or not.
        /// </summary>
        /// <returns>Returns True or False.</returns>
        public bool IsEmpty()
        {
            if (count != 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// The method retrieves an element from the top, 
        /// if there are no elements, throw an exception.
        /// </summary>
        /// <returns> Returns the element from the top of the stack.</returns>
        public int Pop()
        {
            if (count == 0)
            {
                throw new IndexOutOfRangeException(INVALID_RANGE_ERROR_MESSAGE);
            }
            else if (count <= elements.Length / 2.0)
            {
                Resize(elements.Length / 2);
            }
            return elements[--count];
        }

        /// <summary>
        /// The method adds a new element to the stack.
        /// </summary>
        /// <param name="element">The element added to the stack.</param>
        public void Push(int element)
        {
            if (count == elements.Length)
            {
                Resize(elements.Length * 2);
            }
            elements[count++] = element;
        }

        /// <summary>
        /// Method that creates a new array and copies the old one into it.
        /// </summary>
        /// <param name="size">New array size.</param>
        private void Resize(int size)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < elements.Length; i++)
            {
                newArray[i] = elements[i];
            }
            elements = newArray;
        }
    }
}
