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

        Queue queue;

        private void button1_Click(object sender, EventArgs e)
        {
            if (queue == null) queue = new Queue(addTb.Text);
            else queue.add(addTb.Text);
            queueTb.Clear();
            addTb.Clear();
            showQueue(queue);
        }

        public void showQueue(Queue queue)
        {
            queueTb.AppendText(queue.current + "\n");
            if (queue.next != null) showQueue(queue.next);
        }
    }
}
