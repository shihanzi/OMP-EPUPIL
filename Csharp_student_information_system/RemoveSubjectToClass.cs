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
    public partial class RemoveSubjectToClass : Form
    {
        public RemoveSubjectToClass()
        {
            InitializeComponent();
        }
        SUBTOCLASS subtoclass = new SUBTOCLASS();

        private void RemoveSubjectToClass_Load(object sender, EventArgs e)
        {
            DataGridViewSubToClass.DataSource = subtoclass.getSubToClass();
        }

        private void ButtonRemoveMarks_Click(object sender, EventArgs e)
        {
            int classID = int.Parse(DataGridViewSubToClass.CurrentRow.Cells[1].Value.ToString());
            int subjectID = int.Parse(DataGridViewSubToClass.CurrentRow.Cells[3].Value.ToString());
            

            if (MessageBox.Show("Do You Want To Delete This Subject to Class", "Class Mapping", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (subtoclass.deleteSubToClass(classID, subjectID))
                {
                    MessageBox.Show("Subject removed from Class", "Class Mapping", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewSubToClass.DataSource = subtoclass.getSubToClass();
                }
                else
                {
                    MessageBox.Show("Subject Not Removed", "Class Mapping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

