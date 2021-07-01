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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }


        COURSE course = new COURSE();

        // form load
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            //  display courses on the combobox
            ComboBoxCourse.DataSource = course.getAllCourses();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";

            // set the selected combo item to nothing
            ComboBoxCourse.SelectedItem = null;
        }


        // method to populate the combobox with courses name and id
        public void fillCombo(int index)
        {
            // reload data into the combobox
            // and display the current course
            // index is the selected combo item index
            ComboBoxCourse.DataSource = course.getAllCourses();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
            ComboBoxCourse.SelectedIndex = index;
        }


        // combobox selected index changed
        private void ComboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //  display the selected course from the combobox data 
                int id = Convert.ToInt32(ComboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                TextBoxCourseName.Text = table.Rows[0][1].ToString();
                NumericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
                TextBoxDescription.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }


        // button edit course
        private void ButtonEditCourse_Click(object sender, EventArgs e)
        {
            string name = TextBoxCourseName.Text;
            int hrs =(int) NumericUpDownHours.Value;
            string descr = TextBoxDescription.Text;
            int id = (int) ComboBoxCourse.SelectedValue;

            // check if the course name already exist & and it's not the current course using the id
            if (!course.checkCourseName(name, Convert.ToInt32(ComboBoxCourse.SelectedValue)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(ComboBoxCourse.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
