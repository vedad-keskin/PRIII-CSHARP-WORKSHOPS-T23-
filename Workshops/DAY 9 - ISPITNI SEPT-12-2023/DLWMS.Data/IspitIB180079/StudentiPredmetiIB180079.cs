using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB180079
{
    public class StudentiPredmetiIB180079
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public string StudentPodaci => Student == null ? "" : $"{Student.Ime} {Student.Prezime} ({DateTime.Now.Year - Student.DatumRodjenja.Year})";
        public int PredmetId { get; set; }
        public PredmetiIB180079 Predmet { get; set; }

        public string PredmetPodaci => Predmet == null ? "" : $"{Predmet.Naziv}" +
            $" ({db.StudentiPredmeti.Where(x=> x.PredmetId == PredmetId).Average(x=> x.Ocjena)})";
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }

        public string BrojIndeksa => Student == null ? "" : Student.BrojIndeksa;
        public bool Aktivan => Student == null ? false : Student.Aktivan;

    }
}
