
namespace OMP_Epupil
{
    partial class SubForm
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
            this.Btn_MapSubjectToClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_MapSubjectToClass
            // 
            this.Btn_MapSubjectToClass.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MapSubjectToClass.Location = new System.Drawing.Point(101, 158);
            this.Btn_MapSubjectToClass.Name = "Btn_MapSubjectToClass";
            this.Btn_MapSubjectToClass.Size = new System.Drawing.Size(172, 28);
            this.Btn_MapSubjectToClass.TabIndex = 0;
            this.Btn_MapSubjectToClass.Text = "Map Subject";
            this.Btn_MapSubjectToClass.UseVisualStyleBackColor = true;
            this.Btn_MapSubjectToClass.Click += new System.EventHandler(this.Btn_MapSubjectToClass_Click);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 467);
            this.Controls.Add(this.Btn_MapSubjectToClass);
            this.Name = "SubForm";
            this.Text = "SubForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Btn_MapSubjectToClass;
    }
}