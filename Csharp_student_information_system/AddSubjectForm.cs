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
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }


        // button add a new course
        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            // check if the name is not empty
            // check if this course already exists
            // the course hours number must be > 10, we can do it from the numericDropDown Tool, or by using the if condition
            // the description is optional
            string name = TextBoxCourseName.Text;
            int hrs = (int)NumericUpDownHours.Value;
            string descr = TextBoxDescription.Text;

            SUBJECTS course = new SUBJECTS();

            if ( name.Trim() == "" )
            {
                MessageBox.Show("Add A Subject Name", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(name))
            {
                if (course.insertSubject(name, hrs, descr))
                {
                    MessageBox.Show("New Subject Inserted", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Subject Not Inserted", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
