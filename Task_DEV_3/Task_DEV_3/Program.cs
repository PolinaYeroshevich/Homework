using System;

namespace Task_DEV_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            if (arrayLength <= 5)
            {
                int[] inputNumbers = new int[arrayLength];
                for (int i = 0; i < arrayLength; i++)
                {
                    Console.WriteLine($"Enter an array element № {i}");
                    inputNumbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                bool isPrimeNumber = true;
                for (int i = 0; i < arrayLength; i++)
                {
                    isPrimeNumber = true;
                    for (int j = 2; j < inputNumbers[i]; j++)
                    {
                        if (inputNumbers[i] % j == 0)
                        {
                            isPrimeNumber = false;
                            break;
                        }
                    }
                    if (isPrimeNumber)
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
                Console.WriteLine("Size array has exceeded the allowed value");
            }
        }
    }
}
