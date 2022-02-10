using System;
using System.Text;
using System.IO;

namespace task_DEV_5
{
    class SorterStringsCharacterByCharacter
    {
        private string path;
        public FileStream fstream;

        public SorterStringsCharacterByCharacter(string path)
        {
            this.path = path;
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
                bool sorts = true;
                do
                {
                    fstream.Seek(0, SeekOrigin.Begin);
                    string firstString = ReadLine();
                    sorts = false;
                    while (fstream.Length != fstream.Position)
                    {
                        string secondString = ReadLine();
                        if (String.Compare(firstString, secondString) > 0)
                        {
                            WriteSortText(firstString, secondString);
                            sorts = true;
                        }
                        firstString = secondString;
                    }
                }
                while (sorts);
            }
        }

        private void WriteSortText(string firstString, string secondString)
        {
            byte[] firstLine = Encoding.Default.GetBytes(firstString + '\n');
            byte[] secondLine = Encoding.Default.GetBytes(secondString + '\n');
            fstream.Seek(-(firstLine.Length + secondLine.Length), SeekOrigin.Current);
            fstream.Write(secondLine, 0, secondLine.Length);
            fstream.Write(firstLine, 0, firstLine.Length);
        }
    }
}
