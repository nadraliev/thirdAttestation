using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filesLibrary
{
    public class FileStrings
    {
        string path;

        public FileStrings(string path)
        {
            this.path = path;
        }

        public void deleteString(int stringNumber)
        {
            List<string> strings = new List<string>(File.ReadAllLines(path));
            if (stringNumber < strings.Count && stringNumber >= 0)
            {
                strings.RemoveAt(stringNumber);
                File.WriteAllLines(path, strings);
            }
        }
    }
}
