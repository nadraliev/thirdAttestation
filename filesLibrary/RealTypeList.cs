using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filesLibrary
{
    public class RealTypeList : List<double>
    {

        public int countIncreasingSeries()
        {
            int result = 0;
            bool seriesIsGoing = false;
            for (int i = 1; i < this.Count; i++)
            {
                if (!seriesIsGoing && this[i] > this[i - 1])
                {
                    result++;
                    seriesIsGoing = true;
                }
                else if (this[i] <= this[i - 1]) seriesIsGoing = false;
            }
            return result;
        }

        public int countDecreasingSeries()
        {
            int result = 0;
            bool seriesIsGoing = false;
            for (int i = 1; i < this.Count; i++)
            {
                if (!seriesIsGoing && this[i] < this[i - 1])
                {
                    result++;
                    seriesIsGoing = true;
                }
                else if (this[i] >= this[i - 1]) seriesIsGoing = false;
            }
            return result;
        }

        public int countNonDecreasingSeries()
        {
            int result = 0;
            bool seriesIsGoing = false;
            for (int i = 1; i < this.Count; i++)
            {
                if (!seriesIsGoing && this[i] >= this[i - 1])
                {
                    result++;
                    seriesIsGoing = true;
                }
                else if (this[i] < this[i - 1]) seriesIsGoing = false;
            }
            return result;
        }

        public int countNonIncreasingSeries()
        {
            int result = 0;
            bool seriesIsGoing = false;
            for (int i = 1; i < this.Count; i++)
            {
                if (!seriesIsGoing && this[i] <= this[i - 1])
                {
                    result++;
                    seriesIsGoing = true;
                }
                else if (this[i] > this[i - 1]) seriesIsGoing = false;
            }
            return result;
        }

    }
}
