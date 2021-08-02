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
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
        }

        private void Btn_MapSubjectToClass_Click(object sender, EventArgs e)
        {
            AddSubjectToClass AddSubTCls = new AddSubjectToClass();
            AddSubTCls.Show();
        }

        private void Btn_MapStudent_Click(object sender, EventArgs e)
        {
            MapStudentToClass AddStuTCls = new MapStudentToClass();
            AddStuTCls.Show();
        }

        private void Add_Marks_Click(object sender, EventArgs e)
        {
            RemoveMarksForm RemoveSF = new RemoveMarksForm();
            RemoveSF.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddScoreForm AddSF = new AddScoreForm();
            AddSF.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintScoresForm PrintSCF = new PrintScoresForm();
            PrintSCF.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageMarksForm ManageSF = new ManageMarksForm();
            ManageSF.Show(this);
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            MARKS score = new MARKS();
            DataGridViewAvgScore.DataSource = score.getAvgMarksBySubject();
            DGVMarksList.DataSource = score.getStudentsMarks();
        }

        private void Btn_StudentReport_Click(object sender, EventArgs e)
        {
            PrintStudentsForm PrintSF = new PrintStudentsForm();
            PrintSF.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveSubjectToClass RSToClas = new RemoveSubjectToClass();
            RSToClas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoveStudFromClass RSFromC = new RemoveStudFromClass();
            RSFromC.Show();
        }
    }
}
