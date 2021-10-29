using System;

namespace Task_DEV_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            if (arrayLength <= 5)
            {
                int[] inputNumbers = new int[arrayLength];

                for (int i = 0; i < arrayLength; i++)
                {
                    Console.WriteLine($"Enter an array element № {i}");
                    inputNumbers[i] = Convert.ToInt32(Console.ReadLine());

                    if (inputNumbers[i] < 0)
                    {
                        Console.WriteLine("This is negative number");
                        break;
                    }
                }
                bool isPrimeNumber = true;
                for (int i = 0; i < arrayLength; i++)
                {
                    if (inputNumbers[i] == 1 || inputNumbers[i] == 2)
                    {
                        Console.WriteLine($"{inputNumbers[i]} is prime number");
                    }
                    for (int j = 2; j < inputNumbers[i]; j++)
                    {
                        if (inputNumbers[i] % j == 0)
                        {
                            isPrimeNumber = false;

                            Console.WriteLine($"{inputNumbers[i]} is not prime number");
                        }
                        else
                        {
                            Console.WriteLine($"{inputNumbers[i]} is prime number");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Array has exceeded the allowed value");
            }
        }
    }
}
