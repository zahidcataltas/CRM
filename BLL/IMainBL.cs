using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface IMainBL<T> : IDisposable
    {
        bool Ekle();
        bool Sil(int ID);
        bool Guncelle(T nesne);
        T Getir();
        List<T> ListeGetir();
        void Dispose(bool disposing);

    }
}
