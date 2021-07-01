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
    public partial class PrintCoursesForm : Form
    {
        public PrintCoursesForm()
        {
            InitializeComponent();
        }

        private void PrintCoursesForm_Load(object sender, EventArgs e)
        {
            // populate DataGridView1 with courses
            COURSE course = new COURSE();
            DataGridView1.DataSource = course.getAllCourses();
        }


        // button print
        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            // get desktop path
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\courses_list.txt";

            using (var writer = new StreamWriter(path))
            {
                // create the file if not exist
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                // export data
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < DataGridView1.Columns.Count - 1; j++)
                    {
                            writer.Write("\t" + DataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("---------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Data Exported");

            }
        }
    }
}
