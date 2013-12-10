using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Rezultati;
using BazaZaRezultatiOdIspiti;

namespace Studenti
{
    public partial class VnesiRezultatiForma : Form
    {
        private BazaZaRezultatiOdIspit db;
        private int x;
        private int studentID;
        private int predmetID;

        public VnesiRezultatiForma()
        {
            InitializeComponent();
            db = new BazaZaRezultatiOdIspit();
        }


        

        private void VnesiRezultatiForma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.Rezultats' table. You can move, or remove it, as needed.
            this.rezultatsTableAdapter.Fill(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.Rezultats);
            // TODO: This line of code loads data into the '_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Predmetis' table. You can move, or remove it, as needed.
            this.predmetisTableAdapter.Fill(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Predmetis);
            // TODO: This line of code loads data into the '_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Students);
            diQuery();
            dk1Query();
            dk2Query();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            IQueryable<Predmeti> prQuery =
                from pr in db.Predmet
                where pr.PredmetName == comboBox1.Text
                select pr;

            if (prQuery.Count() == 0)
                System.Windows.Forms.MessageBox.Show("Внесете нов предмет");

            foreach (Predmeti pr in prQuery)
            {
                try
                {
                    txtPredID.Text = pr.PredmetId.ToString();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Внесете нов предмет");
                }
            }
            
            try
            {

                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                if (string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "PredId = '" + txtPredID.Text + "'";
                }
                else if (string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "PredId = '" + txtPredID.Text + "' AND StudId ='" + txtStudID.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "PredId = '" + txtPredID.Text + "' AND DataIspit='" + comboBox2.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "PredId = '" + txtPredID.Text + "' AND DataIKolokvium='" + cmbDK1.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text))
                {
                    bs.Filter = "PredId = '" + txtPredID.Text + "' AND DataIIKolokvium='" + cmbDK2.Text + "'";
                }
                else if (string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "PredId = '" + txtPredID.Text + "' AND DataIspit='" + comboBox2.Text + "' AND StudId ='" + txtStudID.Text + "'";
                }
                else if (string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "PredId = '" + txtPredID.Text + "' AND DataIKolokvium='" + cmbDK1.Text + "' AND StudId ='" + txtStudID.Text + "'";
                }
                else if (string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text))
                {
                    bs.Filter = "PredId = '" + txtPredID.Text + "' AND DataIIKolokvium='" + cmbDK2.Text + "' AND StudId ='" + txtStudID.Text + "'";
                }
                dataGridView1.DataSource = bs;
               
            }
            catch (Exception)
            {

            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.FillBy2(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblIndex_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtIndex_TextChanged(object sender, EventArgs e)
        {
            
            txtPrezimeIme.Clear();
            
            x = Int32.Parse(txtIndex.Text);
            IQueryable<Student> stQuery =
                from st in db.Studenti
                where st.StudentIndex == x
                select st;

            if (stQuery.Count()==0)
                System.Windows.Forms.MessageBox.Show("Внесете презиме и име на студентот");

            foreach (Student st in stQuery)
            {
                try
                {
                    txtPrezimeIme.Text = st.StudentName;
                    txtStudID.Text = st.StudentId.ToString();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Внесете презиме и име на студентот");
                }
            }

            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                if (string.IsNullOrEmpty(txtPredID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "StudId = '" + txtStudID.Text + "'";
                }
                else if (string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "StudId = '" + txtStudID.Text + "' AND PredId ='" + txtPredID.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "StudId = '" + txtStudID.Text + "' AND DataIspit='" + comboBox2.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "StudId = '" + txtStudID.Text + "' AND DataIKolokvium='" + cmbDK1.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text))
                {
                    bs.Filter = "StudId = '" + txtStudID.Text + "' AND DataIIKolokvium='" + cmbDK2.Text + "'";
                }
                else if (string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "StudId = '" + txtStudID.Text + "' AND DataIspit='" + comboBox2.Text + "' AND PredId ='" + txtPredID.Text + "'";
                }
                else if (string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "StudId = '" + txtStudID.Text + "' AND DataIKolokvium='" + cmbDK1.Text + "' AND PredId ='" + txtPredID.Text + "'";
                }
                else if (string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text))
                {
                    bs.Filter = "StudId = '" + txtStudID.Text + "' AND DataIIKolokvium='" + cmbDK2.Text + "' AND PredId ='" + txtPredID.Text + "'";
                }
                dataGridView1.DataSource = bs;
            }
            catch (Exception)
            {

            }
        }

        private void txtPrezimeIme_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVnesiRezultat_Click(object sender, EventArgs e)
        {
            x = Int32.Parse(txtIndex.Text);
            var stQuery =
                from st in db.Studenti
                where st.StudentIndex == x
                select st;
            foreach (Student st in stQuery)
            {
                studentID = st.StudentId;
            }

            var prQuery =
                from pr in db.Predmet
                where pr.PredmetName == comboBox1.Text
                select pr;
            foreach (Predmeti pr in prQuery)
            {
                predmetID = pr.PredmetId;
            }

            using (var rezul = new BazaZaRezultatiOdIspit())
            {
                
                //if (stQuery.Count() == 0) { 
                //    Student novStudent= new Student() { StudentIndex = Int32.Parse(txtIndex.Text), StudentName = txtPrezimeIme.Text };
                //}
                Rezultat novRezultat = new Rezultat() 
                { PoeniDomasno1 = Int32.Parse(txtDom1.Text), PoeniDomasno2 = Int32.Parse(txtDom2.Text), 
                  PoeniSeminarska = Int32.Parse(txtSem.Text), PoeniPosetenost = Int32.Parse(txtPos.Text), 
                  PoeniIKolokvium = Int32.Parse(txtKol1.Text), PoeniIIKolokvium = Int32.Parse(txtKol2.Text),
                  PoeniIspit = Int32.Parse(txtIspit.Text), DataIKolokvium = dateKol1.Value.Date,
                  DataIIKolokvium = dateKol2.Value.Date, DataIspit = dateIspit.Value.Date,
                  Prijava = chkPri.Checked, Uplatnica = chkUpl.Checked, 
                  UcebnaGodina=txtUcGod.Text, StudId=studentID, PredId=predmetID };
                rezul.ListaRezultati.Add(novRezultat);
                rezul.SaveChanges();
                
            }
        }

        private void btnVnesiStudent_Click(object sender, EventArgs e)
        {
            using (var db = new BazaZaRezultatiOdIspit())
            {

                Student novStudent = new Student() { StudentIndex = Int32.Parse(txtIndex.Text), StudentName = txtPrezimeIme.Text };
                db.Studenti.Add(novStudent);
                db.SaveChanges();
            }
        }

        private void chkPri_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUcGod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = "UcebnaGodina like '%" + txtUcGod.Text + "%' AND PredId ='"+ txtPredID.Text +"'";
                dataGridView1.DataSource = bs;
            }
            catch (Exception) 
            {

            }

        }

        private void dateIspit_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    BindingSource bs = new BindingSource();
            //    bs.DataSource = dataGridView1.DataSource;
            //    bs.Filter = string.Format("DataIspit=#{0:MM/dd/yyyy}#", dateIspit.Value.ToShortDateString());
            //    dataGridView1.DataSource = bs;
            //}
            //catch (Exception)
            //{

            //}
        }

        private void txtStudID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPredID_TextChanged(object sender, EventArgs e)
        {
        }

        private void diQuery()
        {
            var diQuery =
                from di in db.ListaRezultati
                group di by di.DataIspit;

            foreach (var di in diQuery)
            {
                comboBox2.Items.Add(di.Key.ToShortDateString());
            }
        }

        private void dk1Query()
        {
            var dk1Query =
                from dk1 in db.ListaRezultati
                group dk1 by dk1.DataIKolokvium;

            foreach (var dk1 in dk1Query)
            {
                cmbDK1.Items.Add(dk1.Key.ToShortDateString());
            }
        }

        private void dk2Query()
        {
            var dk2Query =
                from dk2 in db.ListaRezultati
                group dk2 by dk2.DataIIKolokvium;

            foreach (var dk2 in dk2Query)
            {
                cmbDK2.Items.Add(dk2.Key.ToShortDateString());
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            try
            {

                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                if (string.IsNullOrEmpty(txtPredID.Text) && string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "DataIspit='" + comboBox2.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtPredID.Text) && string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "DataIspit='" + comboBox2.Text + "' AND StudId ='" + txtStudID.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(cmbDK1.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "DataIspit='" + comboBox2.Text + "' AND PredId='" + txtPredID.Text + "'";
                }
                else
                {
                    bs.Filter = "DataIspit='" + comboBox2.Text + "' AND StudId='" + txtStudID.Text + "' AND PredId ='" + txtPredID.Text + "'";
                }
                dataGridView1.DataSource = bs;
                dateIspit.Value = DateTime.Parse(comboBox2.Text);
            }
            catch (Exception)
            {

            }

        }

        private void cmbDK1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                if (string.IsNullOrEmpty(txtPredID.Text) && string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "DataIKolokvium='" + cmbDK1.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtPredID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "DataIKolokvium='" + cmbDK1.Text + "' AND StudId ='" + txtStudID.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK2.Text))
                {
                    bs.Filter = "DataIKolokvium='" + cmbDK1.Text + "' AND PredId='" + txtPredID.Text + "'";
                }
                else
                {
                    bs.Filter = "DataIKolokvium='" + cmbDK1.Text + "' AND StudId='" + txtStudID.Text + "' AND PredId ='" + txtPredID.Text + "'";
                }
                dataGridView1.DataSource = bs;
                
                dateKol1.Value = DateTime.Parse(cmbDK1.Text);
            }
            catch (Exception)
            {

            }
        }

        private void cmbDK2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                if (string.IsNullOrEmpty(txtPredID.Text) && string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text))
                {
                    bs.Filter = "DataIIKolokvium='" + cmbDK2.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtPredID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text))
                {
                    bs.Filter = "DataIIKolokvium='" + cmbDK2.Text + "' AND StudId ='" + txtStudID.Text + "'";
                }
                else if (string.IsNullOrEmpty(txtStudID.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(cmbDK1.Text))
                {
                    bs.Filter = "DataIIKolokvium='" + cmbDK2.Text + "' AND PredId='" + txtPredID.Text + "'";
                }
                else
                {
                    bs.Filter = "DataIIKolokvium='" + cmbDK2.Text + "' AND StudId='" + txtStudID.Text + "' AND PredId ='" + txtPredID.Text + "'";
                }
                dataGridView1.DataSource = bs;
                dateKol2.Value = DateTime.Parse(cmbDK2.Text);
            }
            catch (Exception)
            {

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {

                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = null;
                dataGridView1.DataSource = bs;

            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gridTestDataSet.Emp' table. You can move, or remove it, as needed.
            this.rezultatsTableAdapter.Fill(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.Rezultats);
        }
        private void btnPromeniVoBaza_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.rezultatsTableAdapter.Update(_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.Rezultats);
                dataGridView1.Refresh();
                MessageBox.Show("Record Updated");
            }
        }
      
    }

}


    

