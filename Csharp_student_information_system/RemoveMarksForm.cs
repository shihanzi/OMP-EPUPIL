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

            DataGridViewStudentsScore.DataSource = score.getStudentsScore();

        }


        // button remove score by student_id and course_id
        private void ButtonRemoveScore_Click(object sender, EventArgs e)
        {

            int studentID = int.Parse(DataGridViewStudentsScore.CurrentRow.Cells[0].Value.ToString());
            int subjectID = int.Parse(DataGridViewStudentsScore.CurrentRow.Cells[3].Value.ToString());

            if ( MessageBox.Show("Do You Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
            {
                if (score.deleteScore(studentID, subjectID))
                {
                    MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewStudentsScore.DataSource = score.getStudentsScore();
                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Delete Score",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }

        }
    }
}
