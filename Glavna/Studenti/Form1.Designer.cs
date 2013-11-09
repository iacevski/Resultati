namespace Studenti
{
    partial class Form1
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
            this.btnVnesiNovStudent = new System.Windows.Forms.Button();
            this.btnVnesiNovPredmet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVnesiNovStudent
            // 
            this.btnVnesiNovStudent.Location = new System.Drawing.Point(23, 22);
            this.btnVnesiNovStudent.Name = "btnVnesiNovStudent";
            this.btnVnesiNovStudent.Size = new System.Drawing.Size(141, 23);
            this.btnVnesiNovStudent.TabIndex = 0;
            this.btnVnesiNovStudent.Text = "Внеси нов студент";
            this.btnVnesiNovStudent.UseVisualStyleBackColor = true;
            this.btnVnesiNovStudent.Click += new System.EventHandler(this.btnVnesiNovStudent_Click);
            // 
            // btnVnesiNovPredmet
            // 
            this.btnVnesiNovPredmet.Location = new System.Drawing.Point(23, 52);
            this.btnVnesiNovPredmet.Name = "btnVnesiNovPredmet";
            this.btnVnesiNovPredmet.Size = new System.Drawing.Size(141, 23);
            this.btnVnesiNovPredmet.TabIndex = 1;
            this.btnVnesiNovPredmet.Text = "Внеси нов предмет";
            this.btnVnesiNovPredmet.UseVisualStyleBackColor = true;
            this.btnVnesiNovPredmet.Click += new System.EventHandler(this.btnVnesiNovPredmet_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 319);
            this.Controls.Add(this.btnVnesiNovPredmet);
            this.Controls.Add(this.btnVnesiNovStudent);
            this.Name = "Form1";
            this.Text = "Резултати од испити";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVnesiNovStudent;
        private System.Windows.Forms.Button btnVnesiNovPredmet;
    }
}

