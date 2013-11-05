using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Rezultati;
using BazaZaRezultatiOdIspiti;
using BazaZaRezultatiPoStudenti;

namespace Glavna
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new BazaZaRezultatiOdIspit())
            {
                Student newStudent = new Student() { StudentIndex= 8, StudentName = "Acevski Ilce"};
                Predmeti newPredmet = new Predmeti() { PredmetName = "OOP", PredmetSemestar = "III" };
                Rezultat rez = new Rezultat() { PoeniDomasno1 = 10 };
                ctx.ListaRezultati.Add(rez);
                ctx.SaveChanges();

            }

            Console.WriteLine("Code first demo successful");
            Console.ReadKey();
        }
    }
}
