﻿using System;
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
    public partial class avgMarksBySubjectForm : Form
    {
        public avgMarksBySubjectForm()
        {
            InitializeComponent();
        }

        // on form load populate the datagridview with average score by course
        private void avgMarksBySubjectForm_Load(object sender, EventArgs e)
        {
            MARKS score = new MARKS();
            DataGridViewAvgScore.DataSource = score.getAvgMarksBySubject();
        }
    }
}
