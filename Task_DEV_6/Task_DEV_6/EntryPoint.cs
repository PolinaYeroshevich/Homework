using System;

namespace Task_DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                CustomStack customStack = new CustomStack();
                int capacity = customStack.Capacity();
                int count = customStack.Count();
                customStack.Push(1);
                customStack.Push(7);
                customStack.Push(8);
                customStack.Push(1);
                customStack.Push(7);
                customStack.Push(8);
                customStack.Push(1);
                customStack.Push(7);
                customStack.Push(8);
                customStack.Push(1);
                customStack.Push(7);
                customStack.Push(8);
                bool isEmpty = customStack.isEmpty();
                count = customStack.Count();
                int number = customStack.Pop();
                number = customStack.Pop();
                number = customStack.Pop();
                count = customStack.Count();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
