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
            int id;
            string fname = Txt_FirstName.Text;
            string lname = Txt_StaffLastName.Text;
            DateTime bdate = Dtp_StaffDOB.Value;
            string phone = Txt_StaffPhone.Text;
            string adrs = TextBoxAddress.Text;
            string jc = comboBox1.Text;

            string gender = "Male";

            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = Dtp_StaffDOB.Value.Year;
            int this_year = DateTime.Now.Year;
            //  allow only students age between 10 - 100;
            if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Staff Age Must Be Between 18 and 100 year", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(TxtID.Text);

                    PictureBoxStaffImage.Image.Save(pic, PictureBoxStaffImage.Image.RawFormat);
                    if (staff.updateStaffs(id, fname, lname, bdate, gender, phone, adrs,jc, pic))
                    {
                        MessageBox.Show("Staff Information Updated", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                comboBox1.Text = table.Rows[0]["Job Category"].ToString();


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

            comboBox1.DisplayMember = "label";
            comboBox1.ValueMember = "id";

            // set the selected combo item to nothing
            comboBox1.SelectedItem = null;
        }
        //  create a function to verify data
        bool verif()
        {
            if ((TxtID.Text.Trim() == "")
                        || (Txt_FirstName.Text.Trim() == "")
                        || (Txt_StaffLastName.Text.Trim() == "")
                        || (TextBoxAddress.Text.Trim() == "")
                        || (Txt_StaffPhone.Text.Trim() == "")
                        || (PictureBoxStaffImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {

            //  delete student
            try
            {
                int staffId = Convert.ToInt32(TxtID.Text);
                //  display a confirmation message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Staff", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (staff.deleteStaffs(staffId))
                    {
                        MessageBox.Show("Staff Deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  clear fields after delete
                        TxtID.Text = "";
                        Txt_FirstName.Text = "";
                        Txt_StaffLastName.Text = "";
                        TextBoxAddress.Text = "";
                        Txt_StaffPhone.Text = "";
                        Dtp_StaffDOB.Value = DateTime.Now;
                        PictureBoxStaffImage.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Staff Not Deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

