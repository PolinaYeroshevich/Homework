using System;
using System.Text;
using System.IO;

namespace task_DEV_5
{
    class BubbleSorter
    {
        private string path;
        private FileStream fstream;

        public BubbleSorter(string path)
        {
            this.path = path;
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
                        else
                        {
                            firstString = secondString;
                        }
                    }
                }
                while (needSorting);
            }
        }

        private string ReadLine()
        {
            StringBuilder builder = new StringBuilder();
            char symbol;
            while ((symbol = (char)fstream.ReadByte()) != '\n' && fstream.Length != fstream.Position)
            {
                builder.Append(symbol);
            }
            return builder.ToString();
        }

        private void WriteSortedRows(string firstString, string secondString)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(secondString);
            stringBuilder.Append('\n');
            stringBuilder.Append(firstString);
            stringBuilder.Append('\n');
            byte[] linesByte = Encoding.Default.GetBytes(stringBuilder.ToString()) ;
            fstream.Seek(-(linesByte.Length), SeekOrigin.Current);
            fstream.Write(linesByte, 0, linesByte.Length);
        }
    }
}
