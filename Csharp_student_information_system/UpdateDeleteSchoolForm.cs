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

namespace Csharp_student_information_system
{
    public partial class UpdateDeleteSchoolForm : Form
    {
        public UpdateDeleteSchoolForm()
        {
            InitializeComponent();
        }
            SCHOOL school = new SCHOOL();
            MY_DB mydb = new MY_DB();
           

        //  function to get School details from the database
        public DataTable getAllCourses()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM School", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        //  create a function to verify data
        bool verify()
        {
            if          ((Cmb_SchoolId.Text.Trim() == "")
                        || (txt_SchhoolName.Text.Trim() == "")
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
            int Sid = (int) Cmb_SchoolId.SelectedValue;
            string scn = txt_SchhoolName.Text;
            string scadd = txt_SchhoolAddress.Text;
            string scphone = txt_SchhoolPhone.Text;
            string scweb = txt_SchhoolWeb.Text;
            string scemail = txt_SchhoolMail.Text;

            if (verify())
            {
                try
                {  
                    if (school.updateSchool(Sid,scn, scadd, scphone, scweb, scemail))
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
                    MessageBox.Show(ex.Message, "Edit School ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit School", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateDeleteSchoolForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_DBDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.student_DBDataSet.School);

            //  display School ID on the combobox
            Cmb_SchoolId.DataSource = school.getSchoolDetails();
            Cmb_SchoolId.DisplayMember = "label";
            Cmb_SchoolId.ValueMember = "scid";
            

            // set the selected combo item to nothing
            Cmb_SchoolId.SelectedItem = null;

        }
    }
}

