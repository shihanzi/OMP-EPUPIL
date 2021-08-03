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
    public partial class UpdateRemoveClassForm : Form
    {
        public UpdateRemoveClassForm()
        {
            InitializeComponent();
        }
        OMPClass ompclass = new OMPClass();
        private void ButtonRemoveClass_Click(object sender, EventArgs e)
        {
            //  delete student
            try
            {
                int Id = Convert.ToInt32(TextBoxClassID.Text);
                //  display a confirmation message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Class", "Delete Class", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (ompclass.deleteClass(Id))
                    {
                        MessageBox.Show("Delete Class", "Class Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  clear fields after delete
                        TextBoxClassID.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Class Not Deleted", "Delete Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove Class", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {
            int id;
            string cname = TextBoxClassName.Text;
            string section = TextBoxSection.Text;
            string description = TextBoxDescription.Text;

            try
            {
                id = Convert.ToInt32(TextBoxClassID.Text);
                if (ompclass.updateClass(id, cname, section, description))
                {
                    MessageBox.Show("Class Information Updated", "Edit Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (verif())
            {
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((TextBoxClassID.Text.Trim() == "")
                        || (TextBoxClassName.Text.Trim() == "")
                        || (TextBoxSection.Text.Trim() == "")
                        || (TextBoxDescription.Text.Trim() == ""))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxClassID.Text);
            SqlCommand command = new SqlCommand("SELECT [Id],[Class],[Section],[Description] FROM [dbo].[OMPClass] WHERE [Id] = " + id);

            DataTable table = ompclass.getClassById(command);

            if (table.Rows.Count > 0)
            {
                TextBoxClassName.Text = table.Rows[0]["Class"].ToString();
                TextBoxSection.Text = table.Rows[0]["Section"].ToString();
                 TextBoxDescription.Text = table.Rows[0]["Description"].ToString();
                

            }

            else
            {
                MessageBox.Show("no data found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void UpdateRemoveClassForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[OMPClass]");
            Dgv_RemoveClass.ReadOnly = true;
            Dgv_RemoveClass.DataSource = ompclass.getClassById(command);
            Dgv_RemoveClass.AllowUserToAddRows = false;
            this.Dgv_RemoveClass.Columns["id"].Visible = false;
        }

        private void Dgv_RemoveClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxClassID.Text = Dgv_RemoveClass.CurrentRow.Cells[0].Value.ToString();
            TextBoxClassName.Text = Dgv_RemoveClass.CurrentRow.Cells[1].Value.ToString();
            TextBoxSection.Text = Dgv_RemoveClass.CurrentRow.Cells[2].Value.ToString();
            TextBoxDescription.Text = Dgv_RemoveClass.CurrentRow.Cells[3].Value.ToString();
            
        }
    }
}

