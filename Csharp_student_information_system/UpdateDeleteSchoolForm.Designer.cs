
namespace Csharp_student_information_system
{
    partial class UpdateDeleteSchoolForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SchhoolName = new System.Windows.Forms.TextBox();
            this.txt_SchhoolAddress = new System.Windows.Forms.TextBox();
            this.txt_SchhoolPhone = new System.Windows.Forms.TextBox();
            this.txt_SchhoolWeb = new System.Windows.Forms.TextBox();
            this.txt_SchhoolMail = new System.Windows.Forms.TextBox();
            this.Btn_SchoolUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Cmb_SchoolId = new System.Windows.Forms.ComboBox();
            this.student_DBDataSet = new Csharp_student_information_system.Student_DBDataSet();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolTableAdapter = new Csharp_student_information_system.Student_DBDataSetTableAdapters.SchoolTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.student_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCHOOL INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCHOOL NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "PHONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "WEB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-MAIL";
            // 
            // txt_SchhoolName
            // 
            this.txt_SchhoolName.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SchhoolName.Location = new System.Drawing.Point(267, 112);
            this.txt_SchhoolName.Name = "txt_SchhoolName";
            this.txt_SchhoolName.Size = new System.Drawing.Size(504, 36);
            this.txt_SchhoolName.TabIndex = 6;
            // 
            // txt_SchhoolAddress
            // 
            this.txt_SchhoolAddress.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SchhoolAddress.Location = new System.Drawing.Point(267, 159);
            this.txt_SchhoolAddress.Multiline = true;
            this.txt_SchhoolAddress.Name = "txt_SchhoolAddress";
            this.txt_SchhoolAddress.Size = new System.Drawing.Size(504, 85);
            this.txt_SchhoolAddress.TabIndex = 7;
            // 
            // txt_SchhoolPhone
            // 
            this.txt_SchhoolPhone.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SchhoolPhone.Location = new System.Drawing.Point(267, 250);
            this.txt_SchhoolPhone.Name = "txt_SchhoolPhone";
            this.txt_SchhoolPhone.Size = new System.Drawing.Size(504, 36);
            this.txt_SchhoolPhone.TabIndex = 8;
            // 
            // txt_SchhoolWeb
            // 
            this.txt_SchhoolWeb.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SchhoolWeb.Location = new System.Drawing.Point(267, 292);
            this.txt_SchhoolWeb.Name = "txt_SchhoolWeb";
            this.txt_SchhoolWeb.Size = new System.Drawing.Size(504, 36);
            this.txt_SchhoolWeb.TabIndex = 9;
            // 
            // txt_SchhoolMail
            // 
            this.txt_SchhoolMail.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SchhoolMail.Location = new System.Drawing.Point(267, 344);
            this.txt_SchhoolMail.Name = "txt_SchhoolMail";
            this.txt_SchhoolMail.Size = new System.Drawing.Size(504, 36);
            this.txt_SchhoolMail.TabIndex = 10;
            // 
            // Btn_SchoolUpdate
            // 
            this.Btn_SchoolUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_SchoolUpdate.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SchoolUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_SchoolUpdate.Location = new System.Drawing.Point(406, 393);
            this.Btn_SchoolUpdate.Name = "Btn_SchoolUpdate";
            this.Btn_SchoolUpdate.Size = new System.Drawing.Size(210, 45);
            this.Btn_SchoolUpdate.TabIndex = 11;
            this.Btn_SchoolUpdate.Text = "UPDATE";
            this.Btn_SchoolUpdate.UseVisualStyleBackColor = false;
            this.Btn_SchoolUpdate.Click += new System.EventHandler(this.Btn_SchoolUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID";
            // 
            // Cmb_SchoolId
            // 
            this.Cmb_SchoolId.FormattingEnabled = true;
            this.Cmb_SchoolId.Location = new System.Drawing.Point(530, 73);
            this.Cmb_SchoolId.Name = "Cmb_SchoolId";
            this.Cmb_SchoolId.Size = new System.Drawing.Size(121, 21);
            this.Cmb_SchoolId.TabIndex = 13;
            // 
            // student_DBDataSet
            // 
            this.student_DBDataSet.DataSetName = "Student_DBDataSet";
            this.student_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataMember = "School";
            this.schoolBindingSource.DataSource = this.student_DBDataSet;
            // 
            // schoolTableAdapter
            // 
            this.schoolTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateDeleteSchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cmb_SchoolId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_SchoolUpdate);
            this.Controls.Add(this.txt_SchhoolMail);
            this.Controls.Add(this.txt_SchhoolWeb);
            this.Controls.Add(this.txt_SchhoolPhone);
            this.Controls.Add(this.txt_SchhoolAddress);
            this.Controls.Add(this.txt_SchhoolName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDeleteSchoolForm";
            this.Text = "SCHOOL";
            this.Load += new System.EventHandler(this.UpdateDeleteSchoolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SchhoolName;
        private System.Windows.Forms.TextBox txt_SchhoolAddress;
        private System.Windows.Forms.TextBox txt_SchhoolPhone;
        private System.Windows.Forms.TextBox txt_SchhoolWeb;
        private System.Windows.Forms.TextBox txt_SchhoolMail;
        private System.Windows.Forms.Button Btn_SchoolUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cmb_SchoolId;
        private Student_DBDataSet student_DBDataSet;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private Student_DBDataSetTableAdapters.SchoolTableAdapter schoolTableAdapter;
    }
}