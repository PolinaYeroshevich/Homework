using System;
using System.Text;
using System.IO;

namespace task_DEV_5
{
    class SecondTextSort
    {
        private string path { get; set; }
        public FileStream fstream;

        public SecondTextSort(string path)
        {
            this.path = path;
        }

        public string ReadLine()
        {
            StringBuilder builder = new StringBuilder();
            char symbol;
            while ((symbol = (char)fstream.ReadByte()) != '\n')
            {
                if (fstream.Length == fstream.Position)
                {
                    break;
                }

                builder.Append(symbol);
            }
            return builder.ToString();
        }

        public void SortText()
        {
            using (fstream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                bool sorting = true;
                do
                {
                    fstream.Seek(0, SeekOrigin.Begin);
                    string firstString = ReadLine();
                    sorting = false;
                    while (fstream.Length != fstream.Position)
                    {
                        string secondString = ReadLine();
                        if (String.Compare(firstString, secondString) > 0)
                        {
                            var temp = firstString;
                            firstString = secondString;
                            secondString = temp;
                            sorting = true;
                            WriteSortText(firstString, secondString);
                            firstString = secondString;
                        }
                        else
                        {
                            firstString = secondString;
                        }
                    }
                }
                while (sorting);
            }
        }

        public void WriteSortText(string firstString, string secondString)
        {
            byte[] array = Encoding.Default.GetBytes(firstString + '\n');
            byte[] arraySecond = Encoding.Default.GetBytes(secondString + '\n');
            fstream.Seek(-(array.Length + arraySecond.Length), SeekOrigin.Current);
            fstream.Write(array, 0, array.Length);
            fstream.Write(arraySecond, 0, arraySecond.Length);
        }
    }
}
