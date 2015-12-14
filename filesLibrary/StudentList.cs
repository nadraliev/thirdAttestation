using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileClassLibrary;

namespace filesLibrary
{
    public class StudentList
    {
        public List<Student> list;

        public StudentList(List<Student> list)
        {
            this.list = list;
        }

        public double findFacultyAverageMark()
        {
            double result = 0;
            foreach (Student student in list)
            {
                result += student.AverageMarks.Sum() / 80;
            }
            return result; 
        }

        public double findGroupAverageMark(int numberOfGroup)
        {
            double result = 0;
            foreach (Student student in list)
            {
                if (student.Group == numberOfGroup) result += student.AverageMarks.Sum() / 10;
            }
            return result;
        }
    }
}
