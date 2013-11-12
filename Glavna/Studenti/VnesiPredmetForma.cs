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
        

        public VnesiPredmetForma()
        {
            InitializeComponent();
            
        }

        
        private void VnesiPredmetForma_Load(object sender, EventArgs e)
        {

        }

        private void btnVnesiPredmet_Click(object sender, EventArgs e)
        {
            
             
                this.txtImePredmet.Enabled = false;
                this.txtSemestar.Enabled = false;
                using (var db = new BazaZaRezultatiOdIspit())
                {

                    Predmeti novPredmet = new Predmeti() { PredmetName = txtImePredmet.Text, PredmetSemestar = txtSemestar.Text };
                    db.Predmet.Add(novPredmet);
                    db.SaveChanges();


                    this.txtImePredmet.Enabled = true;
                    this.txtSemestar.Enabled = true;
                }
           
        }
    }
}
