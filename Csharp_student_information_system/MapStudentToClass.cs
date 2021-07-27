using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OMP_Epupil
{
    public partial class MapStudentToClass : Form
    {
        public MapStudentToClass()
        {
            InitializeComponent();
        }
        STUDTOCLASS studtoclass = new STUDTOCLASS();
        STUDENT student = new STUDENT();
        OMPClass ompclass = new OMPClass();

        private void Btn_MapStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int StudentId = Convert.ToInt32(ComboBoxStudentFirstName.SelectedValue);
                int classID = Convert.ToInt32(TextBoxClassID.Text);
                string section = TextBoxSection.Text;
                

                // check if the class is already set for this subject 
                if (!studtoclass.subToStudentExist(StudentId,classID,section))

                    if (studtoclass.insertStudToClass(StudentId, classID, section))
                    {
                        MessageBox.Show("Subject Mapped", "Map", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Subject Not Mapped", "Mapping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                else
                {
                    MessageBox.Show("Mapping Already exist", "Mapping", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Map Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MapStudentToClass_Load(object sender, EventArgs e)
        {
            // populate the combobox with all Student
            ComboBoxStudentFirstName.DataSource = student.getAllStudents();
            ComboBoxStudentFirstName.DisplayMember = "Firstname";
            ComboBoxStudentLastName.DataSource = student.getAllStudents();
            ComboBoxStudentLastName.DisplayMember = "Lastname";
            ComboBoxStudentFirstName.ValueMember = "id";

            // populate the datagridview with all Classes
            SqlCommand command = new SqlCommand("SELECT [Class],[Section] FROM [dbo].[OMPClass]");
            Dgv_AddStudentToClass.DataSource = student.getStudents(command);
        }

        private void Dgv_AddStudentToClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the id of the selected student
            TextBoxClassID.Text = Dgv_AddStudentToClass.CurrentRow.Cells[0].Value.ToString();
            TextBoxSection.Text = Dgv_AddStudentToClass.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
