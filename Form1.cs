using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileHandler fh = new FileHandler();
        List<Student> students = new List<Student>();
        public void AddDataToList()
        {
            fh.ReadFile();
            foreach (string item in fh.rawData)
            {
                string[] splitData = item.Split(',');
                int ageData = int.Parse(splitData[2]);
                students.Add(new Student(splitData[0], splitData[1], ageData, splitData[3]));
            }
        }


        // Declare a flag to track if AddDataToList has been executed
        private bool isAddDataToListExecuted = false;

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                StudentId = StudentIdTextBox.Text,
                StudentName = NametextBox.Text,
                Age = (int)AgeUpDown.Value,
                Course = CoursecomboBox.Text
            };
               

            if (!string.IsNullOrWhiteSpace(student.StudentId) &&
                student.StudentName != null &&
                student.Age > 0 &&
                !string.IsNullOrWhiteSpace(student.Course))
            {
                // Execute AddDataToList only once
                if (!isAddDataToListExecuted)
                {
                    AddDataToList();
                    isAddDataToListExecuted = true;
                }

                students.Add(student);
                fh.WriteFile(student.StudentId, student.StudentName, student.Age, student.Course);
            
            StudentIdTextBox.Clear();
                NametextBox.Clear();
                AgeUpDown.Value = AgeUpDown.Minimum;
                CoursecomboBox.SelectedIndex = -1;

                // Display all the results in the DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = students;

                int lastIndex = students.Count - 1;
                dataGridView1.Rows[lastIndex].Selected = true;
                dataGridView1.Rows[lastIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("All text fields are required");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
