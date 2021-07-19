using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_student_information_system
{
    public partial class studentsListForm : Form
    {
        public studentsListForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        // on the form load -> populate the datagridview with students data
        private void studentsListForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Students]");
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }


        // on datagridview double click show the selected student data
        // into the UpdateDeleteStudentForm form
        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeletStdF = new UpdateDeleteStudentForm();
            //  DATA ORDER -> id - fn - ln - bd - gdr - phn - adrs - pic
            updateDeletStdF.TextBoxID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeletStdF.TextBoxFname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeletStdF.TextBoxLname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeletStdF.DateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;

            //  gender
            if ((DataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                updateDeletStdF.RadioButtonFemale.Checked = true;
            }

            updateDeletStdF.TextBoxPhone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeletStdF.TextBoxAddress.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            // image
            byte[] pic;
            pic = (byte[])DataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeletStdF.PictureBoxStudentImage.Image = Image.FromStream(picture);

            updateDeletStdF.Show();
        }


        // button refresh
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Students]");
            
            DataGridView1.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            DataGridView1.RowTemplate.Height = 80;

            DataGridView1.DataSource = student.getStudents(command);

            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];

            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridView1.AllowUserToAddRows = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
