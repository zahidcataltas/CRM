using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Kullanici
    {
        private static Kullanici _kullanici_ = new Kullanici();

        public static Kullanici Kullanici_
        {
            get { return Kullanici._kullanici_; }
        }
        private Kullanici()
        {

        }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int ID { get; set; }

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        public string Telefon { get; set; }
        
    }
}
