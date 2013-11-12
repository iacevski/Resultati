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

        public VnesiStudentForma()
        {
            InitializeComponent();
        }

        

        private void btnVnesiStudent_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //this.btnVnesiStudent.Enabled = false;
            this.txtIme.Enabled = false;
            this.txtIndeks.Enabled = false;
            using (var db= new BazaZaRezultatiOdIspit()) {
                
                    Student novStudent = new Student() { StudentIndex = Int32.Parse(txtIndeks.Text), StudentName = txtIme.Text };
                    db.Studenti.Add(novStudent);
                    db.SaveChanges();
                    this.txtIme.Enabled = true;
                    this.txtIndeks.Enabled = true;
            }
     

        }

        private void VnesiStudentForma_Load(object sender, EventArgs e)
        {

        }

        private void lblIndex_Click(object sender, EventArgs e)
        {

        }

        private void lblImeStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
