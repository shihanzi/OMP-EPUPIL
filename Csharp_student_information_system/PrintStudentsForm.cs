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
    public partial class PrintStudentsForm : Form
    {
        public PrintStudentsForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void PrintStudentsForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM `student`");
            fillGrid(command);

            if(radioButtonNO.Checked)
            {
                DateTimePicker1.Enabled = false;
                DateTimePicker2.Enabled = false;
            }
        }

        private void radioButtonYES_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePicker1.Enabled = true;
            DateTimePicker2.Enabled = true;
        }

        private void radioButtonNO_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePicker1.Enabled = false;
            DateTimePicker2.Enabled = false;
        }


        //  sub to fill the datagridview
        public void fillGrid(SqlCommand command)
        {
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void ButtonGO_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String query;
            if(radioButtonYES.Checked)
            {
                string date1 = DateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = DateTimePicker2.Value.ToString("yyyy-MM-dd");

                if(RadioButtonMale.Checked)
                {
                    query = "SELECT * FROM `student` WHERE `birthdate` BETWEEN '" + date1 + "' AND '" + date2 + "' AND `gender` = 'Male'"; 
                }
                else if(RadioButtonFemale.Checked)
                {
                    query = "SELECT * FROM `student` WHERE `birthdate` BETWEEN '" + date1 + "' AND '" + date2 + "' AND `gender` = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM `student` WHERE `birthdate` BETWEEN '" + date1 + "' AND '" + date2 + "'" ;
                }

                command = new SqlCommand(query);
                fillGrid(command);
            }
            else
                {
                    if (RadioButtonMale.Checked)
                    {
                        query = "SELECT * FROM `student` WHERE `gender` = 'Male'";
                    }
                    else if (RadioButtonFemale.Checked)
                    {
                        query = "SELECT * FROM `student` WHERE `gender` = 'Female'";
                    }
                    else
                    {
                        query = "SELECT * FROM `student`";
                    }

                    command = new SqlCommand(query);
                    fillGrid(command);
                }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\students_list.txt" ;

                using (var writer = new StreamWriter(path))
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }

                    DateTime bdate;


                    for (int i = 0; i < DataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < DataGridView1.Columns.Count - 1; j++)
                        {
                            if (j == 3)
                            {
                                bdate = Convert.ToDateTime(DataGridView1.Rows[i].Cells[j].Value.ToString()); 
                                writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                            }
                            else if(j == DataGridView1.Columns.Count - 2)
                            {
                                writer.Write("\t" + DataGridView1.Rows[i].Cells[j].Value.ToString());
                            }
                            else
                            {
                                writer.Write("\t" + DataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                        }
                        writer.WriteLine("");
                        writer.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                    writer.Close();
                    MessageBox.Show("Data Exported");
                }

        }

    }
}
