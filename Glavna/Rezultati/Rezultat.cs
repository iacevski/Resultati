using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Rezultati
{
    public class Rezultat
    {
        public Rezultat(){ }
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
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        
        public virtual Student Student { get; set; }
        
        public virtual Predmeti Predmeti { get; set; }
    }
}
