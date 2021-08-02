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
using System.Data.Sql;

namespace OMP_Epupil
{
    public partial class UpdateDeleteSchoolForm : Form
    {
        public UpdateDeleteSchoolForm()
        {
            InitializeComponent();
        }
            SCHOOL school = new SCHOOL();
           
           

        //  function to get School details from the database
       

        //  create a function to verify data
        bool verify()
        {
            if          
                         ((txt_SchhoolName.Text.Trim() == "")
                        || (txt_SchhoolAddress.Text.Trim() == "")
                        || (txt_SchhoolPhone.Text.Trim() == "")
                        || (txt_SchhoolWeb.Text.Trim() == "")
                        || (txt_SchhoolMail.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void Btn_SchoolUpdate_Click(object sender, EventArgs e)
        {
            int id=1;
            string scn = txt_SchhoolName.Text;
            string scadd = txt_SchhoolAddress.Text;
            string scphone = txt_SchhoolPhone.Text;
            string scweb = txt_SchhoolWeb.Text;
            string scemail = txt_SchhoolMail.Text;

            if (verify())
            {
                try
                {  
                    if (school.updateSchool(id,scn, scadd, scphone, scweb, scemail))
                    {
                        MessageBox.Show("School Information Updated", "Edit School", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit School ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit School", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit School", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateDeleteSchoolForm_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[School]");
            Dgv_SchoolDetails.ReadOnly = true;
            Dgv_SchoolDetails.RowTemplate.Height = 80;
            Dgv_SchoolDetails.DataSource = school.getSchoolDetails(command);
            Dgv_SchoolDetails.AllowUserToAddRows = false;

            this.Dgv_SchoolDetails.Columns["id"].Visible = false;




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_SchhoolName.Text = Dgv_SchoolDetails.CurrentRow.Cells[2].Value.ToString();
            txt_SchhoolAddress.Text = Dgv_SchoolDetails.CurrentRow.Cells[3].Value.ToString();
            txt_SchhoolPhone.Text = Dgv_SchoolDetails.CurrentRow.Cells[4].Value.ToString();
            txt_SchhoolWeb.Text = Dgv_SchoolDetails.CurrentRow.Cells[5].Value.ToString();
            txt_SchhoolMail.Text = Dgv_SchoolDetails.CurrentRow.Cells[6].Value.ToString();

        }
        // Refresh School gridview
        private void Btn_SchoolRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[School]");

            Dgv_SchoolDetails.ReadOnly = true;
            Dgv_SchoolDetails.RowTemplate.Height = 80;
            Dgv_SchoolDetails.DataSource = school.getSchoolDetails(command);
             Dgv_SchoolDetails.AllowUserToAddRows = false;
        }

        private void Dgv_SchoolDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}

