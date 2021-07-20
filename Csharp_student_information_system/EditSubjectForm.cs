﻿using System;
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
    public partial class EditSubjectForm : Form
    {
        public EditSubjectForm()
        {
            InitializeComponent();
        }


        SUBJECTS course = new SUBJECTS();

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
                table = course.getSubjectById(id);
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
            if (!course.checkSubjectName(name, Convert.ToInt32(ComboBoxCourse.SelectedValue)))
            {
                MessageBox.Show("This Subject Name Already Exist", "Edit Subject", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateSubject(id, name, hrs, descr))
            {
                MessageBox.Show("Subject Updated", "Edit Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(ComboBoxCourse.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Subject Not Updated", "Edit Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
