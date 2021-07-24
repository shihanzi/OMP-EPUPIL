using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMP_Epupil
{
    public partial class PrintScoresForm : Form
    {
        public PrintScoresForm()
        {
            InitializeComponent();
        }

        MARKS score = new MARKS();
        SUBJECTS course = new SUBJECTS();
        STUDENT student = new STUDENT();

        private void PrintScoresForm_Load(object sender, EventArgs e)
        {
            // populate DataGridViewStudentsScore with students scores
            DataGridViewStudentsScore.DataSource = score.getStudentsMarks();

            // populate dataGridView1 with students id, first name, last name 
            dataGridView1.DataSource = student.getStudents(new SqlCommand("SELECT id, Firstname, Lastname FROM Students"));

            // populate listbox with courses
            ListBoxCourses.DataSource = course.getAllCourses();
            ListBoxCourses.ValueMember = "id";
            ListBoxCourses.DisplayMember = "Name";
        }


        // on listbox click -> display scores for the selected course
        private void ListBoxCourses_Click(object sender, EventArgs e)
        {
            DataGridViewStudentsScore.DataSource = score.getSubjectMarks(int.Parse(ListBoxCourses.SelectedValue.ToString()));
        }


        // on dataGridView1 click -> display scores of the selected student
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewStudentsScore.DataSource = score.getStudentMarks(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }


        // button print
        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            // get desktop path
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\scores_list.xls";

            using (var writer = new StreamWriter(path))
            {
                // create the file if not exist
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                // export data
                for (int i = 0; i < DataGridViewStudentsScore.Rows.Count; i++)
                {
                    for (int j = 0; j < DataGridViewStudentsScore.Columns.Count; j++)
                    {
                        writer.Write("\t" + DataGridViewStudentsScore.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("-----------------------------------------------------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Data Exported");

            }
        }

        private void labelReset_Click(object sender, EventArgs e)
        {
            // populate DataGridViewStudentsScore with students scores
            DataGridViewStudentsScore.DataSource = score.getStudentsMarks();
        }

        private void ListBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
