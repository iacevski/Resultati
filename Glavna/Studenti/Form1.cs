using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BazaZaRezultatiOdIspiti;

namespace Studenti
{
    public partial class Form1 : Form
    {
        private BazaZaRezultatiOdIspit db;

        public Form1()
        {
            InitializeComponent();

            db = new BazaZaRezultatiOdIspit();
        }

        private void btnVnesiNovStudent_Click(object sender, EventArgs e)
        {

            VnesiStudentForma vsf1 = new VnesiStudentForma(db);
            vsf1.ShowDialog();
           

        }

                private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVnesiNovPredmet_Click_1(object sender, EventArgs e)
        {
            VnesiPredmetForma vpf1 = new VnesiPredmetForma(db);
            vpf1.ShowDialog();
        }
    }
}
