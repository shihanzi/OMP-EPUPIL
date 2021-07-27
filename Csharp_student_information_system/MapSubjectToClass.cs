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
    public partial class AddSubjectToClass : Form
    {
        public AddSubjectToClass()
        {
            InitializeComponent();
        }
        SUBJECTS subjects = new SUBJECTS();
        OMPClass ompclass = new OMPClass();
        SUBTOCLASS subtoclass = new SUBTOCLASS();

        private void AddSubjectToClass_Load(object sender, EventArgs e)
        {
            // populate the combobox with all subjects
            ComboBoxSubjects.DataSource = subjects.getAllCourses();
            ComboBoxSubjects.DisplayMember = "Name";
            ComboBoxSubjects.ValueMember = "id";

            // populate the datagridview with all students
            SqlCommand command = new SqlCommand("SELECT [Class],[Section] FROM [dbo].[OMPClass]");
            Dgv_AddSubjectToClass.DataSource = ompclass.getClassById(command);
        }

        private void Dgv_AddSubjectToClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the id of the selected student
            TextBoxClassID.Text = Dgv_AddSubjectToClass.CurrentRow.Cells[0].Value.ToString();
            TextBoxSection.Text = Dgv_AddSubjectToClass.CurrentRow.Cells[1].Value.ToString();
        }

        private void MapSubjecttoClass_Click(object sender, EventArgs e)
        {
            try
            {
                int classID = Convert.ToInt32(TextBoxClassID.Text);
                string section = TextBoxSection.Text;
                string subject = ComboBoxSubjects.SelectedItem.ToString();



                // check if the class is already set for this subject 
                if (!subtoclass.subToClassExist(classID,section,subject))
                
                    if (subtoclass.insertSubToClass(classID,section,subject))
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
    }
}
