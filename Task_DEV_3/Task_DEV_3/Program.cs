using System;

namespace Task_DEV_3
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

        static bool CheckNumberForPrime(int number)
        {
            bool isPrimeNumber = true;
            for (int j = 2; j < number; j++)
            {
                if (number % j == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
            }
            return isPrimeNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            if (arrayLength <= 5)
            {
                int[] inputNumbers = CreateNumbersArray(arrayLength);
                for (int i = 0; i < arrayLength; i++)
                {
                    if (CheckNumberForPrime(inputNumbers[i]))
                    { 
                        Console.WriteLine($"{inputNumbers[i]} is prime number");
                    }
                    else
                    {
                        Console.WriteLine($"{inputNumbers[i]} is not prime number");
                    }
                }
            }
            else
            {
                Console.WriteLine("Array length cannot exceed 5");
            }
        }
    }
}
