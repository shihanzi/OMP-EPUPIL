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
    public partial class RemoveSubjectForm : Form
    {
        public RemoveSubjectForm()
        {
            InitializeComponent();
        }


        // button remove class by id
        private void ButtonRemoveCourse_Click(object sender, EventArgs e)
        {
            SUBJECTS course = new SUBJECTS();
            try
            {
                int courseID = Convert.ToInt32(TextBoxCourseID.Text);

                if ((MessageBox.Show("Are Yousure You Want To Delete This Class", "Remove Class", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteSubject(courseID))
                    {
                        MessageBox.Show("Class Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Class Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove Class", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBoxCourseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
