
namespace OMP_Epupil
{
    partial class SubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_MapSubjectToClass = new System.Windows.Forms.Button();
            this.Btn_MapStudent = new System.Windows.Forms.Button();
            this.DataGridViewStudentsScore = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVMarksList = new System.Windows.Forms.DataGridView();
            this.Lbl_Report = new System.Windows.Forms.Label();
            this.Manage_Marks = new System.Windows.Forms.Label();
            this.RemoveMarks = new System.Windows.Forms.Label();
            this.AddMarks = new System.Windows.Forms.Label();
            this.DataGridViewAvgScore = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Btn_StudentReport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Remove_Marks = new System.Windows.Forms.Button();
            this.DataGridViewStudentsScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMarksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAvgScore)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_MapSubjectToClass
            // 
            this.Btn_MapSubjectToClass.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_MapSubjectToClass.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MapSubjectToClass.Location = new System.Drawing.Point(101, 73);
            this.Btn_MapSubjectToClass.Name = "Btn_MapSubjectToClass";
            this.Btn_MapSubjectToClass.Size = new System.Drawing.Size(206, 43);
            this.Btn_MapSubjectToClass.TabIndex = 0;
            this.Btn_MapSubjectToClass.Text = "Assign A Subject to Class";
            this.Btn_MapSubjectToClass.UseVisualStyleBackColor = false;
            this.Btn_MapSubjectToClass.Click += new System.EventHandler(this.Btn_MapSubjectToClass_Click);
            // 
            // Btn_MapStudent
            // 
            this.Btn_MapStudent.BackColor = System.Drawing.Color.Yellow;
            this.Btn_MapStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MapStudent.Location = new System.Drawing.Point(101, 201);
            this.Btn_MapStudent.Name = "Btn_MapStudent";
            this.Btn_MapStudent.Size = new System.Drawing.Size(206, 43);
            this.Btn_MapStudent.TabIndex = 1;
            this.Btn_MapStudent.Text = "Assign A Student to Class";
            this.Btn_MapStudent.UseVisualStyleBackColor = false;
            this.Btn_MapStudent.Click += new System.EventHandler(this.Btn_MapStudent_Click);
            // 
            // DataGridViewStudentsScore
            // 
            this.DataGridViewStudentsScore.Controls.Add(this.label3);
            this.DataGridViewStudentsScore.Controls.Add(this.Btn_StudentReport);
            this.DataGridViewStudentsScore.Controls.Add(this.label2);
            this.DataGridViewStudentsScore.Controls.Add(this.DGVMarksList);
            this.DataGridViewStudentsScore.Controls.Add(this.Lbl_Report);
            this.DataGridViewStudentsScore.Controls.Add(this.button3);
            this.DataGridViewStudentsScore.Controls.Add(this.Manage_Marks);
            this.DataGridViewStudentsScore.Controls.Add(this.button2);
            this.DataGridViewStudentsScore.Controls.Add(this.RemoveMarks);
            this.DataGridViewStudentsScore.Controls.Add(this.button1);
            this.DataGridViewStudentsScore.Controls.Add(this.AddMarks);
            this.DataGridViewStudentsScore.Controls.Add(this.Remove_Marks);
            this.DataGridViewStudentsScore.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewStudentsScore.Location = new System.Drawing.Point(428, 40);
            this.DataGridViewStudentsScore.Name = "DataGridViewStudentsScore";
            this.DataGridViewStudentsScore.Size = new System.Drawing.Size(848, 578);
            this.DataGridViewStudentsScore.TabIndex = 2;
            this.DataGridViewStudentsScore.TabStop = false;
            this.DataGridViewStudentsScore.Text = "Manage Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Student Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Marks of All Students";
            // 
            // DGVMarksList
            // 
            this.DGVMarksList.AllowUserToAddRows = false;
            this.DGVMarksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMarksList.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.DGVMarksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMarksList.Location = new System.Drawing.Point(39, 202);
            this.DGVMarksList.Name = "DGVMarksList";
            this.DGVMarksList.Size = new System.Drawing.Size(773, 370);
            this.DGVMarksList.TabIndex = 49;
            // 
            // Lbl_Report
            // 
            this.Lbl_Report.AutoSize = true;
            this.Lbl_Report.Location = new System.Drawing.Point(682, 125);
            this.Lbl_Report.Name = "Lbl_Report";
            this.Lbl_Report.Size = new System.Drawing.Size(111, 21);
            this.Lbl_Report.TabIndex = 10;
            this.Lbl_Report.Text = "Marks Report";
            // 
            // Manage_Marks
            // 
            this.Manage_Marks.AutoSize = true;
            this.Manage_Marks.Location = new System.Drawing.Point(336, 125);
            this.Manage_Marks.Name = "Manage_Marks";
            this.Manage_Marks.Size = new System.Drawing.Size(122, 21);
            this.Manage_Marks.TabIndex = 8;
            this.Manage_Marks.Text = "Manage Marks";
            // 
            // RemoveMarks
            // 
            this.RemoveMarks.AutoSize = true;
            this.RemoveMarks.Location = new System.Drawing.Point(168, 125);
            this.RemoveMarks.Name = "RemoveMarks";
            this.RemoveMarks.Size = new System.Drawing.Size(122, 21);
            this.RemoveMarks.TabIndex = 6;
            this.RemoveMarks.Text = "Remove Marks";
            // 
            // AddMarks
            // 
            this.AddMarks.AutoSize = true;
            this.AddMarks.Location = new System.Drawing.Point(35, 125);
            this.AddMarks.Name = "AddMarks";
            this.AddMarks.Size = new System.Drawing.Size(91, 21);
            this.AddMarks.TabIndex = 4;
            this.AddMarks.Text = "Add Marks";
            // 
            // DataGridViewAvgScore
            // 
            this.DataGridViewAvgScore.AllowUserToAddRows = false;
            this.DataGridViewAvgScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewAvgScore.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.DataGridViewAvgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAvgScore.Location = new System.Drawing.Point(81, 342);
            this.DataGridViewAvgScore.Name = "DataGridViewAvgScore";
            this.DataGridViewAvgScore.Size = new System.Drawing.Size(260, 238);
            this.DataGridViewAvgScore.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Average Statistics of All Subjects";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chocolate;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(101, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 43);
            this.button4.TabIndex = 49;
            this.button4.Text = "Delete Subject From Class";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(101, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(206, 43);
            this.button5.TabIndex = 50;
            this.button5.Text = "Delete Student From Class";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Btn_StudentReport
            // 
            this.Btn_StudentReport.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StudentReport.Image = global::Csharp_student_information_system.Properties.Resources.icons8_business_report_30;
            this.Btn_StudentReport.Location = new System.Drawing.Point(575, 48);
            this.Btn_StudentReport.Name = "Btn_StudentReport";
            this.Btn_StudentReport.Size = new System.Drawing.Size(54, 70);
            this.Btn_StudentReport.TabIndex = 50;
            this.Btn_StudentReport.UseVisualStyleBackColor = true;
            this.Btn_StudentReport.Click += new System.EventHandler(this.Btn_StudentReport_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Csharp_student_information_system.Properties.Resources.icons8_business_report_48;
            this.button3.Location = new System.Drawing.Point(714, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 70);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Csharp_student_information_system.Properties.Resources.icons8_scorecard_483;
            this.button2.Location = new System.Drawing.Point(365, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 70);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Csharp_student_information_system.Properties.Resources.icons8_scorecard_482;
            this.button1.Location = new System.Drawing.Point(52, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 70);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remove_Marks
            // 
            this.Remove_Marks.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Marks.Image = global::Csharp_student_information_system.Properties.Resources.icons8_scorecard_48;
            this.Remove_Marks.Location = new System.Drawing.Point(203, 48);
            this.Remove_Marks.Name = "Remove_Marks";
            this.Remove_Marks.Size = new System.Drawing.Size(54, 70);
            this.Remove_Marks.TabIndex = 3;
            this.Remove_Marks.UseVisualStyleBackColor = true;
            this.Remove_Marks.Click += new System.EventHandler(this.Add_Marks_Click);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 630);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewStudentsScore);
            this.Controls.Add(this.DataGridViewAvgScore);
            this.Controls.Add(this.Btn_MapStudent);
            this.Controls.Add(this.Btn_MapSubjectToClass);
            this.Name = "SubForm";
            this.Text = "SubForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SubForm_Load);
            this.DataGridViewStudentsScore.ResumeLayout(false);
            this.DataGridViewStudentsScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMarksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAvgScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Btn_MapSubjectToClass;
        internal System.Windows.Forms.Button Btn_MapStudent;
        private System.Windows.Forms.GroupBox DataGridViewStudentsScore;
        internal System.Windows.Forms.Button Remove_Marks;
        private System.Windows.Forms.Label AddMarks;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RemoveMarks;
        private System.Windows.Forms.Label Manage_Marks;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lbl_Report;
        internal System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView DataGridViewAvgScore;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView DGVMarksList;
        internal System.Windows.Forms.Button Btn_StudentReport;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button5;
    }
}