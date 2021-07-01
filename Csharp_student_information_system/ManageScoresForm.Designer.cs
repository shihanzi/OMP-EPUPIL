namespace Csharp_student_information_system
{
    partial class ManageScoresForm
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
            this.ButtonAvgScore = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.ButtonShowScores = new System.Windows.Forms.Button();
            this.ButtonShowStudents = new System.Windows.Forms.Button();
            this.ButtonAddScore = new System.Windows.Forms.Button();
            this.TextBoxStudentID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxScore = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.DataGridViewStudentsScore = new System.Windows.Forms.DataGridView();
            this.ButtonRemoveScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentsScore)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAvgScore
            // 
            this.ButtonAvgScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.ButtonAvgScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAvgScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAvgScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAvgScore.ForeColor = System.Drawing.Color.White;
            this.ButtonAvgScore.Location = new System.Drawing.Point(38, 379);
            this.ButtonAvgScore.Name = "ButtonAvgScore";
            this.ButtonAvgScore.Size = new System.Drawing.Size(274, 40);
            this.ButtonAvgScore.TabIndex = 72;
            this.ButtonAvgScore.Text = "Average Score By Course";
            this.ButtonAvgScore.UseVisualStyleBackColor = false;
            this.ButtonAvgScore.Click += new System.EventHandler(this.ButtonAvgScore_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(16, 464);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(450, 16);
            this.Label5.TabIndex = 71;
            this.Label5.Text = "* to edit a score you have to delete it and RE add it with the values you want";
            // 
            // ButtonShowScores
            // 
            this.ButtonShowScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowScores.Location = new System.Drawing.Point(729, 34);
            this.ButtonShowScores.Name = "ButtonShowScores";
            this.ButtonShowScores.Size = new System.Drawing.Size(233, 26);
            this.ButtonShowScores.TabIndex = 70;
            this.ButtonShowScores.Text = "Show Scores";
            this.ButtonShowScores.UseVisualStyleBackColor = true;
            this.ButtonShowScores.Click += new System.EventHandler(this.ButtonShowScores_Click);
            // 
            // ButtonShowStudents
            // 
            this.ButtonShowStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowStudents.Location = new System.Drawing.Point(459, 36);
            this.ButtonShowStudents.Name = "ButtonShowStudents";
            this.ButtonShowStudents.Size = new System.Drawing.Size(233, 26);
            this.ButtonShowStudents.TabIndex = 69;
            this.ButtonShowStudents.Text = "Show Students";
            this.ButtonShowStudents.UseVisualStyleBackColor = true;
            this.ButtonShowStudents.Click += new System.EventHandler(this.ButtonShowStudents_Click);
            // 
            // ButtonAddScore
            // 
            this.ButtonAddScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.ButtonAddScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddScore.ForeColor = System.Drawing.Color.White;
            this.ButtonAddScore.Location = new System.Drawing.Point(38, 313);
            this.ButtonAddScore.Name = "ButtonAddScore";
            this.ButtonAddScore.Size = new System.Drawing.Size(123, 40);
            this.ButtonAddScore.TabIndex = 68;
            this.ButtonAddScore.Text = "Add";
            this.ButtonAddScore.UseVisualStyleBackColor = false;
            this.ButtonAddScore.Click += new System.EventHandler(this.ButtonAddScore_Click);
            // 
            // TextBoxStudentID
            // 
            this.TextBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStudentID.Location = new System.Drawing.Point(168, 33);
            this.TextBoxStudentID.Name = "TextBoxStudentID";
            this.TextBoxStudentID.ReadOnly = true;
            this.TextBoxStudentID.Size = new System.Drawing.Size(120, 26);
            this.TextBoxStudentID.TabIndex = 67;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(54, 36);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(102, 20);
            this.Label2.TabIndex = 66;
            this.Label2.Text = "Student ID:";
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(168, 81);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(238, 28);
            this.ComboBoxCourse.TabIndex = 65;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(30, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 20);
            this.Label1.TabIndex = 64;
            this.Label1.Text = "Select Course:";
            // 
            // TextBoxScore
            // 
            this.TextBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxScore.Location = new System.Drawing.Point(167, 130);
            this.TextBoxScore.Name = "TextBoxScore";
            this.TextBoxScore.Size = new System.Drawing.Size(121, 26);
            this.TextBoxScore.TabIndex = 63;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(96, 133);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(61, 20);
            this.Label4.TabIndex = 62;
            this.Label4.Text = "Score:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(167, 180);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(237, 80);
            this.TextBoxDescription.TabIndex = 61;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(49, 180);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(105, 20);
            this.Label3.TabIndex = 60;
            this.Label3.Text = "Description:";
            // 
            // DataGridViewStudentsScore
            // 
            this.DataGridViewStudentsScore.AllowUserToAddRows = false;
            this.DataGridViewStudentsScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudentsScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudentsScore.Location = new System.Drawing.Point(459, 73);
            this.DataGridViewStudentsScore.Name = "DataGridViewStudentsScore";
            this.DataGridViewStudentsScore.Size = new System.Drawing.Size(503, 388);
            this.DataGridViewStudentsScore.TabIndex = 59;
            this.DataGridViewStudentsScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudentsScore_CellClick);
            // 
            // ButtonRemoveScore
            // 
            this.ButtonRemoveScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.ButtonRemoveScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemoveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveScore.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoveScore.Location = new System.Drawing.Point(181, 313);
            this.ButtonRemoveScore.Name = "ButtonRemoveScore";
            this.ButtonRemoveScore.Size = new System.Drawing.Size(131, 40);
            this.ButtonRemoveScore.TabIndex = 58;
            this.ButtonRemoveScore.Text = "Remove";
            this.ButtonRemoveScore.UseVisualStyleBackColor = false;
            this.ButtonRemoveScore.Click += new System.EventHandler(this.ButtonRemoveScore_Click);
            // 
            // ManageScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(971, 513);
            this.Controls.Add(this.ButtonAvgScore);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ButtonShowScores);
            this.Controls.Add(this.ButtonShowStudents);
            this.Controls.Add(this.ButtonAddScore);
            this.Controls.Add(this.TextBoxStudentID);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBoxScore);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DataGridViewStudentsScore);
            this.Controls.Add(this.ButtonRemoveScore);
            this.Name = "ManageScoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageScoresForm";
            this.Load += new System.EventHandler(this.ManageScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentsScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonAvgScore;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button ButtonShowScores;
        internal System.Windows.Forms.Button ButtonShowStudents;
        internal System.Windows.Forms.Button ButtonAddScore;
        internal System.Windows.Forms.TextBox TextBoxStudentID;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox ComboBoxCourse;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBoxScore;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TextBoxDescription;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DataGridView DataGridViewStudentsScore;
        internal System.Windows.Forms.Button ButtonRemoveScore;
    }
}