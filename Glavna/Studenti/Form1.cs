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
using Rezultati;

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

            VnesiStudentForma vsf1 = new VnesiStudentForma();
            vsf1.ShowDialog();
           

        }

                private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVnesiNovPredmet_Click_1(object sender, EventArgs e)
        {
            VnesiPredmetForma vpf1 = new VnesiPredmetForma();
            vpf1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// Query for Students .
            IQueryable<Student> stQuery =
                from st in db.Studenti
                where st.StudentIndex > 8
                select st;

            foreach (Student st in stQuery)
            {
                Console.WriteLine("ID={0}, Index={1}, Ime={2}", st.StudentId,
                    st.StudentIndex, st.StudentName);
            }

        }

        private void btnPromeniImePredmet_Click(object sender, EventArgs e)
        {
            //// Query for Predmeti
            IQueryable<Predmeti> prQuery =
                from pr in db.Predmet
                where pr.PredmetSemestar == "III"
                select pr;

            //foreach (Predmeti pr in prQuery)
            //{
            //    Console.WriteLine("ID={0}, Ime={1}, Semestar={2}", pr.PredmetId,
            //        pr.PredmetName, pr.PredmetSemestar);
            //}


            // Execute the query, and change the column values 
            // you want to change. 
            foreach (Predmeti pr in prQuery)
            {
                pr.PredmetName = "Objektno Orientirano Programiranje";
                // Insert any additional changes to column values.
            }
            // Submit the changes to the database. 
            try
            {
                db.SaveChanges();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                // Make some adjustments.
                // ...
                // Try again.
                db.SaveChanges();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //// Query for Students .
            IQueryable<Student> stQuery =
                from st in db.Studenti
                where st.StudentIndex > 10
                select st;

            foreach (Student st in stQuery)
            {
                db.Studenti.Remove(st);
            }
           
            try
            {
                db.SaveChanges();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                // Make some adjustments.
                // ...
                // Try again.
                db.SaveChanges();
            }
        }

        private void btnVnesiRezultati_Click(object sender, EventArgs e)
        {
            VnesiRezultatiForma vrf1 = new VnesiRezultatiForma();
            vrf1.ShowDialog();
        }
    }
}
