﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Musteri
    {
        public Musteri()
        {

        }
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Telefon { get; set; }

        public KontakBilgileri bilgiler { get; set; }
    }
}
