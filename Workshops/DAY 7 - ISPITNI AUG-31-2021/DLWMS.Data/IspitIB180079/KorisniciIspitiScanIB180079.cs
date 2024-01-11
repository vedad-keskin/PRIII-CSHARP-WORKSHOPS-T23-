﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB180079
{
    public class KorisniciIspitiScanIB180079
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int PredmetId { get; set; }
        public PredmetiIB180079 Predmet { get; set; }
        public string Napomena { get; set; }
        public byte[] Slika { get; set; }
        public bool Varanje { get; set; }
    }
}
