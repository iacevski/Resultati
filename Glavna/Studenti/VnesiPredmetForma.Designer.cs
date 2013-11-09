namespace Studenti
{
    partial class VnesiPredmetForma
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
            this.txtSemestar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImePredmet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVnesiPredmet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSemestar
            // 
            this.txtSemestar.CausesValidation = false;
            this.txtSemestar.Location = new System.Drawing.Point(103, 77);
            this.txtSemestar.Name = "txtSemestar";
            this.txtSemestar.Size = new System.Drawing.Size(203, 20);
            this.txtSemestar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Семестар";
            // 
            // txtImePredmet
            // 
            this.txtImePredmet.Location = new System.Drawing.Point(103, 40);
            this.txtImePredmet.Name = "txtImePredmet";
            this.txtImePredmet.Size = new System.Drawing.Size(203, 20);
            this.txtImePredmet.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Име на предмет";
            // 
            // btnVnesiPredmet
            // 
            this.btnVnesiPredmet.Location = new System.Drawing.Point(215, 138);
            this.btnVnesiPredmet.Name = "btnVnesiPredmet";
            this.btnVnesiPredmet.Size = new System.Drawing.Size(91, 35);
            this.btnVnesiPredmet.TabIndex = 9;
            this.btnVnesiPredmet.Text = "Внеси";
            this.btnVnesiPredmet.UseVisualStyleBackColor = true;
            this.btnVnesiPredmet.Click += new System.EventHandler(this.btnVnesiPredmet_Click);
            // 
            // VnesiPredmetForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 185);
            this.Controls.Add(this.btnVnesiPredmet);
            this.Controls.Add(this.txtSemestar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImePredmet);
            this.Controls.Add(this.label1);
            this.Name = "VnesiPredmetForma";
            this.Text = "Внеси нов предмет";
            this.Load += new System.EventHandler(this.VnesiPredmetForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSemestar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImePredmet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVnesiPredmet;

    }
}