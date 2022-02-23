using System;

namespace Task_DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                StackArray stackArray = new StackArray();
                int capacity = stackArray.Capacity();
                int count = stackArray.Count();
                stackArray.Push(1);
                stackArray.Push(7);
                stackArray.Push(8);
                stackArray.Push(1);
                stackArray.Push(7);
                stackArray.Push(8);
                stackArray.Push(1);
                stackArray.Push(7);
                stackArray.Push(8);
                stackArray.Push(1);
                stackArray.Push(7);
                stackArray.Push(8);
                bool isEmpty = stackArray.isEmpty();
                count = stackArray.Count();
                int number = stackArray.Pop();
                number = stackArray.Pop();
                number = stackArray.Pop();
                count = stackArray.Count();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
