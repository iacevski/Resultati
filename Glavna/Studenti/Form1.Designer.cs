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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPromeniImePredmet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVnesiNovStudent
            // 
            this.btnVnesiNovStudent.Location = new System.Drawing.Point(23, 22);
            this.btnVnesiNovStudent.Name = "btnVnesiNovStudent";
            this.btnVnesiNovStudent.Size = new System.Drawing.Size(149, 23);
            this.btnVnesiNovStudent.TabIndex = 0;
            this.btnVnesiNovStudent.Text = "Внеси нов студент";
            this.btnVnesiNovStudent.UseVisualStyleBackColor = true;
            this.btnVnesiNovStudent.Click += new System.EventHandler(this.btnVnesiNovStudent_Click);
            // 
            // btnVnesiNovPredmet
            // 
            this.btnVnesiNovPredmet.Location = new System.Drawing.Point(23, 52);
            this.btnVnesiNovPredmet.Name = "btnVnesiNovPredmet";
            this.btnVnesiNovPredmet.Size = new System.Drawing.Size(149, 23);
            this.btnVnesiNovPredmet.TabIndex = 1;
            this.btnVnesiNovPredmet.Text = "Внеси нов предмет";
            this.btnVnesiNovPredmet.UseVisualStyleBackColor = true;
            this.btnVnesiNovPredmet.Click += new System.EventHandler(this.btnVnesiNovPredmet_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Индекс > 8";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPromeniImePredmet
            // 
            this.btnPromeniImePredmet.Location = new System.Drawing.Point(25, 120);
            this.btnPromeniImePredmet.Name = "btnPromeniImePredmet";
            this.btnPromeniImePredmet.Size = new System.Drawing.Size(147, 24);
            this.btnPromeniImePredmet.TabIndex = 3;
            this.btnPromeniImePredmet.Text = "Промени име на предмет";
            this.btnPromeniImePredmet.UseVisualStyleBackColor = true;
            this.btnPromeniImePredmet.Click += new System.EventHandler(this.btnPromeniImePredmet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Избриши студенти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 319);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPromeniImePredmet);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPromeniImePredmet;
        private System.Windows.Forms.Button button2;
    }
}

