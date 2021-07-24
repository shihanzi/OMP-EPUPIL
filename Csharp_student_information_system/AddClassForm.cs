using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMP_Epupil
{
    public partial class AddClassForm : Form
    {
        public AddClassForm()
        {
            InitializeComponent();
        }
        OMPClass ompclass = new OMPClass();

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            // check if the name is not empty
            // check if this class already exists

            int Id=1;
            string name = TextBoxClassName.Text;
            string section = TextBoxSection.Text;
            string description = TextBoxDescription.Text;

            if (ompclass.insertClass(name, section, description))
            {
                MessageBox.Show("New Class Added", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}