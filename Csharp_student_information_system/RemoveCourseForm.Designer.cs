namespace Csharp_student_information_system
{
    partial class RemoveCourseForm
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
            this.ButtonRemoveCourse = new System.Windows.Forms.Button();
            this.TextBoxCourseID = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonRemoveCourse
            // 
            this.ButtonRemoveCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.ButtonRemoveCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveCourse.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoveCourse.Location = new System.Drawing.Point(385, 40);
            this.ButtonRemoveCourse.Name = "ButtonRemoveCourse";
            this.ButtonRemoveCourse.Size = new System.Drawing.Size(123, 33);
            this.ButtonRemoveCourse.TabIndex = 18;
            this.ButtonRemoveCourse.Text = "Remove";
            this.ButtonRemoveCourse.UseVisualStyleBackColor = false;
            this.ButtonRemoveCourse.Click += new System.EventHandler(this.ButtonRemoveCourse_Click);
            // 
            // TextBoxCourseID
            // 
            this.TextBoxCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCourseID.Location = new System.Drawing.Point(210, 43);
            this.TextBoxCourseID.Name = "TextBoxCourseID";
            this.TextBoxCourseID.Size = new System.Drawing.Size(169, 26);
            this.TextBoxCourseID.TabIndex = 17;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(25, 46);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(179, 20);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Enter The Course ID:";
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(562, 111);
            this.Controls.Add(this.ButtonRemoveCourse);
            this.Controls.Add(this.TextBoxCourseID);
            this.Controls.Add(this.Label1);
            this.Name = "RemoveCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonRemoveCourse;
        internal System.Windows.Forms.TextBox TextBoxCourseID;
        internal System.Windows.Forms.Label Label1;
    }
}