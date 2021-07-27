
namespace OMP_Epupil
{
    partial class AddSubjectToClass
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
            this.Dgv_AddSubjectToClass = new System.Windows.Forms.DataGridView();
            this.TextBoxClassID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.MapSubjecttoClass = new System.Windows.Forms.Button();
            this.TextBoxSection = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AddSubjectToClass)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_AddSubjectToClass
            // 
            this.Dgv_AddSubjectToClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_AddSubjectToClass.Location = new System.Drawing.Point(410, 30);
            this.Dgv_AddSubjectToClass.Name = "Dgv_AddSubjectToClass";
            this.Dgv_AddSubjectToClass.Size = new System.Drawing.Size(369, 386);
            this.Dgv_AddSubjectToClass.TabIndex = 0;
            this.Dgv_AddSubjectToClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_AddSubjectToClass_CellClick);
            // 
            // TextBoxClassID
            // 
            this.TextBoxClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxClassID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxClassID.Location = new System.Drawing.Point(148, 51);
            this.TextBoxClassID.Name = "TextBoxClassID";
            this.TextBoxClassID.ReadOnly = true;
            this.TextBoxClassID.Size = new System.Drawing.Size(120, 26);
            this.TextBoxClassID.TabIndex = 49;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label2.Location = new System.Drawing.Point(34, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 20);
            this.Label2.TabIndex = 48;
            this.Label2.Text = "Class Name:";
            // 
            // ComboBoxSubjects
            // 
            this.ComboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSubjects.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboBoxSubjects.FormattingEnabled = true;
            this.ComboBoxSubjects.Location = new System.Drawing.Point(147, 164);
            this.ComboBoxSubjects.Name = "ComboBoxSubjects";
            this.ComboBoxSubjects.Size = new System.Drawing.Size(238, 28);
            this.ComboBoxSubjects.TabIndex = 51;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label1.Location = new System.Drawing.Point(12, 164);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 20);
            this.Label1.TabIndex = 50;
            this.Label1.Text = "Select Subject:";
            // 
            // MapSubjecttoClass
            // 
            this.MapSubjecttoClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.MapSubjecttoClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MapSubjecttoClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapSubjecttoClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapSubjecttoClass.ForeColor = System.Drawing.Color.White;
            this.MapSubjecttoClass.Location = new System.Drawing.Point(95, 242);
            this.MapSubjecttoClass.Name = "MapSubjecttoClass";
            this.MapSubjecttoClass.Size = new System.Drawing.Size(206, 103);
            this.MapSubjecttoClass.TabIndex = 54;
            this.MapSubjecttoClass.Text = "Map Subject to Class";
            this.MapSubjecttoClass.UseVisualStyleBackColor = false;
            this.MapSubjecttoClass.Click += new System.EventHandler(this.MapSubjecttoClass_Click);
            // 
            // TextBoxSection
            // 
            this.TextBoxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSection.Location = new System.Drawing.Point(149, 106);
            this.TextBoxSection.Multiline = true;
            this.TextBoxSection.Name = "TextBoxSection";
            this.TextBoxSection.Size = new System.Drawing.Size(66, 32);
            this.TextBoxSection.TabIndex = 53;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(68, 106);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 20);
            this.Label3.TabIndex = 52;
            this.Label3.Text = "Section:";
            // 
            // AddSubjectToClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 441);
            this.Controls.Add(this.MapSubjecttoClass);
            this.Controls.Add(this.TextBoxSection);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ComboBoxSubjects);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBoxClassID);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Dgv_AddSubjectToClass);
            this.Name = "AddSubjectToClass";
            this.Text = "AddSubjectToClass";
            this.Load += new System.EventHandler(this.AddSubjectToClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AddSubjectToClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView Dgv_AddSubjectToClass;
        internal System.Windows.Forms.TextBox TextBoxClassID;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox ComboBoxSubjects;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button MapSubjecttoClass;
        internal System.Windows.Forms.TextBox TextBoxSection;
        internal System.Windows.Forms.Label Label3;
    }
}