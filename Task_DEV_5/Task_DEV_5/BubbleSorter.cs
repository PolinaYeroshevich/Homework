using System;
using System.Text;
using System.IO;

namespace task_DEV_5
{
    class BubbleSorter
    {
        private string path;
        public FileStream fstream;

        public BubbleSorter(string path)
        {
            this.path = path;
        }

        private string ReadLine()
        {
            StringBuilder builder = new StringBuilder();
            char symbol;
            while ((symbol = (char)fstream.ReadByte()) != '\n' || fstream.Length != fstream.Position)
            {
                builder.Append(symbol);
            }
            return builder.ToString();
        }

        public void Sort()
        {
            using (fstream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                bool needSorting = true;
                do
                {
                    fstream.Seek(0, SeekOrigin.Begin);
                    string firstString = ReadLine();
                    needSorting = false;
                    while (fstream.Length != fstream.Position)
                    {
                        string secondString = ReadLine();
                        if (String.Compare(firstString, secondString) > 0)
                        {
                            WriteSortedRows(firstString, secondString);
                            needSorting = true;
                        }
                        firstString = secondString;
                    }
                }
                while (needSorting);
            } 
        }

        private void WriteSortedRows(string firstString, string secondString)
        {
            byte[] firstLineByte = Encoding.Default.GetBytes(firstString + '\n');
            byte[] secondLineByte = Encoding.Default.GetBytes(secondString + '\n');
            fstream.Seek(-(firstLineByte.Length + secondLineByte.Length), SeekOrigin.Current);
            fstream.Write(secondLineByte, 0, secondLineByte.Length);
            fstream.Write(firstLineByte, 0, firstLineByte.Length);
        }
    }
}
