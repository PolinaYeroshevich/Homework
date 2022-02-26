using System;

namespace Task_DEV_6
{
    class CustomStack
    {
        private const int INIT_LENGTH = 10;
        private const string INDEX_OUT_OF_RANGE_EXEPTION_MESSAGE = "There are no elements on the stack.";

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

        public bool isEmpty()
        {
            if (count != 0)
            {
                return false;
            }
            return true;
        }

        public int Pop()
        {
            if (count == 0)
            {
                throw new IndexOutOfRangeException(INDEX_OUT_OF_RANGE_EXEPTION_MESSAGE);
            }
            else if (count <= elements.Length / 2.0)
            {
                int size = elements.Length / 2;
                Resize(size);
            }
            return elements[--count];
        }

        public void Push(int element)
        {
            if (count == elements.Length)
            {
                int size = elements.Length + elements.Length;
                Resize(size);
            }
            elements[count++] = element;
        }


        private void Resize(int size)
        {
            int[] newNumbers = new int[size];
            for (int i = 0; i < elements.Length; i++)
            {
                newNumbers[i] = elements[i];
            }
            elements = newNumbers;
        }       
    }
}
