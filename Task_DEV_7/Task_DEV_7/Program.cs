using System;

namespace Task_DEV_7
{
    class Program
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
                customStack.Push(7);
                customStack.Push(1);
                customStack.Push(7);
                customStack.Push(7);
                customStack.Push(1);
                customStack.Push(7);
                customStack.Push(7);
                customStack.Push(1);
                customStack.Push(1);

                count = customStack.Count();
                capacity = customStack.Capacity();
                int number = customStack.Pop();
                capacity = customStack.Capacity();


                bool isEmpty = customStack.IsEmpty();
                
                capacity = customStack.Capacity();
                
                count = customStack.Count();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
