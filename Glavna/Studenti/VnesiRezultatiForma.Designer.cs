namespace Studenti
{
    partial class VnesiRezultatiForma
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet = new Studenti._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Studenti._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSetTableAdapters.StudentsTableAdapter();
            this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetisTableAdapter = new Studenti._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSetTableAdapters.PredmetisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.predmetisBindingSource;
            this.comboBox1.DisplayMember = "PredmetName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "PredmetId";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.studentsBindingSource;
            this.comboBox2.DisplayMember = "StudentIndex";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(22, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "StudentName";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.studentsBindingSource;
            this.comboBox3.DisplayMember = "StudentName";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(124, 29);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(130, 21);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.ValueMember = "StudentId";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet
            // 
            this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.DataSetName = "_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet";
            this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource
            // 
            this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource.DataSource = this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet;
            this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource.Position = 0;
            // 
            // predmetisBindingSource
            // 
            this.predmetisBindingSource.DataMember = "Predmetis";
            this.predmetisBindingSource.DataSource = this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource;
            // 
            // predmetisTableAdapter
            // 
            this.predmetisTableAdapter.ClearBeforeFill = true;
            // 
            // VnesiRezultatiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 261);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "VnesiRezultatiForma";
            this.Text = "VnesiRezultatiForma";
            this.Load += new System.EventHandler(this.VnesiRezultatiForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource;
        private System.Windows.Forms.BindingSource predmetisBindingSource;
        private _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSetTableAdapters.PredmetisTableAdapter predmetisTableAdapter;
    }
}