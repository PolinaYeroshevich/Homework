using System;
using System.IO;

namespace task_DEV_5
{
    class FirstTextSorter
    {
        public string path;

        public FirstTextSorter(string path)
        {
            this.path = path;
        }

        public void SortText()
        {
            string[] contents = File.ReadAllLines(path);
            Array.Sort(contents);
            File.WriteAllLines(path, contents);
        }
    }
}
