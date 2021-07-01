namespace Csharp_student_information_system
{
    partial class RemoveScoreForm
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
            this.DataGridViewStudentsScore = new System.Windows.Forms.DataGridView();
            this.ButtonRemoveScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentsScore)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewStudentsScore
            // 
            this.DataGridViewStudentsScore.AllowUserToAddRows = false;
            this.DataGridViewStudentsScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudentsScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudentsScore.Location = new System.Drawing.Point(29, 25);
            this.DataGridViewStudentsScore.Name = "DataGridViewStudentsScore";
            this.DataGridViewStudentsScore.Size = new System.Drawing.Size(584, 295);
            this.DataGridViewStudentsScore.TabIndex = 44;
            // 
            // ButtonRemoveScore
            // 
            this.ButtonRemoveScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.ButtonRemoveScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemoveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveScore.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoveScore.Location = new System.Drawing.Point(29, 326);
            this.ButtonRemoveScore.Name = "ButtonRemoveScore";
            this.ButtonRemoveScore.Size = new System.Drawing.Size(584, 40);
            this.ButtonRemoveScore.TabIndex = 43;
            this.ButtonRemoveScore.Text = "Remove Score";
            this.ButtonRemoveScore.UseVisualStyleBackColor = false;
            this.ButtonRemoveScore.Click += new System.EventHandler(this.ButtonRemoveScore_Click);
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(642, 391);
            this.Controls.Add(this.DataGridViewStudentsScore);
            this.Controls.Add(this.ButtonRemoveScore);
            this.Name = "RemoveScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveScoreForm";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentsScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridViewStudentsScore;
        internal System.Windows.Forms.Button ButtonRemoveScore;
    }
}