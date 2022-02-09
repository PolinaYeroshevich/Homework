using System;
using System.Text;
using System.IO;

namespace task_DEV_5
{
    class BetteGenerator
    {
        private const int MIN_LINE_LENGTH = 1;
        private const int MAX_LINE_LENGTH = 101;

        private string path;
        private int stringAmount;

        public BetteGenerator(string path, int stringAmount)
        {
            this.path = path;
            this.stringAmount = stringAmount;
        }

        private void CheckNumbersOfRows()
        {
            if (stringAmount < 0)
            {
                throw new ArgumentOutOfRangeException("Number of rows cannot be less then 0");
            }
        }

        private string GenerateLine()
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            int length = random.Next(MIN_LINE_LENGTH, MAX_LINE_LENGTH);
            for (int i = 0; i < length; i++)
            {
                char symbol = (char)random.Next(97, 123);
                sb.Append(symbol);
            }
            return sb.ToString();
        }

        public void GenerateText()
        {
            CheckNumbersOfRows();
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < stringAmount; i++)
                {
                    sw.WriteLine(GenerateLine());
                }
            }
        }
    }
}
