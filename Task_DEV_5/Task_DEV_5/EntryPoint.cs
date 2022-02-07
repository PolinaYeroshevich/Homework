using System;
using System.IO;
namespace task_DEV_5
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the number of lines");
                    int number = int.Parse(Console.ReadLine());
                    FileGeneration fileGeneration = new FileGeneration(@"D:\git\Homework\Task_DEV_5\Text.txt", number);
                    fileGeneration.WriteText();
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                FirstTextSorter firstTextSorter = new FirstTextSorter(@"D:\git\Homework\Task_DEV_5\Text1.txt");
                firstTextSorter.SortText();

                SecondTextSort secondTextSort = new SecondTextSort(@"D:\git\Homework\Task_DEV_5\Text2.txt");
                secondTextSort.SortText();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path is not valid");
            }
        }
    }
}
