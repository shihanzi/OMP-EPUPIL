
namespace OMP_Epupil
{
    partial class AddClassForm
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxClassName = new System.Windows.Forms.TextBox();
            this.TextBoxSection = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.ButtonAddClass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(38, 164);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(102, 22);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Description:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(68, 119);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 22);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Section:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(85, 78);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 22);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Class:";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TextBoxClassName
            // 
            this.TextBoxClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxClassName.Location = new System.Drawing.Point(144, 78);
            this.TextBoxClassName.Name = "TextBoxClassName";
            this.TextBoxClassName.Size = new System.Drawing.Size(237, 26);
            this.TextBoxClassName.TabIndex = 23;
            // 
            // TextBoxSection
            // 
            this.TextBoxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSection.Location = new System.Drawing.Point(144, 119);
            this.TextBoxSection.Name = "TextBoxSection";
            this.TextBoxSection.Size = new System.Drawing.Size(48, 26);
            this.TextBoxSection.TabIndex = 24;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(144, 164);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(237, 80);
            this.TextBoxDescription.TabIndex = 25;
            // 
            // ButtonAddClass
            // 
            this.ButtonAddClass.BackColor = System.Drawing.Color.Lime;
            this.ButtonAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddClass.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddClass.ForeColor = System.Drawing.Color.White;
            this.ButtonAddClass.Location = new System.Drawing.Point(17, 298);
            this.ButtonAddClass.Name = "ButtonAddClass";
            this.ButtonAddClass.Size = new System.Drawing.Size(375, 40);
            this.ButtonAddClass.TabIndex = 26;
            this.ButtonAddClass.Text = "Add";
            this.ButtonAddClass.UseVisualStyleBackColor = false;
            this.ButtonAddClass.Click += new System.EventHandler(this.ButtonAddCourse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(139, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ad A Class";
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(408, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonAddClass);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxSection);
            this.Controls.Add(this.TextBoxClassName);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "AddClassForm";
            this.Text = "AddClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBoxClassName;
        internal System.Windows.Forms.TextBox TextBoxSection;
        internal System.Windows.Forms.TextBox TextBoxDescription;
        internal System.Windows.Forms.Button ButtonAddClass;
        internal System.Windows.Forms.Label label4;
    }
}