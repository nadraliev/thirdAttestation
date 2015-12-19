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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string path = String.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            RealTypeList numbers = new RealTypeList(path);
            numbers.parse();

            increasingIntervals.Text = numbers.countIncreasingSeries().ToString();
            increasingIntervals.Visible = true;

            decreasingIntervals.Text = numbers.countDecreasingSeries().ToString();
            decreasingIntervals.Visible = true;

            monotonyIntervals.Text = (numbers.countNonDecreasingSeries() + numbers.countNonIncreasingSeries()).ToString();
            monotonyIntervals.Visible = true;
        }
    }
}
