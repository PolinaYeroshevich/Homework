using System;
using System.IO;

namespace task_DEV_5
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            //FirstTextSorter firstTextSorter = new FirstTextSorter(@"D:\Text.txt", @"D:\Text.txt");
            //firstTextSorter.ReadText();
            //firstTextSorter.SortText();
            //firstTextSorter.WriteText();

            SecondTextSort secondTextSort = new SecondTextSort(@"D:\Text.txt", @"D:\Text.txt");
            secondTextSort.ReadText();
            secondTextSort.WriteText();
        }
    }
}
