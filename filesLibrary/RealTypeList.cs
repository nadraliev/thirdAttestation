using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filesLibrary
{
    public class RealTypeList
    {
        private List<double> list { get; set; }
        public string path { get; set; }

        public RealTypeList(string path)
        {
            this.path = path;   
        }

        public void parse()
        {
            list = new List<double>();
            string[] numbersStrings = File.ReadAllLines(path);
            string[] temp;
            for (int i = 0; i < numbersStrings.Length; i++)
            {
                temp = numbersStrings[i].Trim().Split(' ');
                for (int k = 0; k < temp.Length; k++)
                {
                    list.Add(Double.Parse(temp[k]));
                }
            }
        }

        public int countIncreasingSeries()
        {
            int result = 0;
            bool seriesIsGoing = false;
            for (int i = 1; i < list.Count; i++)
            {
                if (!seriesIsGoing && list[i] > list[i - 1])
                {
                    result++;
                    seriesIsGoing = true;
                }
                else if (list[i] <= list[i - 1]) seriesIsGoing = false;
            }
            return result;
        }

        public int countDecreasingSeries()
        {
            int result = 0;
            bool seriesIsGoing = false;
            for (int i = 1; i < list.Count; i++)
            {
                if (!seriesIsGoing && list[i] < list[i - 1])
                {
                    result++;
                    seriesIsGoing = true;
                }
                else if (list[i] >= list[i - 1]) seriesIsGoing = false;
            }
            return result;
        }

        public int countNonDecreasingSeries()
        {
            int result = 0;
            bool seriesIsGoing = false;
            for (int i = 1; i < list.Count; i++)
            {
                if (!seriesIsGoing && list[i] >= list[i - 1])
                {
                    result++;
                    seriesIsGoing = true;
                }
                else if (list[i] < list[i - 1]) seriesIsGoing = false;
            }
            return result;
        }

        public int countNonIncreasingSeries()
        {
            int result = 0;
            bool seriesIsGoing = false;
            for (int i = 1; i < list.Count; i++)
            {
                if (!seriesIsGoing && list[i] <= list[i - 1])
                {
                    result++;
                    seriesIsGoing = true;
                }
                else if (list[i] > list[i - 1]) seriesIsGoing = false;
            }
            return result;
        }

    }
}
