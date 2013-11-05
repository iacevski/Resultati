using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace Rezultati
{
    public class Student
    {
        public Student() 
        {
            ListaRezultati = new List<Rezultat>();
        }
        [Key]
        public int StudentId { get; set; }
        [Required]
        public int StudentIndex { get; set; }
        public string StudentName { get; set; }

        public virtual ICollection<Rezultat> ListaRezultati { get; set; }
    }
}
