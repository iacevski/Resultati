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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void VnesiRezultatiForma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.Rezultats' table. You can move, or remove it, as needed.
            this.rezultatsTableAdapter.Fill(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.Rezultats);
            // TODO: This line of code loads data into the '_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Predmetis' table. You can move, or remove it, as needed.
            this.predmetisTableAdapter.Fill(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Predmetis);
            // TODO: This line of code loads data into the '_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Students);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Внесете презиме и име на студентот");
                    //using (var ns = new BazaZaRezultatiOdIspit())
                    //{

                    //    Student novStudent = new Student() { StudentIndex = Int32.Parse(txtIndex.Text), StudentName = txtPrezimeIme.Text };
                    //    ns.Studenti.Add(novStudent);
                    //    ns.SaveChanges();
                    //}
                }
            }
        }

        private void txtPrezimeIme_TextChanged(object sender, EventArgs e)
        {
            //IQueryable<Student> stQuery =
            //    from st in db.Studenti
            //    where st.StudentIndex == Int32.Parse(txtIndex.Text)
            //    select st;

            //foreach (Student st in stQuery)
            //{

            //    try
            //    {
            //        txtPrezimeIme.Text = st.StudentName;
            //        Console.WriteLine(txtPrezimeIme.Text);

            //    }
            //    catch (System.Exception ex)
            //    {
            //        System.Windows.Forms.MessageBox.Show(ex.Message);
            //        using (var ss = new BazaZaRezultatiOdIspit())
            //        {

            //            Student novStudent = new Student() { StudentIndex = Int32.Parse(txtIndex.Text), StudentName = txtPrezimeIme.Text };
            //            ss.Studenti.Add(novStudent);
            //            ss.SaveChanges();
            //        }
            //    }

            //}
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
                  PoeniIspit = Int32.Parse(txtIspit.Text),
                  DataIKolokvium = dateKol1.Value,
                  DataIIKolokvium = dateKol2.Value,
                  DataIspit = dateIspit.Value,
                  Prijava = chkPri.Checked,
                  Uplatnica = chkUpl.Checked, 
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rezultatsTableAdapter.FillBy(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.Rezultats);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        private void fillBy2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.rezultatsTableAdapter.FillBy2(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.Rezultats, учебнаГодинаToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rezultatsTableAdapter.Fill(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.Rezultats);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void предметиToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rezultatsTableAdapter.Предмети(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet1.Rezultats, предметToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

    

