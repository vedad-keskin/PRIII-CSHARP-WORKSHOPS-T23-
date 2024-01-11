﻿using DLWMS.Data.IspitIB180079;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class DLWMSDbContext : DbContext
    {
        private string dbPutanja;

	   public DLWMSDbContext()
	   {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSPutanja"].ConnectionString;
	   }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
       
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<PredmetiIB180079> Predmeti { get; set; }
        public DbSet<StudentiPredmetiIB180079> StudentiPredmeti { get; set; }
        public DbSet<StudentiUvjerenjaIB180079> StudentiUvjerenjaIB180079 { get; set; }
    }
}
