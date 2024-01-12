using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB180079
{
    public class PredmetiIB180079
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public int Id { get; set; }  // id = 1 
        public string Naziv { get; set; } // MAteamtika 
        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
