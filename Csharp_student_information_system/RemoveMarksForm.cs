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
    public partial class RemoveMarksForm : Form
    {
        public RemoveMarksForm()
        {
            InitializeComponent();
        }


        MARKS score = new MARKS();


        // on form load
        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            // populate the datagridview with:
            // student id - first name - last name
            // course id - label
            // score value

            DataGridViewStudentsScore.DataSource = score.getStudentsMarks();

        }


        // button remove score by student_id and marks_id
        private void ButtonRemoveScore_Click(object sender, EventArgs e)
        {

            int studentID = int.Parse(DataGridViewStudentsScore.CurrentRow.Cells[0].Value.ToString());
            int subjectID = int.Parse(DataGridViewStudentsScore.CurrentRow.Cells[3].Value.ToString());

            if ( MessageBox.Show("Do You Want To Delete This Marks", "Marks Score", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
            {
                if (score.deleteMarks(studentID, subjectID))
                {
                    MessageBox.Show("Marks Deleted", "Delete Marks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewStudentsScore.DataSource = score.getStudentsMarks();
                }
                else
                {
                    MessageBox.Show("Marks Not Deleted", "Delete Marks", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }

        }
    }
}
