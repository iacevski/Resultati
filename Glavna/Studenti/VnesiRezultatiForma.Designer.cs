﻿namespace Studenti
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
            this.predmetisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet = new Studenti._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Studenti._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSetTableAdapters.StudentsTableAdapter();
            this.predmetisTableAdapter = new Studenti._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSetTableAdapters.PredmetisTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rezultatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1 = new Studenti._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1();
            this.rezultatsTableAdapter = new Studenti._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1TableAdapters.RezultatsTableAdapter();
            this.dateKol1 = new System.Windows.Forms.DateTimePicker();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblPrezimeIme = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.lblDatumIspit = new System.Windows.Forms.Label();
            this.txtPrezimeIme = new System.Windows.Forms.TextBox();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.txtDom1 = new System.Windows.Forms.TextBox();
            this.lblDom1 = new System.Windows.Forms.Label();
            this.txtDom2 = new System.Windows.Forms.TextBox();
            this.lblDom2 = new System.Windows.Forms.Label();
            this.txtSem = new System.Windows.Forms.TextBox();
            this.lblSem = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.lblPos = new System.Windows.Forms.Label();
            this.txtKol1 = new System.Windows.Forms.TextBox();
            this.txtKol2 = new System.Windows.Forms.TextBox();
            this.txtIspit = new System.Windows.Forms.TextBox();
            this.dateKol2 = new System.Windows.Forms.DateTimePicker();
            this.dateIspit = new System.Windows.Forms.DateTimePicker();
            this.lblKol1 = new System.Windows.Forms.Label();
            this.lblKol2 = new System.Windows.Forms.Label();
            this.lblIspit = new System.Windows.Forms.Label();
            this.chkUpl = new System.Windows.Forms.CheckBox();
            this.chkPri = new System.Windows.Forms.CheckBox();
            this.lblUcGod = new System.Windows.Forms.Label();
            this.txtUcGod = new System.Windows.Forms.TextBox();
            this.rezultatiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniDomasno1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniDomasno2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniSeminarskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniPosetenostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniIKolokviumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIKolokviumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniIIKolokviumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIIKolokviumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniIspitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIspitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijavaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uplatnicaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ucebnaGodinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.predmetisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezultatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.predmetisBindingSource;
            this.comboBox1.DisplayMember = "PredmetName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "PredmetId";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // predmetisBindingSource
            // 
            this.predmetisBindingSource.DataMember = "Predmetis";
            this.predmetisBindingSource.DataSource = this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource;
            // 
            // bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource
            // 
            this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource.DataSource = this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet;
            this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource.Position = 0;
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
            // predmetisTableAdapter
            // 
            this.predmetisTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezultatiIdDataGridViewTextBoxColumn,
            this.poeniDomasno1DataGridViewTextBoxColumn,
            this.poeniDomasno2DataGridViewTextBoxColumn,
            this.poeniSeminarskaDataGridViewTextBoxColumn,
            this.poeniPosetenostDataGridViewTextBoxColumn,
            this.poeniIKolokviumDataGridViewTextBoxColumn,
            this.dataIKolokviumDataGridViewTextBoxColumn,
            this.poeniIIKolokviumDataGridViewTextBoxColumn,
            this.dataIIKolokviumDataGridViewTextBoxColumn,
            this.poeniIspitDataGridViewTextBoxColumn,
            this.dataIspitDataGridViewTextBoxColumn,
            this.prijavaDataGridViewCheckBoxColumn,
            this.uplatnicaDataGridViewCheckBoxColumn,
            this.ucebnaGodinaDataGridViewTextBoxColumn,
            this.studIdDataGridViewTextBoxColumn,
            this.predIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezultatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(823, 128);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rezultatsBindingSource
            // 
            this.rezultatsBindingSource.DataMember = "Rezultats";
            this.rezultatsBindingSource.DataSource = this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1;
            // 
            // _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1
            // 
            this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.DataSetName = "_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1";
            this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezultatsTableAdapter
            // 
            this.rezultatsTableAdapter.ClearBeforeFill = true;
            // 
            // dateKol1
            // 
            this.dateKol1.Location = new System.Drawing.Point(404, 54);
            this.dateKol1.Name = "dateKol1";
            this.dateKol1.Size = new System.Drawing.Size(178, 20);
            this.dateKol1.TabIndex = 5;
            this.dateKol1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(221, 9);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(45, 13);
            this.lblIndex.TabIndex = 6;
            this.lblIndex.Text = "Индекс";
            this.lblIndex.Click += new System.EventHandler(this.lblIndex_Click);
            // 
            // lblPrezimeIme
            // 
            this.lblPrezimeIme.AutoSize = true;
            this.lblPrezimeIme.Location = new System.Drawing.Point(287, 12);
            this.lblPrezimeIme.Name = "lblPrezimeIme";
            this.lblPrezimeIme.Size = new System.Drawing.Size(85, 13);
            this.lblPrezimeIme.TabIndex = 7;
            this.lblPrezimeIme.Text = "Презиме и име";
            this.lblPrezimeIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(224, 28);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(51, 20);
            this.txtIndex.TabIndex = 8;
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Location = new System.Drawing.Point(16, 7);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(52, 13);
            this.lblPredmet.TabIndex = 9;
            this.lblPredmet.Text = "Предмет";
            // 
            // lblDatumIspit
            // 
            this.lblDatumIspit.AutoSize = true;
            this.lblDatumIspit.Location = new System.Drawing.Point(627, 28);
            this.lblDatumIspit.Name = "lblDatumIspit";
            this.lblDatumIspit.Size = new System.Drawing.Size(102, 13);
            this.lblDatumIspit.TabIndex = 10;
            this.lblDatumIspit.Text = "Дата на полагање";
            // 
            // txtPrezimeIme
            // 
            this.txtPrezimeIme.Location = new System.Drawing.Point(281, 28);
            this.txtPrezimeIme.Name = "txtPrezimeIme";
            this.txtPrezimeIme.Size = new System.Drawing.Size(108, 20);
            this.txtPrezimeIme.TabIndex = 11;
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Location = new System.Drawing.Point(12, 100);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(57, 13);
            this.lblPoeni.TabIndex = 12;
            this.lblPoeni.Text = "Поени од:";
            this.lblPoeni.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtDom1
            // 
            this.txtDom1.Location = new System.Drawing.Point(75, 100);
            this.txtDom1.Name = "txtDom1";
            this.txtDom1.Size = new System.Drawing.Size(67, 20);
            this.txtDom1.TabIndex = 13;
            // 
            // lblDom1
            // 
            this.lblDom1.AutoSize = true;
            this.lblDom1.Location = new System.Drawing.Point(75, 86);
            this.lblDom1.Name = "lblDom1";
            this.lblDom1.Size = new System.Drawing.Size(65, 13);
            this.lblDom1.TabIndex = 14;
            this.lblDom1.Text = "Домашна 1";
            // 
            // txtDom2
            // 
            this.txtDom2.Location = new System.Drawing.Point(157, 99);
            this.txtDom2.Name = "txtDom2";
            this.txtDom2.Size = new System.Drawing.Size(68, 20);
            this.txtDom2.TabIndex = 15;
            // 
            // lblDom2
            // 
            this.lblDom2.AutoSize = true;
            this.lblDom2.Location = new System.Drawing.Point(157, 86);
            this.lblDom2.Name = "lblDom2";
            this.lblDom2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDom2.Size = new System.Drawing.Size(65, 13);
            this.lblDom2.TabIndex = 16;
            this.lblDom2.Text = "Домашна 2";
            this.lblDom2.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtSem
            // 
            this.txtSem.Location = new System.Drawing.Point(244, 99);
            this.txtSem.Name = "txtSem";
            this.txtSem.Size = new System.Drawing.Size(73, 20);
            this.txtSem.TabIndex = 17;
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.Location = new System.Drawing.Point(241, 86);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(70, 13);
            this.lblSem.TabIndex = 18;
            this.lblSem.Text = "Семинарска";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(328, 99);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(77, 20);
            this.txtPos.TabIndex = 19;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(325, 86);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(67, 13);
            this.lblPos.TabIndex = 20;
            this.lblPos.Text = "Посетеност";
            // 
            // txtKol1
            // 
            this.txtKol1.Location = new System.Drawing.Point(431, 99);
            this.txtKol1.Name = "txtKol1";
            this.txtKol1.Size = new System.Drawing.Size(124, 20);
            this.txtKol1.TabIndex = 21;
            // 
            // txtKol2
            // 
            this.txtKol2.Location = new System.Drawing.Point(611, 100);
            this.txtKol2.Name = "txtKol2";
            this.txtKol2.Size = new System.Drawing.Size(131, 20);
            this.txtKol2.TabIndex = 22;
            // 
            // txtIspit
            // 
            this.txtIspit.Location = new System.Drawing.Point(803, 99);
            this.txtIspit.Name = "txtIspit";
            this.txtIspit.Size = new System.Drawing.Size(124, 20);
            this.txtIspit.TabIndex = 23;
            // 
            // dateKol2
            // 
            this.dateKol2.Location = new System.Drawing.Point(588, 54);
            this.dateKol2.Name = "dateKol2";
            this.dateKol2.Size = new System.Drawing.Size(179, 20);
            this.dateKol2.TabIndex = 24;
            // 
            // dateIspit
            // 
            this.dateIspit.Location = new System.Drawing.Point(773, 54);
            this.dateIspit.Name = "dateIspit";
            this.dateIspit.Size = new System.Drawing.Size(182, 20);
            this.dateIspit.TabIndex = 25;
            // 
            // lblKol1
            // 
            this.lblKol1.AutoSize = true;
            this.lblKol1.Location = new System.Drawing.Point(428, 86);
            this.lblKol1.Name = "lblKol1";
            this.lblKol1.Size = new System.Drawing.Size(71, 13);
            this.lblKol1.TabIndex = 26;
            this.lblKol1.Text = "1 колоквиум";
            // 
            // lblKol2
            // 
            this.lblKol2.AutoSize = true;
            this.lblKol2.Location = new System.Drawing.Point(608, 86);
            this.lblKol2.Name = "lblKol2";
            this.lblKol2.Size = new System.Drawing.Size(71, 13);
            this.lblKol2.TabIndex = 27;
            this.lblKol2.Text = "2 колоквиум";
            // 
            // lblIspit
            // 
            this.lblIspit.AutoSize = true;
            this.lblIspit.Location = new System.Drawing.Point(800, 86);
            this.lblIspit.Name = "lblIspit";
            this.lblIspit.Size = new System.Drawing.Size(38, 13);
            this.lblIspit.TabIndex = 28;
            this.lblIspit.Text = "Испит";
            // 
            // chkUpl
            // 
            this.chkUpl.AutoSize = true;
            this.chkUpl.Location = new System.Drawing.Point(94, 152);
            this.chkUpl.Name = "chkUpl";
            this.chkUpl.Size = new System.Drawing.Size(81, 17);
            this.chkUpl.TabIndex = 29;
            this.chkUpl.Text = "Уплатница";
            this.chkUpl.UseVisualStyleBackColor = true;
            // 
            // chkPri
            // 
            this.chkPri.AutoSize = true;
            this.chkPri.Location = new System.Drawing.Point(204, 153);
            this.chkPri.Name = "chkPri";
            this.chkPri.Size = new System.Drawing.Size(66, 17);
            this.chkPri.TabIndex = 30;
            this.chkPri.Text = "Пријава";
            this.chkPri.UseVisualStyleBackColor = true;
            // 
            // lblUcGod
            // 
            this.lblUcGod.AutoSize = true;
            this.lblUcGod.Location = new System.Drawing.Point(295, 139);
            this.lblUcGod.Name = "lblUcGod";
            this.lblUcGod.Size = new System.Drawing.Size(82, 13);
            this.lblUcGod.TabIndex = 31;
            this.lblUcGod.Text = "Учебна година";
            // 
            // txtUcGod
            // 
            this.txtUcGod.Location = new System.Drawing.Point(298, 155);
            this.txtUcGod.Name = "txtUcGod";
            this.txtUcGod.Size = new System.Drawing.Size(106, 20);
            this.txtUcGod.TabIndex = 32;
            this.txtUcGod.Text = "2013/2014";
            // 
            // rezultatiIdDataGridViewTextBoxColumn
            // 
            this.rezultatiIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rezultatiIdDataGridViewTextBoxColumn.DataPropertyName = "RezultatiId";
            this.rezultatiIdDataGridViewTextBoxColumn.HeaderText = "RezultatiId";
            this.rezultatiIdDataGridViewTextBoxColumn.Name = "rezultatiIdDataGridViewTextBoxColumn";
            this.rezultatiIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezultatiIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // poeniDomasno1DataGridViewTextBoxColumn
            // 
            this.poeniDomasno1DataGridViewTextBoxColumn.DataPropertyName = "PoeniDomasno1";
            this.poeniDomasno1DataGridViewTextBoxColumn.HeaderText = "PoeniDomasno1";
            this.poeniDomasno1DataGridViewTextBoxColumn.Name = "poeniDomasno1DataGridViewTextBoxColumn";
            this.poeniDomasno1DataGridViewTextBoxColumn.Width = 50;
            // 
            // poeniDomasno2DataGridViewTextBoxColumn
            // 
            this.poeniDomasno2DataGridViewTextBoxColumn.DataPropertyName = "PoeniDomasno2";
            this.poeniDomasno2DataGridViewTextBoxColumn.HeaderText = "PoeniDomasno2";
            this.poeniDomasno2DataGridViewTextBoxColumn.Name = "poeniDomasno2DataGridViewTextBoxColumn";
            this.poeniDomasno2DataGridViewTextBoxColumn.Width = 50;
            // 
            // poeniSeminarskaDataGridViewTextBoxColumn
            // 
            this.poeniSeminarskaDataGridViewTextBoxColumn.DataPropertyName = "PoeniSeminarska";
            this.poeniSeminarskaDataGridViewTextBoxColumn.HeaderText = "PoeniSeminarska";
            this.poeniSeminarskaDataGridViewTextBoxColumn.Name = "poeniSeminarskaDataGridViewTextBoxColumn";
            this.poeniSeminarskaDataGridViewTextBoxColumn.Width = 50;
            // 
            // poeniPosetenostDataGridViewTextBoxColumn
            // 
            this.poeniPosetenostDataGridViewTextBoxColumn.DataPropertyName = "PoeniPosetenost";
            this.poeniPosetenostDataGridViewTextBoxColumn.HeaderText = "PoeniPosetenost";
            this.poeniPosetenostDataGridViewTextBoxColumn.Name = "poeniPosetenostDataGridViewTextBoxColumn";
            this.poeniPosetenostDataGridViewTextBoxColumn.Width = 50;
            // 
            // poeniIKolokviumDataGridViewTextBoxColumn
            // 
            this.poeniIKolokviumDataGridViewTextBoxColumn.DataPropertyName = "PoeniIKolokvium";
            this.poeniIKolokviumDataGridViewTextBoxColumn.HeaderText = "PoeniIKolokvium";
            this.poeniIKolokviumDataGridViewTextBoxColumn.Name = "poeniIKolokviumDataGridViewTextBoxColumn";
            this.poeniIKolokviumDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataIKolokviumDataGridViewTextBoxColumn
            // 
            this.dataIKolokviumDataGridViewTextBoxColumn.DataPropertyName = "DataIKolokvium";
            this.dataIKolokviumDataGridViewTextBoxColumn.HeaderText = "DataIKolokvium";
            this.dataIKolokviumDataGridViewTextBoxColumn.Name = "dataIKolokviumDataGridViewTextBoxColumn";
            this.dataIKolokviumDataGridViewTextBoxColumn.Width = 50;
            // 
            // poeniIIKolokviumDataGridViewTextBoxColumn
            // 
            this.poeniIIKolokviumDataGridViewTextBoxColumn.DataPropertyName = "PoeniIIKolokvium";
            this.poeniIIKolokviumDataGridViewTextBoxColumn.HeaderText = "PoeniIIKolokvium";
            this.poeniIIKolokviumDataGridViewTextBoxColumn.Name = "poeniIIKolokviumDataGridViewTextBoxColumn";
            this.poeniIIKolokviumDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataIIKolokviumDataGridViewTextBoxColumn
            // 
            this.dataIIKolokviumDataGridViewTextBoxColumn.DataPropertyName = "DataIIKolokvium";
            this.dataIIKolokviumDataGridViewTextBoxColumn.HeaderText = "DataIIKolokvium";
            this.dataIIKolokviumDataGridViewTextBoxColumn.Name = "dataIIKolokviumDataGridViewTextBoxColumn";
            this.dataIIKolokviumDataGridViewTextBoxColumn.Width = 50;
            // 
            // poeniIspitDataGridViewTextBoxColumn
            // 
            this.poeniIspitDataGridViewTextBoxColumn.DataPropertyName = "PoeniIspit";
            this.poeniIspitDataGridViewTextBoxColumn.HeaderText = "PoeniIspit";
            this.poeniIspitDataGridViewTextBoxColumn.Name = "poeniIspitDataGridViewTextBoxColumn";
            this.poeniIspitDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataIspitDataGridViewTextBoxColumn
            // 
            this.dataIspitDataGridViewTextBoxColumn.DataPropertyName = "DataIspit";
            this.dataIspitDataGridViewTextBoxColumn.HeaderText = "DataIspit";
            this.dataIspitDataGridViewTextBoxColumn.Name = "dataIspitDataGridViewTextBoxColumn";
            this.dataIspitDataGridViewTextBoxColumn.Width = 50;
            // 
            // prijavaDataGridViewCheckBoxColumn
            // 
            this.prijavaDataGridViewCheckBoxColumn.DataPropertyName = "Prijava";
            this.prijavaDataGridViewCheckBoxColumn.HeaderText = "Prijava";
            this.prijavaDataGridViewCheckBoxColumn.Name = "prijavaDataGridViewCheckBoxColumn";
            this.prijavaDataGridViewCheckBoxColumn.Width = 50;
            // 
            // uplatnicaDataGridViewCheckBoxColumn
            // 
            this.uplatnicaDataGridViewCheckBoxColumn.DataPropertyName = "Uplatnica";
            this.uplatnicaDataGridViewCheckBoxColumn.HeaderText = "Uplatnica";
            this.uplatnicaDataGridViewCheckBoxColumn.Name = "uplatnicaDataGridViewCheckBoxColumn";
            this.uplatnicaDataGridViewCheckBoxColumn.Width = 50;
            // 
            // ucebnaGodinaDataGridViewTextBoxColumn
            // 
            this.ucebnaGodinaDataGridViewTextBoxColumn.DataPropertyName = "UcebnaGodina";
            this.ucebnaGodinaDataGridViewTextBoxColumn.HeaderText = "UcebnaGodina";
            this.ucebnaGodinaDataGridViewTextBoxColumn.Name = "ucebnaGodinaDataGridViewTextBoxColumn";
            this.ucebnaGodinaDataGridViewTextBoxColumn.Width = 50;
            // 
            // studIdDataGridViewTextBoxColumn
            // 
            this.studIdDataGridViewTextBoxColumn.DataPropertyName = "StudId";
            this.studIdDataGridViewTextBoxColumn.HeaderText = "StudId";
            this.studIdDataGridViewTextBoxColumn.Name = "studIdDataGridViewTextBoxColumn";
            this.studIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // predIdDataGridViewTextBoxColumn
            // 
            this.predIdDataGridViewTextBoxColumn.DataPropertyName = "PredId";
            this.predIdDataGridViewTextBoxColumn.HeaderText = "PredId";
            this.predIdDataGridViewTextBoxColumn.Name = "predIdDataGridViewTextBoxColumn";
            this.predIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // VnesiRezultatiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 321);
            this.Controls.Add(this.txtUcGod);
            this.Controls.Add(this.lblUcGod);
            this.Controls.Add(this.chkPri);
            this.Controls.Add(this.chkUpl);
            this.Controls.Add(this.lblIspit);
            this.Controls.Add(this.lblKol2);
            this.Controls.Add(this.lblKol1);
            this.Controls.Add(this.dateIspit);
            this.Controls.Add(this.dateKol2);
            this.Controls.Add(this.txtIspit);
            this.Controls.Add(this.txtKol2);
            this.Controls.Add(this.txtKol1);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.lblSem);
            this.Controls.Add(this.txtSem);
            this.Controls.Add(this.lblDom2);
            this.Controls.Add(this.txtDom2);
            this.Controls.Add(this.lblDom1);
            this.Controls.Add(this.txtDom1);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.txtPrezimeIme);
            this.Controls.Add(this.lblDatumIspit);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.lblPrezimeIme);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.dateKol1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "VnesiRezultatiForma";
            this.Text = "Внеси резултати";
            this.Load += new System.EventHandler(this.VnesiRezultatiForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predmetisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezultatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource bazaZaRezultatiOdIspitiBazaZaRezultatiOdIspitDataSetBindingSource;
        private System.Windows.Forms.BindingSource predmetisBindingSource;
        private _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSetTableAdapters.PredmetisTableAdapter predmetisTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1 _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1;
        private System.Windows.Forms.BindingSource rezultatsBindingSource;
        private _BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1TableAdapters.RezultatsTableAdapter rezultatsTableAdapter;
        private System.Windows.Forms.DateTimePicker dateKol1;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblPrezimeIme;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.Label lblDatumIspit;
        private System.Windows.Forms.TextBox txtPrezimeIme;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.TextBox txtDom1;
        private System.Windows.Forms.Label lblDom1;
        private System.Windows.Forms.TextBox txtDom2;
        private System.Windows.Forms.Label lblDom2;
        private System.Windows.Forms.TextBox txtSem;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.TextBox txtKol1;
        private System.Windows.Forms.TextBox txtKol2;
        private System.Windows.Forms.TextBox txtIspit;
        private System.Windows.Forms.DateTimePicker dateKol2;
        private System.Windows.Forms.DateTimePicker dateIspit;
        private System.Windows.Forms.Label lblKol1;
        private System.Windows.Forms.Label lblKol2;
        private System.Windows.Forms.Label lblIspit;
        private System.Windows.Forms.CheckBox chkUpl;
        private System.Windows.Forms.CheckBox chkPri;
        private System.Windows.Forms.Label lblUcGod;
        private System.Windows.Forms.TextBox txtUcGod;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezultatiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poeniDomasno1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poeniDomasno2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poeniSeminarskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poeniPosetenostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poeniIKolokviumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIKolokviumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poeniIIKolokviumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIIKolokviumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poeniIspitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIspitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prijavaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uplatnicaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucebnaGodinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predIdDataGridViewTextBoxColumn;
    }
}