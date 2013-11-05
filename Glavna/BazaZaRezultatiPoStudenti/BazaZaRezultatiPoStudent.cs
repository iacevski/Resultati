using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

using Rezultati;

namespace BazaZaRezultatiPoStudenti
{
    public class BazaZaRezultatiPoStudent : DbContext
    {
        public BazaZaRezultatiPoStudent(): base() 
        {

        }

        public DbSet<Student> Studenti { get; set; }
        
        public DbSet<Rezultat> ListaRezultati { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //one-to-many 
            modelBuilder.Entity<Rezultat>().HasRequired<Student>(s => s.Student)
            .WithMany(s => s.ListaRezultati).HasForeignKey(s => s.StudentId);


        }
    }
}
