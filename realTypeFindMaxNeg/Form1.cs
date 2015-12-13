using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using realTypeLibrary;

namespace realTypeFindMaxNeg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<RealType> realTypeList;

        private void generateNumbers_Click(object sender, EventArgs e)
        {
            generatedNumbersTb.Clear();
            realTypeList = new List<RealType>();
            for (int i = 0; i < 30; i++)
            {
                realTypeList.Add(new RealType());
                generatedNumbersTb.AppendText(realTypeList[i] + "\n");
            }
        }

        private void findMin_Click(object sender, EventArgs e)
        {
            min.Visible = true;
            bool hasNeg = false;
            foreach (RealType number in realTypeList)
            {
                if (!number.sign) hasNeg = true;
            }
            if (hasNeg)
                min.Text += RealTypeList.minNeg(realTypeList).ToString();
            else min.Text = "Нет отрицательных чисел";
        }
    }
}
