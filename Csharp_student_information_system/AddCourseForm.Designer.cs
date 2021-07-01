namespace Csharp_student_information_system
{
    partial class AddCourseForm
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
            // ButtonAddCourse
            // 
            this.ButtonAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.ButtonAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCourse.ForeColor = System.Drawing.Color.White;
            this.ButtonAddCourse.Location = new System.Drawing.Point(24, 247);
            this.ButtonAddCourse.Name = "ButtonAddCourse";
            this.ButtonAddCourse.Size = new System.Drawing.Size(375, 40);
            this.ButtonAddCourse.TabIndex = 21;
            this.ButtonAddCourse.Text = "Add";
            this.ButtonAddCourse.UseVisualStyleBackColor = false;
            this.ButtonAddCourse.Click += new System.EventHandler(this.ButtonAddCourse_Click);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(162, 137);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(237, 80);
            this.TextBoxDescription.TabIndex = 20;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(44, 137);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(105, 20);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Description:";
            // 
            // NumericUpDownHours
            // 
            this.NumericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownHours.Location = new System.Drawing.Point(162, 81);
            this.NumericUpDownHours.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownHours.Name = "NumericUpDownHours";
            this.NumericUpDownHours.Size = new System.Drawing.Size(120, 26);
            this.NumericUpDownHours.TabIndex = 18;
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
            this.Label2.Location = new System.Drawing.Point(20, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 20);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Hours Number:";
            // 
            // TextBoxCourseName
            // 
            this.TextBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCourseName.Location = new System.Drawing.Point(162, 24);
            this.TextBoxCourseName.Name = "TextBoxCourseName";
            this.TextBoxCourseName.Size = new System.Drawing.Size(237, 26);
            this.TextBoxCourseName.TabIndex = 16;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(91, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 20);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Label:";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(441, 307);
            this.Controls.Add(this.ButtonAddCourse);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.NumericUpDownHours);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxCourseName);
            this.Controls.Add(this.Label1);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonAddCourse;
        internal System.Windows.Forms.TextBox TextBoxDescription;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.NumericUpDown NumericUpDownHours;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxCourseName;
        internal System.Windows.Forms.Label Label1;
    }
}