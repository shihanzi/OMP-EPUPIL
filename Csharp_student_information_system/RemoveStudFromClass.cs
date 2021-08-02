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
    public partial class RemoveStudFromClass : Form
    {
        public RemoveStudFromClass()
        {
            InitializeComponent();
        }
        STUDTOCLASS studtoclass = new STUDTOCLASS();

        private void RemoveStudFromClass_Load(object sender, EventArgs e)
        {
            DataGridViewSubToClass.DataSource = studtoclass.getStudToClass();
        }

        private void ButtonRemoveStudent_Click(object sender, EventArgs e)
        {
            int classID = int.Parse(DataGridViewSubToClass.CurrentRow.Cells[1].Value.ToString());
            int studentID = int.Parse(DataGridViewSubToClass.CurrentRow.Cells[3].Value.ToString());


            if (MessageBox.Show("Do You Want To Delete This Student from Class", "Student Mapping", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (studtoclass.deleteStudtoClass(classID, studentID))
                {
                    MessageBox.Show("Student removed from Class", "Student Mapping", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewSubToClass.DataSource = studtoclass.getStudToClass();
                }
                else
                {
                    MessageBox.Show("Student Not Removed", "Student Mapping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

