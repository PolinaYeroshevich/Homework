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
                int capasity = customStack.Capasity();
                int count = customStack.Count();
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
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("There are no elements on the stack.");
            }
        }
    }
}
