using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursionLibrary;

namespace RecursionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countCommas_Click(object sender, EventArgs e)
        {
            CommasInFile commasInFile = new CommasInFile(pathTb.Text);
            numberOfCommas.Text = commasInFile.countCommas(commasInFile.makeOneString()).ToString();
            numberOfCommas.Visible = true;
        }
    }
}
