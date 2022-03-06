using System;

namespace Task_DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                CustomStack<int> customStack = new CustomStack<int>();
                int capacity = customStack.Capacity();
                int count = customStack.Count();
                customStack.Push(1);
                customStack.Push(7);
                customStack.Push(8);
                capacity = customStack.Capacity();
                count = customStack.Count();
                int number = customStack.Pop();
                count = customStack.Count();

                CustomStack<string> custom = new CustomStack<string>();
                capacity = custom.Capacity();
                count = custom.Count();
                custom.Push("abc");
                custom.Push("cbe");
                custom.Push("bcd");
                capacity = custom.Capacity();
                count = custom.Count();
                string line = custom.Pop(); ;
                capacity = custom.Capacity();
                count = custom.Count();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
