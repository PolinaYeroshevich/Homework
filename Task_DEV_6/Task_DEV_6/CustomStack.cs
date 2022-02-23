using System;

namespace Task_DEV_6
{
    class CustomStack
    {
        public int[] numbers;
        public int count;

        public CustomStack()
        {
            numbers = new int[10];
        }

        public CustomStack(int capacity)
        {
            numbers = new int[capacity];
        }

        public int Capasity()
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
            else
            {
                return false;
            }
        }

        public int Push(int number)
        {
            if (count == numbers.Length)
            {
                Array.Resize(ref numbers, numbers.Length + numbers.Length);
            }
            return numbers[count++] = number;
        }

        public int Pop()
        {
            if (count == numbers.Length / 2)
            {
                Array.Resize(ref numbers, numbers.Length / 2);
            }
            return numbers[--count];
        }
    }
}
