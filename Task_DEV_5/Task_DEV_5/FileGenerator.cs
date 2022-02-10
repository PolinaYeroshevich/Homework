using System;
using System.Text;
using System.IO;

namespace task_DEV_5
{
    class FileGenerator
    {
        private const int MIN_LINE_LENGTH = 1;
        private const int MAX_LINE_LENGTH = 101;

        private string path;
        private int stringAmount;

        public FileGenerator(string path, int stringAmount)
        {
            this.path = path;
            this.stringAmount = stringAmount;
        }

        private void CheckNumberOfRows()
        {
            if (stringAmount < 0)
            {
                throw new ArgumentOutOfRangeException("Number of rows cannot be less then 0");
            }
        }

        private string GenerateLine()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            int length = random.Next(MIN_LINE_LENGTH, MAX_LINE_LENGTH);
            for (int i = 0; i < length; i++)
            {
                char symbol = (char)random.Next(97, 123);
                stringBuilder.Append(symbol);
            }
            return stringBuilder.ToString();
        }

        public void Generate()
        {
            CheckNumberOfRows();
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                for (int i = 0; i < stringAmount; i++)
                {
                    streamWriter.WriteLine(GenerateLine());
                }
            }
        }
    }
}
