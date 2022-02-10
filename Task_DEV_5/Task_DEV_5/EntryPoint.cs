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
                string fileName = args[0];
                int numberOfLines = int.Parse(args[1]);

                FileGenerator fileGeneration = new FileGenerator(Path.GetFullPath(@"..\\..\\" + fileName), numberOfLines);
                fileGeneration.Generate();

                SorterStringArray firstTextSorter = new SorterStringArray(Path.GetFullPath(@"..\\..\\" + fileName));
                firstTextSorter.Sort();

                SorterStringsCharacterByCharacter secondTextSort = new SorterStringsCharacterByCharacter(Path.GetFullPath(@"..\\..\\" + fileName));
                secondTextSort.Sort();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file path is not valid");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Command line arguments not specified.");
            }
        }
    }
}
