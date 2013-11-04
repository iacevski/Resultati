using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predmeti
{
    public class Predmeti
    {
        public Predmeti() 
        {
            RezultatiList = new List<Rezultati>();
        }

        public int PredmetId { get; set; }
        [Required]
        public string PredmetName { get; set; }
        public string PredmetSemestar { get; set; }

        public virtual ICollection<Rezultati> RezultatiList { get; set; }
    }
}
