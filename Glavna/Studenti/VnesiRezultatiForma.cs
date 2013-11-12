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
        public VnesiRezultatiForma()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void VnesiRezultatiForma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Predmetis' table. You can move, or remove it, as needed.
            this.predmetisTableAdapter.Fill(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Predmetis);
            // TODO: This line of code loads data into the '_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this._BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Students);
            // TODO: This line of code loads data into the '_BazaZaRezultatiOdIspiti_BazaZaRezultatiOdIspitDataSet.Students' table. You can move, or remove it, as needed.

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

    }
}
