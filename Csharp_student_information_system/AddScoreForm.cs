using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_student_information_system
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }

        MARKS score = new MARKS();
        SUBJECTS course = new SUBJECTS();
        STUDENT student = new STUDENT();


        // on form load
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            // populate the combobox with all courses
            ComboBoxCourse.DataSource = course.getAllCourses();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";

            // populate the datagridview with all students
            SqlCommand command = new SqlCommand("SELECT `id`, `first_name`, `last_name` FROM `student`");
            DataGridViewStudents.DataSource = student.getStudents(command);
        }


        // on datagridview_students click
        private void DataGridViewStudents_Click(object sender, EventArgs e)
        {
            // get the id of the selected student
            TextBoxStudentID.Text = DataGridViewStudents.CurrentRow.Cells[0].Value.ToString();
        }


        // button add score
        private void ButtonAddScore_Click(object sender, EventArgs e)
        {

            try
            {
                int studentID = Convert.ToInt32(TextBoxStudentID.Text);
                int courseID = Convert.ToInt32(ComboBoxCourse.SelectedValue);
                double scoreValue = Convert.ToDouble(TextBoxScore.Text);
                string description = TextBoxDescription.Text;

                // check if the score is already set for this student on this score 
                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
