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
    public partial class staffListForm : Form
    {
        public staffListForm()
        {
            InitializeComponent();
        }
        STAFF staff = new STAFF();

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Staffs]");

            Dgv_StaffList.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            Dgv_StaffList.RowTemplate.Height = 80;

            Dgv_StaffList.DataSource = staff.getStaffs(command);

            picCol = (DataGridViewImageColumn)Dgv_StaffList.Columns[8];

            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            Dgv_StaffList.AllowUserToAddRows = false;
        }

        private void staffListForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Staffs]");
                Dgv_StaffList.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                Dgv_StaffList.RowTemplate.Height = 80;
                Dgv_StaffList.DataSource = staff.getStaffs(command);
                picCol = (DataGridViewImageColumn)Dgv_StaffList.Columns[8];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                Dgv_StaffList.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                Ex.Print(ex);
            }

        }

        private void Dgv_StaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateDeleteStaffForm updateDeletStaff = new updateDeleteStaffForm();
            //  DATA ORDER -> id - fn - ln - bd - gdr - phn - adrs - pic
            updateDeletStaff.TxtID.Text = Dgv_StaffList.CurrentRow.Cells[0].Value.ToString();
            updateDeletStaff.Txt_FirstName.Text = Dgv_StaffList.CurrentRow.Cells[1].Value.ToString();
            updateDeletStaff.Txt_StaffLastName.Text = Dgv_StaffList.CurrentRow.Cells[2].Value.ToString();
            updateDeletStaff.Dtp_StaffDOB.Value = (DateTime)Dgv_StaffList.CurrentRow.Cells[3].Value;

            //  gender
            if ((Dgv_StaffList.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                updateDeletStaff.RadioButtonFemale.Checked = true;
            }

            updateDeletStaff.Txt_StaffPhone.Text = Dgv_StaffList.CurrentRow.Cells[5].Value.ToString();
            updateDeletStaff.TextBoxAddress.Text = Dgv_StaffList.CurrentRow.Cells[6].Value.ToString();
            updateDeletStaff.comboBox1.Text = Dgv_StaffList.CurrentRow.Cells[7].Value.ToString();
            
            

            // image
            byte[] pic;
            pic = (byte[])Dgv_StaffList.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeletStaff.PictureBoxStaffImage.Image = Image.FromStream(picture);

            updateDeletStaff.Show();
        }
    }
}
