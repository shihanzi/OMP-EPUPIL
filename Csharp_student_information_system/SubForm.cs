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
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
        }

        private void Btn_MapSubjectToClass_Click(object sender, EventArgs e)
        {
            AddSubjectToClass AddSubTCls = new AddSubjectToClass();
            AddSubTCls.Show();
        }
    }
}
