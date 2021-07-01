namespace Csharp_student_information_system
{
    partial class ManageCoursesForm
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
            this.LabelTotalCourses = new System.Windows.Forms.Label();
            this.ButtonLast = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonFirst = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ListBoxCourses = new System.Windows.Forms.ListBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.ButtonAddCourse = new System.Windows.Forms.Button();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.NumericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxCourseName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTotalCourses
            // 
            this.LabelTotalCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.LabelTotalCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalCourses.ForeColor = System.Drawing.Color.White;
            this.LabelTotalCourses.Location = new System.Drawing.Point(600, 381);
            this.LabelTotalCourses.Name = "LabelTotalCourses";
            this.LabelTotalCourses.Size = new System.Drawing.Size(213, 40);
            this.LabelTotalCourses.TabIndex = 57;
            this.LabelTotalCourses.Text = "Total Courses:";
            this.LabelTotalCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonLast
            // 
            this.ButtonLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ButtonLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLast.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLast.ForeColor = System.Drawing.Color.White;
            this.ButtonLast.Location = new System.Drawing.Point(359, 272);
            this.ButtonLast.Name = "ButtonLast";
            this.ButtonLast.Size = new System.Drawing.Size(96, 40);
            this.ButtonLast.TabIndex = 56;
            this.ButtonLast.Text = ">>";
            this.ButtonLast.UseVisualStyleBackColor = false;
            this.ButtonLast.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ButtonPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrevious.ForeColor = System.Drawing.Color.White;
            this.ButtonPrevious.Location = new System.Drawing.Point(242, 272);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(96, 40);
            this.ButtonPrevious.TabIndex = 55;
            this.ButtonPrevious.Tag = "";
            this.ButtonPrevious.Text = "<";
            this.ButtonPrevious.UseVisualStyleBackColor = false;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.ForeColor = System.Drawing.Color.White;
            this.ButtonNext.Location = new System.Drawing.Point(125, 272);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(96, 40);
            this.ButtonNext.TabIndex = 54;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ButtonFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFirst.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFirst.ForeColor = System.Drawing.Color.White;
            this.ButtonFirst.Location = new System.Drawing.Point(10, 272);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(96, 40);
            this.ButtonFirst.TabIndex = 53;
            this.ButtonFirst.Text = "<<";
            this.ButtonFirst.UseVisualStyleBackColor = false;
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.ButtonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.ForeColor = System.Drawing.Color.White;
            this.ButtonRemove.Location = new System.Drawing.Point(292, 352);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(96, 40);
            this.ButtonRemove.TabIndex = 52;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = false;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.ButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit.Location = new System.Drawing.Point(175, 352);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(96, 40);
            this.ButtonEdit.TabIndex = 51;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ListBoxCourses
            // 
            this.ListBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxCourses.FormattingEnabled = true;
            this.ListBoxCourses.ItemHeight = 25;
            this.ListBoxCourses.Location = new System.Drawing.Point(486, 24);
            this.ListBoxCourses.Name = "ListBoxCourses";
            this.ListBoxCourses.Size = new System.Drawing.Size(327, 354);
            this.ListBoxCourses.TabIndex = 50;
            this.ListBoxCourses.Click += new System.EventHandler(this.ListBoxCourses_Click);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxID.Location = new System.Drawing.Point(151, 21);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(120, 26);
            this.TextBoxID.TabIndex = 49;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(105, 24);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(33, 20);
            this.Label4.TabIndex = 48;
            this.Label4.Text = "ID:";
            // 
            // ButtonAddCourse
            // 
            this.ButtonAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.ButtonAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCourse.ForeColor = System.Drawing.Color.White;
            this.ButtonAddCourse.Location = new System.Drawing.Point(60, 352);
            this.ButtonAddCourse.Name = "ButtonAddCourse";
            this.ButtonAddCourse.Size = new System.Drawing.Size(96, 40);
            this.ButtonAddCourse.TabIndex = 47;
            this.ButtonAddCourse.Text = "Add";
            this.ButtonAddCourse.UseVisualStyleBackColor = false;
            this.ButtonAddCourse.Click += new System.EventHandler(this.ButtonAddCourse_Click);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(151, 165);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(237, 80);
            this.TextBoxDescription.TabIndex = 46;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(33, 165);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(105, 20);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "Description:";
            // 
            // NumericUpDownHours
            // 
            this.NumericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownHours.Location = new System.Drawing.Point(151, 116);
            this.NumericUpDownHours.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownHours.Name = "NumericUpDownHours";
            this.NumericUpDownHours.Size = new System.Drawing.Size(120, 26);
            this.NumericUpDownHours.TabIndex = 44;
            this.NumericUpDownHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(9, 119);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 20);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "Hours Number:";
            // 
            // TextBoxCourseName
            // 
            this.TextBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCourseName.Location = new System.Drawing.Point(151, 68);
            this.TextBoxCourseName.Name = "TextBoxCourseName";
            this.TextBoxCourseName.Size = new System.Drawing.Size(237, 26);
            this.TextBoxCourseName.TabIndex = 42;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(80, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 20);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "Label:";
            // 
            // ManageCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(822, 442);
            this.Controls.Add(this.LabelTotalCourses);
            this.Controls.Add(this.ButtonLast);
            this.Controls.Add(this.ButtonPrevious);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonFirst);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ListBoxCourses);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ButtonAddCourse);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.NumericUpDownHours);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxCourseName);
            this.Controls.Add(this.Label1);
            this.Name = "ManageCoursesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCoursesForm";
            this.Load += new System.EventHandler(this.ManageCoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LabelTotalCourses;
        internal System.Windows.Forms.Button ButtonLast;
        internal System.Windows.Forms.Button ButtonPrevious;
        internal System.Windows.Forms.Button ButtonNext;
        internal System.Windows.Forms.Button ButtonFirst;
        internal System.Windows.Forms.Button ButtonRemove;
        internal System.Windows.Forms.Button ButtonEdit;
        internal System.Windows.Forms.ListBox ListBoxCourses;
        internal System.Windows.Forms.TextBox TextBoxID;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button ButtonAddCourse;
        internal System.Windows.Forms.TextBox TextBoxDescription;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.NumericUpDown NumericUpDownHours;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxCourseName;
        internal System.Windows.Forms.Label Label1;
    }
}