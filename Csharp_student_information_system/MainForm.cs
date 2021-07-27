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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsListForm StdListF = new studentsListForm();
            StdListF.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm StdSF = new StaticsForm();
            StdSF.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm StdUDF = new UpdateDeleteStudentForm();
            StdUDF.Show(this);
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm StdManageF = new ManageStudentsForm();
            StdManageF.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubjectForm AddCF = new AddSubjectForm();
            AddCF.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSubjectForm RemoveCF = new RemoveSubjectForm();
            RemoveCF.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSubjectForm EditCF = new EditSubjectForm();
            EditCF.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSubjectForm ManageCF = new ManageSubjectForm();
            ManageCF.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm AddSF = new AddScoreForm();
            AddSF.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveMarksForm RemoveSF = new RemoveMarksForm();
            RemoveSF.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMarksForm ManageSF = new ManageMarksForm();
            ManageSF.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgMarksBySubjectForm AvgSF = new avgMarksBySubjectForm();
            AvgSF.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentsForm PrintSF = new PrintStudentsForm();
            PrintSF.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintSubjectForm PrintCF = new PrintSubjectForm();
            PrintCF.Show(this);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintScoresForm PrintSCF = new PrintScoresForm();
            PrintSCF.Show(this);
        }

        private void eDITREMOVESCHOOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteSchoolForm AdSch = new UpdateDeleteSchoolForm();
            AdSch.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffF = new AddStaffForm();
            addStaffF.Show(this);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            staffListForm StaffListF = new staffListForm();
            StaffListF.Show(this);
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            updateDeleteStaffForm StaffUpdateDlt = new updateDeleteStaffForm();
            StaffUpdateDlt.Show();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            ManageStaffForm StaffManageFrm = new ManageStaffForm();
            StaffManageFrm.Show();
        }

    

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            UpdateRemoveClassForm updlclass = new UpdateRemoveClassForm();
            updlclass.Show();
        }

        private void toolStripClass_Click(object sender, EventArgs e)
        {

        }

        private void ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripAddClass_Click(object sender, EventArgs e)
        {
            AddClassForm AddClsFrm = new AddClassForm();
            AddClsFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffF = new AddStaffForm();
            addStaffF.Show();
        }

        private void Btn_StaffList_Click(object sender, EventArgs e)
        {
            staffListForm StaffListF = new staffListForm();
            StaffListF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDeleteStaffForm StaffUpdateDlt = new updateDeleteStaffForm();
            StaffUpdateDlt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageStaffForm StaffManageFrm = new ManageStaffForm();
            StaffManageFrm.Show();
        }

        private void Btn_AddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show();
        }

        private void btn_StudentList_Click(object sender, EventArgs e)
        {
            studentsListForm StdListF = new studentsListForm();
            StdListF.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StaticsForm StdSF = new StaticsForm();
            StdSF.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageStudentsForm StdManageF = new ManageStudentsForm();
            StdManageF.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PrintStudentsForm PrintSF = new PrintStudentsForm();
            PrintSF.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddSubjectForm AddCF = new AddSubjectForm();
            AddCF.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditSubjectForm EditCF = new EditSubjectForm();
            EditCF.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ManageSubjectForm ManageCF = new ManageSubjectForm();
            ManageCF.Show();
        }

        private void Btn_AddClass_Click(object sender, EventArgs e)
        {
            AddClassForm AddClsFrm = new AddClassForm();
            AddClsFrm.Show();
        }

        private void Btn_UpdateClass_Click(object sender, EventArgs e)
        {
            UpdateRemoveClassForm updlclass = new UpdateRemoveClassForm();
            updlclass.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            UpdateDeleteSchoolForm AdSch = new UpdateDeleteSchoolForm();
            AdSch.Show();
        }

        
    }
}
