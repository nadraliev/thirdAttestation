using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RecursionLibrary
{
    public class CommasInFile
    {
        string path;

        public CommasInFile(string path)
        {
            this.path = path;
        }

        public int countCommas(string input)
        {
            return (input != String.Empty) ? ((input[input.Length - 1] == ',') ? 1 : 0)
                + countCommas(input.Substring(0, input.Length - 1)) : 0;
        }

        public string makeOneString()
        {
            string result = String.Empty;
            string[] strings = File.ReadAllLines(path);
            foreach (string temp in strings)
            {
                result += temp;
            }
            return result;
        }
    }
}
