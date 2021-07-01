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
    public partial class ManageCoursesForm : Form
    {
        public ManageCoursesForm()
        {
            InitializeComponent();
        }

        COURSE course = new COURSE();
        int pos;

        // on form load populate the listbox with courses
        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }

        // create a method to populate the listbox with courses name and id
        void reloadListBoxData()
        {
            ListBoxCourses.DataSource = course.getAllCourses();
            ListBoxCourses.ValueMember = "id";
            ListBoxCourses.DisplayMember = "label";

            ListBoxCourses.SelectedItem = null;

            // display the total courses number
            LabelTotalCourses.Text = ("Total Courses: " + course.totalCourses());
        }

        // method to show data depending on the index
        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];

            ListBoxCourses.SelectedIndex = index;

            TextBoxID.Text = dr.ItemArray[0].ToString();

            TextBoxCourseName.Text = dr.ItemArray[1].ToString();

            NumericUpDownHours.Value = int.Parse(dr.ItemArray[2].ToString());

            TextBoxDescription.Text = dr.ItemArray[3].ToString();
        }


        // listbox click -> display the selected course data
        private void ListBoxCourses_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)ListBoxCourses.SelectedItem;
            pos = ListBoxCourses.SelectedIndex;
            showData(pos);
        }


        // button add a new course
        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            // check if the name is not empty
            // check if this course already exists
            // the course hours number must be > 10 -> we can do it from the numericDropDown Tool > or by using the if condition
            // the description is optional
            string name = TextBoxCourseName.Text;
            int hrs = (int)NumericUpDownHours.Value;
            string descr = TextBoxDescription.Text;

            if ( name.Trim() == "" )
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (course.checkCourseName(name))
            {
                if (course.insertCourse(name, hrs, descr))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // button edit course
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            string name = TextBoxCourseName.Text;
            int hrs = (int)NumericUpDownHours.Value;
            string descr = TextBoxDescription.Text;
            int id = int.Parse(TextBoxID.Text);

            // check if the course name already exist & and it's not the current course using the id
            if (!course.checkCourseName(name, Convert.ToInt32(TextBoxID.Text)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pos = 0;

        }


        // button remove course by id
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(TextBoxID.Text);

                if ((MessageBox.Show("Are Yousure You Want To Delete This Course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        // clear fields
                        TextBoxID.Text = "";
                        TextBoxCourseName.Text = "";
                        NumericUpDownHours.Value = 10;
                        TextBoxDescription.Text = "";
                        
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pos = 0;
        }


        // button first
        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }


        // button next
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if ( pos < (course.getAllCourses().Rows.Count - 1) )
            {
                pos = pos + 1;
                showData(pos);
            }
        }


        // button previous
        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if ( pos > 0 )
            {
                pos = pos - 1;
                showData(pos);
            }

        }


        // button last
        private void ButtonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }
    }
}
