using System;

namespace CustomStack
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                CustomStack<int> customStack = new CustomStack<int>();
                customStack.Push(1);
                customStack.Push(7);
                customStack.Push(8);
                int number = customStack.Pop();

                CustomStack<string> custom = new CustomStack<string>();
                custom.Push("abc");
                custom.Push("cbe");
                custom.Push("bcd");
                string line = custom.Pop(); ;

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
