using System;

namespace Task_DEV_6
{
    class CustomStack
    {
        private const int LENGTH = 10;
        private const string EXCEPTION_MESSAGE = "There are no elements on the stack.";

        private int[] elements;
        private int count;

        public CustomStack()
        {
            elements = new int[LENGTH];
        }

        public CustomStack(int capacity)
        {
            elements = new int[capacity];
        }

        public int Capacity()
        {
            return elements.Length;
        }

        public int Count()
        {
            return count;
        }

        public bool isEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            return false;
        }

        public int Pop()
        {
            ThrowExeption();
            if (count == elements.Length / 2.0)
            {
                int size = elements.Length / 2;
                int[] newNumbers = new int[size];
                for (int i = 0; i < elements.Length; i++)
                {
                    newNumbers[i] = elements[i];
                }
                elements = newNumbers;
            }
            return elements[--count];
        }

        public void Push(int element)
        {
            if (count == elements.Length)
            {
                int size = elements.Length + elements.Length;
                int[] newElements = new int[size];
                for (int i = 0; i < elements.Length; i++)
                {
                    newElements[i] = elements[i];
                }
                elements = newElements;
            }
            elements[count++] = element;
        }

        private void ThrowExeption()
        {
            if (count == 0)
            {
                throw new IndexOutOfRangeException(EXCEPTION_MESSAGE);
            }
        }
    }
}
