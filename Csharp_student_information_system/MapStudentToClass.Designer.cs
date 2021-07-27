
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
            this.ComboBoxStudentFirstName = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Dgv_AddStudentToClass = new System.Windows.Forms.DataGridView();
            this.TextBoxSection = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBoxClassID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboBoxStudentLastName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AddStudentToClass)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_MapStudent
            // 
            this.Btn_MapStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.Btn_MapStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MapStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MapStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MapStudent.ForeColor = System.Drawing.Color.White;
            this.Btn_MapStudent.Location = new System.Drawing.Point(152, 258);
            this.Btn_MapStudent.Name = "Btn_MapStudent";
            this.Btn_MapStudent.Size = new System.Drawing.Size(206, 103);
            this.Btn_MapStudent.TabIndex = 62;
            this.Btn_MapStudent.Text = "Add Student to Class";
            this.Btn_MapStudent.UseVisualStyleBackColor = false;
            this.Btn_MapStudent.Click += new System.EventHandler(this.Btn_MapStudent_Click);
            // 
            // ComboBoxStudentFirstName
            // 
            this.ComboBoxStudentFirstName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStudentFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStudentFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboBoxStudentFirstName.FormattingEnabled = true;
            this.ComboBoxStudentFirstName.Location = new System.Drawing.Point(152, 90);
            this.ComboBoxStudentFirstName.Name = "ComboBoxStudentFirstName";
            this.ComboBoxStudentFirstName.Size = new System.Drawing.Size(238, 28);
            this.ComboBoxStudentFirstName.TabIndex = 59;
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
            // Dgv_AddStudentToClass
            // 
            this.Dgv_AddStudentToClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_AddStudentToClass.Location = new System.Drawing.Point(415, 32);
            this.Dgv_AddStudentToClass.Name = "Dgv_AddStudentToClass";
            this.Dgv_AddStudentToClass.Size = new System.Drawing.Size(369, 386);
            this.Dgv_AddStudentToClass.TabIndex = 55;
            this.Dgv_AddStudentToClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_AddStudentToClass_CellClick);
            // 
            // TextBoxSection
            // 
            this.TextBoxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSection.Location = new System.Drawing.Point(153, 201);
            this.TextBoxSection.Multiline = true;
            this.TextBoxSection.Name = "TextBoxSection";
            this.TextBoxSection.ReadOnly = true;
            this.TextBoxSection.Size = new System.Drawing.Size(66, 32);
            this.TextBoxSection.TabIndex = 66;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(72, 204);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 20);
            this.Label3.TabIndex = 65;
            this.Label3.Text = "Section:";
            // 
            // TextBoxClassID
            // 
            this.TextBoxClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxClassID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxClassID.Location = new System.Drawing.Point(152, 158);
            this.TextBoxClassID.Name = "TextBoxClassID";
            this.TextBoxClassID.ReadOnly = true;
            this.TextBoxClassID.Size = new System.Drawing.Size(120, 26);
            this.TextBoxClassID.TabIndex = 64;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label2.Location = new System.Drawing.Point(38, 161);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 20);
            this.Label2.TabIndex = 63;
            this.Label2.Text = "Class Name:";
            // 
            // ComboBoxStudentLastName
            // 
            this.ComboBoxStudentLastName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStudentLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStudentLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboBoxStudentLastName.FormattingEnabled = true;
            this.ComboBoxStudentLastName.Location = new System.Drawing.Point(152, 124);
            this.ComboBoxStudentLastName.Name = "ComboBoxStudentLastName";
            this.ComboBoxStudentLastName.Size = new System.Drawing.Size(238, 28);
            this.ComboBoxStudentLastName.TabIndex = 67;
            // 
            // MapStudentToClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBoxStudentLastName);
            this.Controls.Add(this.TextBoxSection);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBoxClassID);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Btn_MapStudent);
            this.Controls.Add(this.ComboBoxStudentFirstName);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Dgv_AddStudentToClass);
            this.Name = "MapStudentToClass";
            this.Text = "MapStudentToClass";
            this.Load += new System.EventHandler(this.MapStudentToClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AddStudentToClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Btn_MapStudent;
        internal System.Windows.Forms.ComboBox ComboBoxStudentFirstName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView Dgv_AddStudentToClass;
        internal System.Windows.Forms.TextBox TextBoxSection;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBoxClassID;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox ComboBoxStudentLastName;
    }
}