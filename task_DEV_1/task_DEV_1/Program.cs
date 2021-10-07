using System;

namespace task_DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstInputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondInputNumber = int.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;

            if (firstInputNumber < secondInputNumber)
            {
                min = firstInputNumber;
                max = secondInputNumber;
            }
            else if (firstInputNumber > secondInputNumber)
            {
                min = secondInputNumber;
                max = firstInputNumber;
            }

            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Tutti-Frutti");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Tutti");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Frutti");
                }
                else
                {
                    Console.WriteLine($"Number {i} can't be divided on 2 or 5");
                }
            }
        }
    }
}
