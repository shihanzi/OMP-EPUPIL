namespace OMP_Epupil
{
    partial class PrintScoresForm
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
            this.ButtonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentsScore)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewStudentsScore
            // 
            this.DataGridViewStudentsScore.AllowUserToAddRows = false;
            this.DataGridViewStudentsScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudentsScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudentsScore.Location = new System.Drawing.Point(28, 12);
            this.DataGridViewStudentsScore.Name = "DataGridViewStudentsScore";
            this.DataGridViewStudentsScore.Size = new System.Drawing.Size(763, 411);
            this.DataGridViewStudentsScore.TabIndex = 60;
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrint.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrint.ForeColor = System.Drawing.Color.White;
            this.ButtonPrint.Location = new System.Drawing.Point(620, 439);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(171, 53);
            this.ButtonPrint.TabIndex = 63;
            this.ButtonPrint.Text = "Export To Excel";
            this.ButtonPrint.UseVisualStyleBackColor = false;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // PrintScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(807, 504);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.DataGridViewStudentsScore);
            this.Name = "PrintScoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintScoresForm";
            this.Load += new System.EventHandler(this.PrintScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentsScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridViewStudentsScore;
        internal System.Windows.Forms.Button ButtonPrint;
    }
}