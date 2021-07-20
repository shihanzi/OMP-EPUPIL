
namespace OMP_Epupil
{
    partial class staffListForm
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
            this.Dgv_StaffList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_StaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_StaffList
            // 
            this.Dgv_StaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_StaffList.Location = new System.Drawing.Point(35, 40);
            this.Dgv_StaffList.Name = "Dgv_StaffList";
            this.Dgv_StaffList.Size = new System.Drawing.Size(834, 404);
            this.Dgv_StaffList.TabIndex = 0;
            this.Dgv_StaffList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_StaffList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "STAFF LIST";
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.Firebrick;
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Refresh.Location = new System.Drawing.Point(242, 450);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(468, 44);
            this.Btn_Refresh.TabIndex = 2;
            this.Btn_Refresh.Text = "REFRESH";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // staffListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(902, 499);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_StaffList);
            this.Name = "staffListForm";
            this.Text = "staffListForm";
            this.Load += new System.EventHandler(this.staffListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_StaffList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_StaffList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Refresh;
    }
}