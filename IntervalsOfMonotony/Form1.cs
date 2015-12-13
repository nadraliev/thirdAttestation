using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using filesLibrary;

namespace IntervalsOfMonotony
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countIntervalsOfMonotony_Click(object sender, EventArgs e)
        {
            string[] numbersStrings = File.ReadAllLines(pathTb.Text)[0].Trim().Split(' ');
            RealTypeList numbers = new RealTypeList();
            for (int i = 0; i < numbersStrings.Length; i++)
            {
                numbers.Add(Double.Parse(numbersStrings[i]));
            }

            increasingIntervals.Text = numbers.countIncreasingSeries().ToString();
            increasingIntervals.Visible = true;

            decreasingIntervals.Text = numbers.countDecreasingSeries().ToString();
            decreasingIntervals.Visible = true;

            monotonyIntervals.Text = (numbers.countNonDecreasingSeries() + numbers.countNonIncreasingSeries()).ToString();
            monotonyIntervals.Visible = true;
        }
    }
}
