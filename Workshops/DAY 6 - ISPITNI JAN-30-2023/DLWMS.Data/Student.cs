using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace DLWMS.Data
{
    public class Student
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string ImePrezime => Ime + " " + Prezime;

        public double Prosjek => db.StudentiPredmeti.Where(x => Id == x.StudentId).Count() == 0 ? 0 :           db.StudentiPredmeti.Where(x => Id == x.StudentId).Average(x => x.Ocjena);
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int GodinaStudija { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }
        public Spol Spol { get; set; }       

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }  
}