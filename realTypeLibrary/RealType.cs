using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realTypeLibrary
{
    public class RealType
    {

        public bool sign { get; set; }
        public double mantissa { get; set; }
        public int grade { get; set; }

        static Random random = new Random();

        public RealType(bool sign, double mantissa, int grade)
        {
            this.sign = sign;
            this.mantissa = mantissa;
            this.grade = grade;
        }

        public RealType()
        {
            sign = random.Next(2) == 1? true :false;
            mantissa = random.NextDouble();
            while (mantissa < 0.1) mantissa *= 10;
            grade = random.Next(10);
        }

        public int compare(RealType number)
        {
            int result = 0;
            if (sign && !number.sign) result = 1; //знак текущего +, а знак параметра -
            else if (!sign && number.sign) result = -1;   //знак текущего -, а знак параметра +
            else    //знаки одинаковые
            {
                if (sign && number.sign)    //оба знака +
                {
                    if (grade > number.grade) result = 1; //порядок текущего выше параметра
                    else if (grade < number.grade) result = -1;   //порядок текущего ниже параметра
                    else    //порядки равны
                    {
                        if (mantissa > number.mantissa) result = 1;   //мантисса текущего больше параметра
                        else if (mantissa < number.mantissa) result = -1; //мантисса текущего меньше параметра
                        else result = 0;  //числа равны
                    }
                } else if (!sign && !number.sign)   //оба знака -
                {
                    if (grade > number.grade) result = -1; //порядок текущего выше параметра
                    else if (grade < number.grade) result = 1;   //порядок текущего ниже параметра
                    else    //порядки равны
                    {
                        if (mantissa > number.mantissa) result = -1;   //мантисса текущего больше параметра
                        else if (mantissa < number.mantissa) result = 1; //мантисса текущего меньше параметра
                        else result = 0;  //числа равны
                    }
                }
            }
            return result;
        }

        public override string ToString()
        {
            return (sign?"+":"-") + mantissa + "*10^" + grade;
        }
    }
}
