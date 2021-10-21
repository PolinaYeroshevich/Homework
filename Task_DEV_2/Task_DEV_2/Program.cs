using System;

namespace Task_DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arrayLength;)
            {
                if (arrayLength > 20)

                    break;

                Console.WriteLine("Array cannot be <= 20");
            }
            int[] inputNumbers = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Enter an array element № {i}");
                inputNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = inputNumbers[0];
            int max = inputNumbers[0];
            int indexMin = 0;
            int indexMax = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                if (inputNumbers[i] < min)
                {
                    min = inputNumbers[i];
                    indexMin = i;
                }
                if (inputNumbers[i] > max)
                {
                    max = inputNumbers[i];
                    indexMax = i;
                }
                Console.WriteLine(inputNumbers[i]);
            }
            inputNumbers[indexMin] = max;
            inputNumbers[indexMax] = min;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(inputNumbers[i]);
            }
        }
    }
}
