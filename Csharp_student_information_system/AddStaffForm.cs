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

namespace OMP_Epupil
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddStaff_Click(object sender, EventArgs e)
        {

            STAFF staff = new STAFF();
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime bdate = Dtp_StaffDOB.Value;
            string phone = TextBoxPhone.Text;
            string adrs = TextBoxAddress.Text;
            string jb = Cmb_StaffCat.SelectedItem.ToString();
            string gender = "Male";

            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = Dtp_StaffDOB.Value.Year;
            int this_year = DateTime.Now.Year;
            //  allow only students with the age between 10 - 100
            if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Staff  Age Must Be Between 18 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                PictureBoxStaffImage.Image.Save(pic, PictureBoxStaffImage.Image.RawFormat);
                if (staff.insertStaff(fname, lname, bdate, gender, phone, adrs, jb, pic))
                {
                    MessageBox.Show("New Staff Added", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Staff ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //  create a function to verify data
        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                        || (TextBoxLname.Text.Trim() == "")
                        || (TextBoxAddress.Text.Trim() == "")
                        || (TextBoxPhone.Text.Trim() == "")
                        || (PictureBoxStaffImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        // button browse image
      

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        // button browse image
        private void ButtonUploadImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStaffImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
    }

