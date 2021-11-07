using System;

namespace Task_DEV_2
{
    class Program
    {
        static int[] CreateNumbersArray(int arrayLength)
        {
            int[] inputNumbers = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Enter an array element № {i}");
                inputNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return inputNumbers;
        }

        static int[] SwapMinMaxElements(int[] inputNumbers, int arrayLength)
        {
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
            }
            inputNumbers[indexMin] = max;
            inputNumbers[indexMax] = min;

            return inputNumbers;
        }

        static void PrintNumberArraryToConsole(int[] inputNumbers, int arrayLength)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(inputNumbers[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            if (arrayLength <= 20)
            {
                int[] inputNumbers = CreateNumbersArray(arrayLength);
                PrintNumberArraryToConsole(inputNumbers, arrayLength);
                inputNumbers = SwapMinMaxElements(inputNumbers, arrayLength);
                PrintNumberArraryToConsole(inputNumbers, arrayLength);
            }
            else
            {
                Console.WriteLine("Array cannot be > 20");
            }
        }
    }
}
