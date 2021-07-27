
namespace OMP_Epupil
{
    partial class MapStudentToClass
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
            this.Btn_MapStudent = new System.Windows.Forms.Button();
            this.ComboBoxStudent = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Dgv_AddSubjectToClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AddSubjectToClass)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_MapStudent
            // 
            this.Btn_MapStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.Btn_MapStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MapStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MapStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MapStudent.ForeColor = System.Drawing.Color.White;
            this.Btn_MapStudent.Location = new System.Drawing.Point(86, 190);
            this.Btn_MapStudent.Name = "Btn_MapStudent";
            this.Btn_MapStudent.Size = new System.Drawing.Size(206, 103);
            this.Btn_MapStudent.TabIndex = 62;
            this.Btn_MapStudent.Text = "Map Student to Class";
            this.Btn_MapStudent.UseVisualStyleBackColor = false;
            this.Btn_MapStudent.Click += new System.EventHandler(this.Btn_MapStudent_Click);
            // 
            // ComboBoxStudent
            // 
            this.ComboBoxStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboBoxStudent.FormattingEnabled = true;
            this.ComboBoxStudent.Location = new System.Drawing.Point(152, 90);
            this.ComboBoxStudent.Name = "ComboBoxStudent";
            this.ComboBoxStudent.Size = new System.Drawing.Size(238, 28);
            this.ComboBoxStudent.TabIndex = 59;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label1.Location = new System.Drawing.Point(12, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(134, 20);
            this.Label1.TabIndex = 58;
            this.Label1.Text = "Select Student:";
            // 
            // Dgv_AddSubjectToClass
            // 
            this.Dgv_AddSubjectToClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_AddSubjectToClass.Location = new System.Drawing.Point(415, 32);
            this.Dgv_AddSubjectToClass.Name = "Dgv_AddSubjectToClass";
            this.Dgv_AddSubjectToClass.Size = new System.Drawing.Size(369, 386);
            this.Dgv_AddSubjectToClass.TabIndex = 55;
            // 
            // MapStudentToClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_MapStudent);
            this.Controls.Add(this.ComboBoxStudent);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Dgv_AddSubjectToClass);
            this.Name = "MapStudentToClass";
            this.Text = "MapStudentToClass";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AddSubjectToClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Btn_MapStudent;
        internal System.Windows.Forms.ComboBox ComboBoxStudent;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView Dgv_AddSubjectToClass;
    }
}