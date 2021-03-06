using System.Data.SqlClient;    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_student_information_system
{
    public partial class Login_From : Form
    {
        public Login_From()
        {
            InitializeComponent();
        }

        // button cancel ( close the form )
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        // button login
        private void button_LOGIN_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Users] WHERE [Username] = @usn AND [Password] = @pass", db.getConnection);
            
            command.Parameters.Add("@usn", SqlDbType.VarChar).Value = TextBoxUsername.Text;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
            
            adapter.SelectCommand = command;
            
            adapter.Fill(table);
            
            if ((table.Rows.Count > 0))
            {
                // if this user exist 
                // we will set the dialogResult to OK
                // that mean the login informatons are correct -> open the mainform
                // check out the "Program.cs"
                
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // on form load
        private void Login_From_Load(object sender, EventArgs e)
        {
            // set image into picturebox from images folder
            pictureBox1.Image = Image.FromFile("../../images/user.png");
        }
    }
}
