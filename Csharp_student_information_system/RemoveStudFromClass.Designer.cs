
namespace OMP_Epupil
{
    partial class RemoveStudFromClass
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
            this.DataGridViewSubToClass = new System.Windows.Forms.DataGridView();
            this.ButtonRemoveStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubToClass)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewSubToClass
            // 
            this.DataGridViewSubToClass.AllowUserToAddRows = false;
            this.DataGridViewSubToClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewSubToClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSubToClass.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewSubToClass.Name = "DataGridViewSubToClass";
            this.DataGridViewSubToClass.Size = new System.Drawing.Size(633, 371);
            this.DataGridViewSubToClass.TabIndex = 48;
            // 
            // ButtonRemoveStudent
            // 
            this.ButtonRemoveStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.ButtonRemoveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveStudent.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoveStudent.Location = new System.Drawing.Point(37, 389);
            this.ButtonRemoveStudent.Name = "ButtonRemoveStudent";
            this.ButtonRemoveStudent.Size = new System.Drawing.Size(577, 40);
            this.ButtonRemoveStudent.TabIndex = 47;
            this.ButtonRemoveStudent.Text = "Remove Student";
            this.ButtonRemoveStudent.UseVisualStyleBackColor = false;
            this.ButtonRemoveStudent.Click += new System.EventHandler(this.ButtonRemoveStudent_Click);
            // 
            // RemoveStudFromClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 441);
            this.Controls.Add(this.DataGridViewSubToClass);
            this.Controls.Add(this.ButtonRemoveStudent);
            this.Name = "RemoveStudFromClass";
            this.Text = "RemoveStudFromClass";
            this.Load += new System.EventHandler(this.RemoveStudFromClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubToClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridViewSubToClass;
        internal System.Windows.Forms.Button ButtonRemoveStudent;
    }
}