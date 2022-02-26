using System;

namespace Task_DEV_6
{
    class CustomStack
    {
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

        public int Capacity()
        {
            return elements.Length;
        }

        public int Count()
        {
            return count;
        }

        public bool IsEmpty()
        {
            if (count != 0)
            {
                return false;
            }
            return true;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException(INVALID_RANGE_ERROR_MESSAGE);
            }
            else if (count <= elements.Length / 2.0)
            {
                Resize(elements.Length / 2);
            }
            return elements[--count];
        }

        public void Push(int element)
        {
            if (count == elements.Length)
            {
                Resize(elements.Length * 2);
            }
            elements[count++] = element;
        }


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
