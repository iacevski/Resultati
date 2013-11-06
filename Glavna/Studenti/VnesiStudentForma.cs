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
    public partial class VnesiStudentForma : Form
    {

        private BazaZaRezultatiOdIspit ns;

        public VnesiStudentForma()
        {
            InitializeComponent();
            ns = new BazaZaRezultatiOdIspit();

        }

        public VnesiStudentForma(BazaZaRezultatiOdIspit db)
        {
            InitializeComponent();
            this.ns = db;

        }

        private void btnVnesiStudent_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            this.btnVnesiStudent.Enabled = false;

            using (this.ns) {
               Student novStudent = new Student() { StudentIndex=Int32.Parse(txtIndeks.Text), StudentName=txtIme.Text };
                this.ns.Studenti.Add(novStudent);
                this.ns.SaveChanges();
                this.Close();
            }
        }
    }
}
