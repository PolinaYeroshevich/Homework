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

                FileGenerator fileGenerator = new FileGenerator(Path.GetFullPath(@"..\\..\\" + fileName), numberOfLines);
                fileGenerator.Generate();

                SorterArraySort sorterArraySort = new SorterArraySort(Path.GetFullPath(@"..\\..\\" + fileName));
                sorterArraySort.Sort();

                SorterWithFileStream sorterWithFileStream = new SorterWithFileStream(Path.GetFullPath(@"..\\..\\" + fileName));
                sorterWithFileStream.Sort();
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
