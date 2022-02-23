using System;

namespace Task_DEV_6
{
    class StackArray
    {
        private const int LENGTH = 10;
        private const string EXCEPTION_MESSAGE = "There are no elements on the stack.";

        private int[] numbers;
        private int count;

        public StackArray()
        {
            numbers = new int[LENGTH];
        }

        public StackArray(int capacity)
        {
            numbers = new int[capacity];
        }

        public int Capacity()
        {
            return numbers.Length;
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

        public void Push(int item)
        {
            if (count == numbers.Length)
            {
                int size = numbers.Length + numbers.Length;
                int[] newNumbers = new int[size];
                for (int i = 0; i < numbers.Length; i++)
                {
                    newNumbers[i] = numbers[i];
                }
                numbers = newNumbers;
            }
            numbers[count++] = item;
        }

        public int Pop()
        {
            if (count == numbers.Length / 2.0)
            {
                int size = numbers.Length / 2;
                int[] newNumbers = new int[size];
                for (int i = 0; i < numbers.Length; i++)
                {
                    newNumbers[i] = numbers[i];
                }
                numbers = newNumbers;
            }
            else if (count == 0)
            {
                throw new IndexOutOfRangeException(EXCEPTION_MESSAGE);
            }
            return numbers[--count];
        }
    }
}
