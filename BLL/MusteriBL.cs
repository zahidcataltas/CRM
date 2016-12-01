using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MusteriBL : IMainBL<Musteri>
    {

        public bool Ekle()
        {
            throw new NotImplementedException();
        }

        public bool Sil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Guncelle(Musteri nesne)
        {
            throw new NotImplementedException();
        }

        public Musteri Getir()
        {
            throw new NotImplementedException();
        }

        public List<Musteri> ListeGetir()
        {
            throw new NotImplementedException();
        }
        private bool disposed = false;
        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
