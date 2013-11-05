using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Student
{
    public class Student
    {
        public Student() 
        {
            RezultatiList = new List<Rezultati>();
        }
        [Key]
        public int StudentId { get; set; }
        [Required]
        public int StudentIndex { get; set; }
        public string StudentName { get; set; }

        public virtual ICollection<Rezultati> RezultatiList { get; set; }
    }
}
