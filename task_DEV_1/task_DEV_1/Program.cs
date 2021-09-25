using System;

namespace task_DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number :");
            int index = int.Parse(Console.ReadLine());
            if (index % 2 != 0 && index % 5 != 0 && (index % 2 != 0 || index % 5 != 0))
            { 
                return;
            }
            if (index % 2 == 0 && index % 5 == 0)
            {
                Console.WriteLine("Tutti-Frutti");
            }
            else if (index % 2 == 0)
            {
                Console.WriteLine("Tutti");
            }
            else if (index % 5 == 0)
            {
                Console.WriteLine("Frutti");
            }
        
        }
    }
            
        }
                
       

           
        

