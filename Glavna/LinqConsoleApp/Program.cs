using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Rezultati;
using BazaZaRezultatiOdIspiti;

namespace LinqConsoleApp
{
    [Table(Name = "Students")]
    public class Students
    {
        private int _StudentID;
        [Column(IsPrimaryKey = true, Storage = "_StudentID")]
        public int StudentID
        {
            get
            {
                return this._StudentID;
            }
            set
            {
                this._StudentID = value;
            }

        }

        private int _Index;
        [Column(Storage = "_Index")]
        public int Index
        {
            get
            {
                return this._Index;
            }
            set
            {
                this._Index = value;
            }
        }
        private string _Ime;
        [Column(Storage = "_Ime")]
        public string Ime
        {
            get
            {
                return this._Ime;
            }
            set
            {
                this._Ime = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Use a connection string.
            DataContext db = new DataContext
                (@"C:\Users\Ilce.Phd\BazaZaRezultatiOdIspiti.BazaZaRezultatiOdIspit.mdf");

            // Get a typed table to run queries.
            Table<Students> Student = db.GetTable<Students>();

            // Attach the log to show generated SQL.
            db.Log = Console.Out;

            // Query for customers in London.
            IQueryable<Students> stQuery =
                from st in Student
                where st.Index > 1
                select st;
            foreach (Student st in stQuery)
            {
                Console.WriteLine("ID={0}, Index={1}, Ime={2}", st.StudentId,
                    st.StudentIndex, st.StudentName);
            }

            // Prevent console window from closing.
            Console.ReadLine();
        }
    }
}
