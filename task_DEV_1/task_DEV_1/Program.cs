using System;

namespace task_DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number :");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter A Number :");
            int secondInputNumber = int.Parse(Console.ReadLine());

            for (; inputNumber <= secondInputNumber; inputNumber++)
            {
                if (inputNumber % 2 == 0 && inputNumber % 5 == 0)
                {
                    Console.WriteLine("Tutti-Frutti");
                }

                else if (inputNumber % 2 == 0)

                {
                    Console.WriteLine("Tutti");
                }

                else if (inputNumber % 5 == 0)
                {
                    Console.WriteLine("Frutti");
                }

                else
                {                    
                    Console.WriteLine($"Number {inputNumber} can't be divided on 2 or 5");
                }
            }
        }
    }
}
