using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace Predmeti
{
    public class Predmeti
    {
        public Predmeti() 
        {
            ListaRezultati = new List<Rezultati>();
        }
        [Key]
        public int PredmetId { get; set; }
        [Required]
        public string PredmetName { get; set; }
        public string PredmetSemestar { get; set; }

        public virtual ICollection<Rezultati> ListaRezultati { get; set; }
    }
}
