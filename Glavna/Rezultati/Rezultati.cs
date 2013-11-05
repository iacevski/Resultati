using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Predmeti;
using Student;
namespace Rezultati
{
    public class Rezultati
    {
        public Rezultati(){ }
        [Key]
        public int RezultatiId { get; set; }
        
        public float PoeniDomasno1 { get; set; }
        public float PoeniDomasno2 { get; set; }
        public float PoeniSeminarska { get; set; }
        public float PoeniPosetenost { get; set; }
        public float PoeniIKolokvium { get; set; }
        public DateTime DataIKolokvium { get; set; }
        public float PoeniIIKolokvium { get; set; }
        public DateTime DataIIKolokvium { get; set; }
        public float PoeniIspit { get; set; }
        public DateTime DataIspit { get; set; }
        
        public bool Prijava { get; set; }
        public bool Uplatnica { get; set; }
        public string UcebnaGodina { get; set; }

        //StudId and PredId is not following code first conventions name
        public int StudId { get; set; }
        public int PredId { get; set; }
        
        public virtual Student Student { get; set; }
        
        public virtual Predmet Predmet { get; set; }
    }
}
