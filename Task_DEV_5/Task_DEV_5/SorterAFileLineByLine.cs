using System;
using System.Text;
using System.IO;

namespace task_DEV_5
{
    class SorterAFileLineByLine
    {
        private string path;
        public FileStream fstream;

        public SorterAFileLineByLine(string path)
        {
            this.path = path;
        }

        private void ChangeValues(string firstString, string secondString)
        {
            var temp = firstString;
            firstString = secondString;
            secondString = temp;
        }

        private string ReadLine()
        {
            StringBuilder builder = new StringBuilder();
            char symbol;
            while ((symbol = (char)fstream.ReadByte()) != '\n' || fstream.Length == fstream.Position)
            {
                builder.Append(symbol);
            }
            return builder.ToString();
        }

        public void Sort()
        {
            using (fstream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                bool sort = true;
                do
                {
                    fstream.Seek(0, SeekOrigin.Begin);
                    string firstString = ReadLine();
                    sort = false;
                    while (fstream.Length != fstream.Position)
                    {
                        string secondString = ReadLine();
                        if (String.Compare(firstString, secondString) > 0)
                        {
                            ChangeValues(firstString, secondString);
                            sort = true;
                            WriteSortText(firstString, secondString);
                            firstString = secondString;
                        }
                        else
                        {
                            firstString = secondString;
                        }
                    }
                }
                while (sort);
            }
        }

        private void WriteSortText(string firstString, string secondString)
        {
            byte[] arrayFirst = Encoding.Default.GetBytes(firstString + '\n');
            byte[] arraySecond = Encoding.Default.GetBytes(secondString + '\n');
            fstream.Seek(-(arrayFirst.Length + arraySecond.Length), SeekOrigin.Current);
            fstream.Write(arrayFirst, 0, arrayFirst.Length);
            fstream.Write(arraySecond, 0, arraySecond.Length);
        }
    }
}
