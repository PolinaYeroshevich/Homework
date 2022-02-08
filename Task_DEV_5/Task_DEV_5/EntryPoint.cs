using System;
using System.IO;
namespace task_DEV_5
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            int number = int.Parse(args[1]);
            try
            {
                try
                {
                    FileGeneration fileGeneration = new FileGeneration(Path.GetFullPath(@"..\\..\\" + fileName), number);
                    fileGeneration.WriteText();
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                FirstTextSorter firstTextSorter = new FirstTextSorter(Path.GetFullPath(@"..\\..\\" + fileName));
                firstTextSorter.SortText();

                SecondTextSort secondTextSort = new SecondTextSort(Path.GetFullPath(@"..\\..\\" + fileName));
                secondTextSort.SortText();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path is not valid");
            }
        }
    }
}
