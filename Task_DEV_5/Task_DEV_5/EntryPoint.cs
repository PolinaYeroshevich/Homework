using System;
using System.IO;
namespace task_DEV_5
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            int numberOfLines = int.Parse(args[1]);
            try
            {

                BetteGenerator fileGeneration = new BetteGenerator(Path.GetFullPath(@"..\\..\\" + fileName), numberOfLines);
                fileGeneration.GenerateText();


                SorterArrayOfStrings firstTextSorter = new SorterArrayOfStrings(Path.GetFullPath(@"..\\..\\" + fileName));
                firstTextSorter.Sort();

                SorterAFileLineByLine secondTextSort = new SorterAFileLineByLine(Path.GetFullPath(@"..\\..\\" + fileName));
                secondTextSort.Sort();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path is not valid");
            }
        }
    }
}
