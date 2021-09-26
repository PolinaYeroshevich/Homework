using System;

namespace task_DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number :");
            int inputNumber = int.Parse(Console.ReadLine());

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
            else if (!(inputNumber % 2 == 0) && !(inputNumber % 5 == 0))

                Console.WriteLine("This number is not divisible by 2 and 5");
        }
    }
            
}        
      