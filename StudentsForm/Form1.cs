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
using System.Runtime.Serialization.Formatters.Binary;
using filesLibrary;
using FileClassLibrary;

namespace StudentsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(pathTb.Text, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            StudentList studentList = new StudentList((List<Student>) binaryFormatter.Deserialize(fileStream));
            fileStream.Close();
            SortedDictionary<int, double> marksByGroups = new SortedDictionary<int, double>();
            foreach (Student student in studentList.list)
            {
                try {
                    marksByGroups.Add(student.Group, studentList.findGroupAverageMark(student.Group));
                } catch (Exception exc)
                {

                }
            }
            SortedDictionary<int, double>.Enumerator enumerator = marksByGroups.GetEnumerator();
            bool noGroups = true;
            groupsLabel.Visible = true;
            groupsLabel.ResetText();
            for (int i = 0; i < marksByGroups.Count; i++)
            {
                enumerator.MoveNext();
                if (enumerator.Current.Value < studentList.findFacultyAverageMark())
                {
                    groupsLabel.Text += enumerator.Current.Key.ToString() + " ";
                    noGroups = false;
                }
            }
            if (noGroups) groupsLabel.Text = "No Such Groups";
        }
    }
}
