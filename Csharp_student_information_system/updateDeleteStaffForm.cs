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
using System.IO;

namespace OMP_Epupil
{
    public partial class updateDeleteStaffForm : Form
    {
        public updateDeleteStaffForm()
        {
            InitializeComponent();
        }
        STAFF staff = new STAFF();

        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {

        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            SqlCommand command = new SqlCommand("SELECT [Id],[First Name],[Last Name],[DOB],[Gender],[Phone],[Address],[Job Category],[Picture] FROM [dbo].[Staffs] WHERE [Id] = " + id);

            DataTable table = staff.getStaffs(command);

            if (table.Rows.Count > 0)
            {
                Txt_FirstName.Text = table.Rows[0]["First Name"].ToString();
                Txt_StaffLastName.Text = table.Rows[0]["Last Name"].ToString();
                Dtp_StaffDOB.Value = (DateTime)table.Rows[0]["DOB"];

                //  gender
                if (table.Rows[0]["Gender"].ToString() == "Female")
                {
                    RadioButtonFemale.Checked = true;
                }
                else
                {
                    RadioButtonMale.Checked = true;
                }

               
                Txt_StaffPhone.Text = table.Rows[0]["Phone"].ToString();
                TextBoxAddress.Text = table.Rows[0]["Address"].ToString();
                Cmb_JobType.Text = table.Rows[0]["Job Category"].ToString();


                byte[] pic = (byte[])table.Rows[0]["Picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStaffImage.Image = Image.FromStream(picture);
            }

            else
            {
                MessageBox.Show("no data found", "Find Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void updateDeleteStaffForm_Load(object sender, EventArgs e)
        {
            
            Cmb_JobType.DisplayMember = "label";
            Cmb_JobType.ValueMember = "id";

            // set the selected combo item to nothing
            Cmb_JobType.SelectedItem = null;
        }
    }
}
