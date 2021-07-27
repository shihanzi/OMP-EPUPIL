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

namespace OMP_Epupil
{
    public partial class ManageMarksForm : Form
    {
        public ManageMarksForm()
        {
            InitializeComponent();
        }

        MARKS score = new MARKS();
        STUDENT student = new STUDENT();
        SUBJECTS course = new SUBJECTS();
        string data = "score";

        // on form load
        private void ManageScoresForm_Load(object sender, EventArgs e)
        {
            // populate datagridview with students scores
            DataGridViewStudentsScore.DataSource = score.getStudentsMarks();

            // populate combobox with courses id and name
            ComboBoxCourse.DataSource = course.getAllCourses();
            ComboBoxCourse.DisplayMember = "Name";
            ComboBoxCourse.ValueMember = "id";
        }


        // button to display scores on the datagridview
        private void ButtonShowScores_Click(object sender, EventArgs e)
        {
            data = "score";
            DataGridViewStudentsScore.DataSource = score.getStudentsMarks();
        }


        // button to display students data on the datagridview
        private void ButtonShowStudents_Click(object sender, EventArgs e)
        {
            data = "student";
            SqlCommand command = new SqlCommand("SELECT [Id], [Firstname], [Lastname], [DOB] FROM [dbo].[Students]");
            DataGridViewStudentsScore.DataSource = student.getStudents(command);
        }


        // method to get data from datagridview
        void getDataFromDatagridView()
        {
            //  if the user select to show student data
            //  then when he click on the datagridview it will only show the student id in the textbox
            if ( data == "student" )
            {
                TextBoxStudentID.Text = DataGridViewStudentsScore.CurrentRow.Cells[0].Value.ToString();
                //  if the user select to show student marks data
                //  then when we click a datagridview 
                //  it will show the student id in the textbox & the course in the combobox
            }
            else if ( data == "score" )
            {
                TextBoxStudentID.Text = DataGridViewStudentsScore.CurrentRow.Cells[0].Value.ToString();
                ComboBoxCourse.SelectedValue = DataGridViewStudentsScore.CurrentRow.Cells[3].Value;
            }

        }

        // on datagridview click -> get data to fields
        private void DataGridViewStudentsScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDatagridView();
        }


        // open a new form -> show the average score by course
        private void ButtonAvgScore_Click(object sender, EventArgs e)
        {
            avgMarksBySubjectForm avgScoreByCourseF = new avgMarksBySubjectForm();
            avgScoreByCourseF.Show(this);
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
                if (!score.studentMarksExist(studentID, courseID))
                {
                    if (score.insertMarks(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Marks Inserted", "Add Marks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Marks Not Inserted", "Add Marks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("The Marks For This Subjects is Already Set", "Add Marks", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Marks", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // button remove score by student_id and course_id
        private void ButtonRemoveScore_Click(object sender, EventArgs e)
        {

            int studentID = int.Parse(DataGridViewStudentsScore.CurrentRow.Cells[0].Value.ToString());
            int courseID = int.Parse(DataGridViewStudentsScore.CurrentRow.Cells[3].Value.ToString());

            if (MessageBox.Show("Do You Want To Delete This Marks?", "Delete Marks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteMarks(studentID, courseID))
                {
                    MessageBox.Show("Marks Deleted", "Delete Marks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewStudentsScore.DataSource = score.getStudentsMarks();
                }
                else
                {
                    MessageBox.Show("Marks Not Deleted", "Delete Marks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

    }
}
