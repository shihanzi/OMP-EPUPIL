namespace Csharp_student_information_system
{
    partial class avgScoreByCourseForm
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
            this.DataGridViewAvgScore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAvgScore)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewAvgScore
            // 
            this.DataGridViewAvgScore.AllowUserToAddRows = false;
            this.DataGridViewAvgScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewAvgScore.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.DataGridViewAvgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAvgScore.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewAvgScore.Name = "DataGridViewAvgScore";
            this.DataGridViewAvgScore.Size = new System.Drawing.Size(260, 238);
            this.DataGridViewAvgScore.TabIndex = 46;
            // 
            // avgScoreByCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(282, 262);
            this.Controls.Add(this.DataGridViewAvgScore);
            this.Name = "avgScoreByCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "avgScoreByCourseForm";
            this.Load += new System.EventHandler(this.avgScoreByCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAvgScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridViewAvgScore;
    }
}