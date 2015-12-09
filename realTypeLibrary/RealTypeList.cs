using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realTypeLibrary
{
    public static class RealTypeList
    {

        public static RealType minNeg(List<RealType> list)
        {
            RealType result = list[0];
            foreach (RealType number in list)
            {
                if (!number.sign)
                {
                    result = number;
                    break;
                }
            }
            foreach (RealType number in list)
            {
                if (!number.sign && number.compare(result) == -1) result = number;
            }
            return result;
        }
    }
}
