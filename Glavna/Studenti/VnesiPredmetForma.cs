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
    public partial class VnesiPredmetForma : Form
    {
        private BazaZaRezultatiOdIspit ns;

        public VnesiPredmetForma()
        {
            InitializeComponent();
            ns = new BazaZaRezultatiOdIspit();
        }

        public VnesiPredmetForma(BazaZaRezultatiOdIspit db)
        {
            InitializeComponent();
            this.ns = db;

        }

        

        private void VnesiPredmetForma_Load(object sender, EventArgs e)
        {

        }

        private void btnVnesiPredmet_Click(object sender, EventArgs e)
        {
            this.btnVnesiPredmet.Enabled = false;
            using (this.ns)
            {
                Predmeti novPredmet=new Predmeti(){PredmetName=txtImePredmet.Text, PredmetSemestar=txtSemestar.Text};
                this.ns.Predmet.Add(novPredmet);
                this.ns.SaveChanges();
                this.Close();
            }
        }
    }
}
