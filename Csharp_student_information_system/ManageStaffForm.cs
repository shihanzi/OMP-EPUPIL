using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace OMP_Epupil
{
    public partial class ManageStaffForm : Form
    {
        public ManageStaffForm()
        {
            InitializeComponent();
        }

        STAFF staff = new STAFF();

        private void ButtonAddStaff_Click(object sender, EventArgs e)
        {
            // button insert a new staff

            {
                STAFF student = new STAFF();
                string fname = TextBoxFname.Text;
                string lname = TextBoxLname.Text;
                DateTime bdate = DateTimePicker1.Value;
                string phone = TextBoxPhone.Text;
                string address = TextBoxAddress.Text;
                string jb = comboBox1.Text;

                string gender = "Male";

                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                int born_year = DateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                //  allow only students age between 10 - 100
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    PictureBoxStaffImage.Image.Save(pic, PictureBoxStaffImage.Image.RawFormat);
                    if (staff.insertStaff(fname, lname, bdate, gender, phone, address ,jb, pic))
                    {
                        MessageBox.Show("New Staff Added", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM `STaffs`"));
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Staffs] WHERE CONCAT([First Name],[Last Name],[Address])LIKE'%" + TextBoxSearch.Text + "%'");
            fillGrid(command);
        }

        private void ManageStaffForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM [dbo].[Staffs]"));
        }
        //  method to fill the datagridview
        public void fillGrid(SqlCommand command)
        {
            DataGridView1.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            DataGridView1.RowTemplate.Height = 80;

            DataGridView1.DataSource = staff.getStaffs(command);

            picCol = (DataGridViewImageColumn)DataGridView1.Columns[8];

            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridView1.AllowUserToAddRows = false;

            // show the total students depending on the DataGridView1 rows
            LabelTotalStaffs.Text = ("Total Staffs: " + DataGridView1.Rows.Count);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime bdate = DateTimePicker1.Value;
            string phone = TextBoxPhone.Text;
            string address = TextBoxAddress.Text;
            string jc = comboBox1.Text;

            string gender = "Male";

            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            //  allow only students age between 10 - 100
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(TextBoxID.Text);

                    PictureBoxStaffImage.Image.Save(pic, PictureBoxStaffImage.Image.RawFormat);
                    if (staff.updateStaffs(id, fname, lname, bdate, gender, phone, address,jc, pic))
                    {
                        MessageBox.Show("Staffs Information Updated", "Edit Staffs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM [dbo].[Staffs]"));
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Staffs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Staffs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Staffs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            
                SaveFileDialog svf = new SaveFileDialog();
                svf.FileName = ("staff_" + TextBoxID.Text);
                if ((PictureBoxStaffImage.Image == null))
                {
                    MessageBox.Show("Please Upload an Image to the Picture Box First");
                }
                else if ((svf.ShowDialog() == DialogResult.OK))
                {
                PictureBoxStaffImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
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

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStaffImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxID.Text = "";
            TextBoxFname.Text = "";
            TextBoxLname.Text = "";
            TextBoxAddress.Text = "";
            TextBoxPhone.Text = "";
            PictureBoxStaffImage.Image = null;
            RadioButtonMale.Checked = true;
            DateTimePicker1.Value = DateTime.Now;
        }

        private void LabelTotalStaffs_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBoxFname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBoxLname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            DateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;
            //  gender
            if ((DataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                RadioButtonFemale.Checked = true;
            }
            else
            {
                RadioButtonMale.Checked = true;
            }

            TextBoxPhone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            TextBoxAddress.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            // image
            byte[] pic;
            pic = (byte[])DataGridView1.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxStaffImage.Image = Image.FromStream(picture);
        }
    }
    }



