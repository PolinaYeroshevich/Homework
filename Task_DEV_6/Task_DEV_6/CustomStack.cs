using System;

namespace CustomStack
{
    /// <summary>
    /// The class is an array-based stack 
    /// that works like "Last In First Out".
    /// </summary>
    public class CustomStack<T>
    {
        private const int INIT_LENGTH = 10;
        private const string INVALID_RANGE_ERROR_MESSAGE = "There are no elements on the stack.";

        private T[] elements;
        public int capacity
        {
            get
            {
                return elements.Length;
            }
        }
        public int count { get; private set; }

        /// <summary>
        /// The constructor allocates memory for 10 elements.
        /// </summary>
        public CustomStack()
        {
            elements = new T[INIT_LENGTH];
        }

        /// <summary>
        /// The constructor allocates memory for the stack specified in the variable length.
        /// </summary>
        /// <param name="length">Stack length.</param>
        public CustomStack(int length)
        {
            elements = new T[length];
        }

        /// <summary>
        /// The method checks if the array is empty or not.
        /// </summary>
        /// <returns>Returns true if the count is empty,
        /// false if there are elements in the count.</returns>
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
        /// /// <exception cref="IndexOutOfRangeException">Throws an exception if the stack is empty.</exception>
        /// <returns> Returns the element from the top of the stack.</returns>
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException(INVALID_RANGE_ERROR_MESSAGE);
            }
            else if (count <= elements.Length / 2.0 && count > 0)
            {
                Resize(elements.Length / 2);
            }
            return elements[--count];
        }

        /// <summary>
        /// The method adds a new element to the stack.
        /// </summary>
        /// <param name="element">The element added to the stack.</param>
        public void Push(T element)
        {
            if (count == elements.Length)
            {
                Resize(elements.Length * 2);
            }
            elements[count++] = element;
        }

        /// <summary>
        /// The method dynamically resizes the stack.
        /// </summary>
        /// <param name="size">New stack size.</param>
        private void Resize(int size)
        {
            T[] newArray = new T[size];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = elements[i];
            }
            elements = newArray;
        }
    }
}
