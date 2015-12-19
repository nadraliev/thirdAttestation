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
using System.IO;

namespace FileStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = String.Empty;

        private void deleteString_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filesLibrary.FileStrings fileStrings = new filesLibrary.FileStrings(path);
            List<String> list = fileStrings.deleteString((int)stringNumberNumeric.Value);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, list);
            }
        }
    }
}
