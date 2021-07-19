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

namespace OMP_Epupil
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        // button browse impage
        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }


        // button remove selected student
        private void ButtonRemove_Click(object sender, EventArgs e)
        {

            //  delete student
            try
            {
                int studentId = Convert.ToInt32(TextBoxID.Text);
                //  display a confirmation message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  clear fields after delete
                        TextBoxID.Text = "";
                        TextBoxFname.Text = "";
                        TextBoxLname.Text = "";
                        TextBoxAddress.Text = "";
                        TextBoxPhone.Text = "";
                        DateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        //  create a function to verify data
        bool verif()
        {
            if ((TextBoxID.Text.Trim() == "")
                        || (TextBoxFname.Text.Trim() == "")
                        || (TextBoxLname.Text.Trim() == "")
                        || (TextBoxAddress.Text.Trim() == "")
                        || (TextBoxPhone.Text.Trim() == "")
                        || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        // button update selected student data
        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {
            int id;
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime bdate = DateTimePicker1.Value;
            string phone = TextBoxPhone.Text;
            string adrs = TextBoxAddress.Text;
            string gender = "Male";

            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            //  allow only students age between 10 - 100;
            if ( ((this_year - born_year) < 10) || ((this_year - born_year) > 100) )
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Birth Date Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(TextBoxID.Text);

                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        // button search and display student data by id
        private void buttonFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxID.Text);
            SqlCommand command = new SqlCommand("SELECT [Id],[Firstname],[Lastname],[DOB],[Gender],[Phone],[Address],[Picture] FROM [dbo].[Students] WHERE [Id] = " + id);

            DataTable table = student.getStudents(command);

            if(table.Rows.Count > 0)
            {
                TextBoxFname.Text = table.Rows[0]["Firstname"].ToString();
                TextBoxLname.Text = table.Rows[0]["Lastname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["DOB"];

                //  gender
                if (table.Rows[0]["Gender"].ToString() == "Female")
                {
                    RadioButtonFemale.Checked = true;
                }
                else
                {
                    RadioButtonMale.Checked = true;
                }

                TextBoxPhone.Text = table.Rows[0]["Phone"].ToString();
                TextBoxAddress.Text = table.Rows[0]["Address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["Picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
            }

            else
            {
                MessageBox.Show("no data found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }


        // allow only numbers on textbox id
        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
