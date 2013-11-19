using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Rezultati;
using BazaZaRezultatiOdIspiti;

namespace Glavna
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new BazaZaRezultatiOdIspit())
            {
                Student newStudent = new Student() { StudentIndex= 13, StudentName = "Костовски Коста"};
                Predmeti newPredmet = new Predmeti() { PredmetName = "Веб програмирање", PredmetSemestar = "V" };
                Rezultat rez = new Rezultat() { PoeniDomasno1 = 7 };
                rez.DataIIKolokvium = DateTime.Now;
                rez.DataIKolokvium = DateTime.Now;
                rez.DataIspit = DateTime.Now;
                rez.Predmeti = newPredmet;
                rez.Student = newStudent;
                
                
                ctx.ListaRezultati.Add(rez);
                ctx.SaveChanges();

            }

            Console.WriteLine("Code first demo successful");
            Console.ReadKey();
        }
    }
}
