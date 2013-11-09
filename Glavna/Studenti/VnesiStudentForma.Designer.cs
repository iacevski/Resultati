namespace Studenti
{
    partial class VnesiStudentForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndeks = new System.Windows.Forms.TextBox();
            this.btnVnesiStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Индекс";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(102, 41);
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.Size = new System.Drawing.Size(203, 20);
            this.txtIndeks.TabIndex = 1;
            // 
            // btnVnesiStudent
            // 
            this.btnVnesiStudent.Location = new System.Drawing.Point(214, 138);
            this.btnVnesiStudent.Name = "btnVnesiStudent";
            this.btnVnesiStudent.Size = new System.Drawing.Size(91, 35);
            this.btnVnesiStudent.TabIndex = 2;
            this.btnVnesiStudent.Text = "Внеси";
            this.btnVnesiStudent.UseVisualStyleBackColor = true;
            this.btnVnesiStudent.Click += new System.EventHandler(this.btnVnesiStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Презиме и име";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(102, 78);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(203, 20);
            this.txtIme.TabIndex = 4;
            // 
            // VnesiStudentForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 185);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVnesiStudent);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.label1);
            this.Name = "VnesiStudentForma";
            this.Text = "Внеси студент";
            this.Load += new System.EventHandler(this.VnesiStudentForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndeks;
        private System.Windows.Forms.Button btnVnesiStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
    }
}