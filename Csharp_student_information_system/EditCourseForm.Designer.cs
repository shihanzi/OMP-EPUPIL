namespace Csharp_student_information_system
{
    partial class EditCourseForm
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
            this.TextBoxCourseName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.ButtonEditCourse = new System.Windows.Forms.Button();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.NumericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxCourseName
            // 
            this.TextBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCourseName.Location = new System.Drawing.Point(158, 71);
            this.TextBoxCourseName.Name = "TextBoxCourseName";
            this.TextBoxCourseName.Size = new System.Drawing.Size(237, 26);
            this.TextBoxCourseName.TabIndex = 33;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(87, 74);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 20);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "Label:";
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(158, 28);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(238, 28);
            this.ComboBoxCourse.TabIndex = 31;
            this.ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourse_SelectedIndexChanged);
            // 
            // ButtonEditCourse
            // 
            this.ButtonEditCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.ButtonEditCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEditCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditCourse.ForeColor = System.Drawing.Color.White;
            this.ButtonEditCourse.Location = new System.Drawing.Point(24, 265);
            this.ButtonEditCourse.Name = "ButtonEditCourse";
            this.ButtonEditCourse.Size = new System.Drawing.Size(371, 40);
            this.ButtonEditCourse.TabIndex = 30;
            this.ButtonEditCourse.Text = "Edit";
            this.ButtonEditCourse.UseVisualStyleBackColor = false;
            this.ButtonEditCourse.Click += new System.EventHandler(this.ButtonEditCourse_Click);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(159, 158);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(237, 80);
            this.TextBoxDescription.TabIndex = 29;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(41, 158);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(105, 20);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "Description:";
            // 
            // NumericUpDownHours
            // 
            this.NumericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownHours.Location = new System.Drawing.Point(159, 115);
            this.NumericUpDownHours.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownHours.Name = "NumericUpDownHours";
            this.NumericUpDownHours.Size = new System.Drawing.Size(120, 26);
            this.NumericUpDownHours.TabIndex = 27;
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
            this.Label2.Location = new System.Drawing.Point(17, 118);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 20);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Hours Number:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(20, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 20);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Select Course:";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(432, 336);
            this.Controls.Add(this.TextBoxCourseName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.ButtonEditCourse);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.NumericUpDownHours);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "EditCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBoxCourseName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox ComboBoxCourse;
        internal System.Windows.Forms.Button ButtonEditCourse;
        internal System.Windows.Forms.TextBox TextBoxDescription;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.NumericUpDown NumericUpDownHours;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}