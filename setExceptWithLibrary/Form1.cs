using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using setExceptWithLibrary;

namespace setExceptWith
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly HashSet<int> first = new HashSet<int>() { 2, 4, 6, 8, 10 };
        readonly HashSet<int> second = new HashSet<int>() { 1, 2, 3, 4, 5 };
        readonly HashSet<int> third = new HashSet<int>() { 2, 3, 5, 7, 8 };

        private void button1_Click(object sender, EventArgs e)
        {
            setExceptWithLibrary.ProcessSet processSet = new ProcessSet();
            HashSet<int> result = processSet.union(processSet.except(first, third), processSet.except(second, third));
            HashSet<int>.Enumerator enumerator = result.GetEnumerator();
            setY.Text += "{";
            for (int i = 0; i < result.Count; i++)
            {
                enumerator.MoveNext();
                setY.Text += enumerator.Current.ToString();
                if (i < result.Count - 1)
                {
                    setY.Text += ", ";
                }
                else setY.Text += "}";
            }
            setYNumber.Text = result.Count.ToString();
        }
    }
}
