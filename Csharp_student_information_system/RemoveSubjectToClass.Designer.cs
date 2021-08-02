
namespace OMP_Epupil
{
    partial class RemoveSubjectToClass
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
            this.ButtonRemoveMarks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubToClass)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewSubToClass
            // 
            this.DataGridViewSubToClass.AllowUserToAddRows = false;
            this.DataGridViewSubToClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewSubToClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSubToClass.Location = new System.Drawing.Point(22, 12);
            this.DataGridViewSubToClass.Name = "DataGridViewSubToClass";
            this.DataGridViewSubToClass.Size = new System.Drawing.Size(610, 318);
            this.DataGridViewSubToClass.TabIndex = 46;
            // 
            // ButtonRemoveMarks
            // 
            this.ButtonRemoveMarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.ButtonRemoveMarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemoveMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveMarks.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveMarks.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoveMarks.Location = new System.Drawing.Point(22, 336);
            this.ButtonRemoveMarks.Name = "ButtonRemoveMarks";
            this.ButtonRemoveMarks.Size = new System.Drawing.Size(610, 40);
            this.ButtonRemoveMarks.TabIndex = 45;
            this.ButtonRemoveMarks.Text = "Remove Subject";
            this.ButtonRemoveMarks.UseVisualStyleBackColor = false;
            this.ButtonRemoveMarks.Click += new System.EventHandler(this.ButtonRemoveMarks_Click);
            // 
            // RemoveSubjectToClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(655, 399);
            this.Controls.Add(this.DataGridViewSubToClass);
            this.Controls.Add(this.ButtonRemoveMarks);
            this.Name = "RemoveSubjectToClass";
            this.Text = "RemoveSubjectToClass";
            this.Load += new System.EventHandler(this.RemoveSubjectToClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubToClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridViewSubToClass;
        internal System.Windows.Forms.Button ButtonRemoveMarks;
    }
}