using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using filesLibrary;

namespace FileStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deleteString_Click(object sender, EventArgs e)
        {
            filesLibrary.FileStrings fileStrings = new filesLibrary.FileStrings(pathTextBox.Text.Trim());
            fileStrings.deleteString((int)stringNumberNumeric.Value);
        }
    }
}
