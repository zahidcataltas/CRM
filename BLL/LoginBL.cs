using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBL : IDisposable
    {
        public int sayi { get; set; }
        public string Ad { get; set; }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    sayi = 0;
                    Ad = String.Empty;
                }
                disposed = true;
            }
        }












        public bool GirisYap(Kullanici kln)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection("Data Source=LocalHost\\SQLEXPRESS; Initial Catalog=Tencere; Integrated Security=true;");
            try
            {
                SqlCommand cmd = new SqlCommand("Update Kullanici set Tarih=@tarih where KullaniciAdi=@kadi and Sifre=@sifre; select * from Kullanici where ID= scope_identity() ;", con);
                SqlParameter[] prms = { new SqlParameter("tarih", DateTime.Now.Date), new SqlParameter("kadi", kln.KullaniciAdi), new SqlParameter("sifre", kln.Sifre) };
                cmd.Parameters.AddRange(prms);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sonuc = true;
                    kln.Ad = reader["Ad"].ToString();
                    kln.Soyad = reader["Soyad"].ToString();
                    kln.ID = Convert.ToInt32(reader["ID"]);
                    //kln.Telefon = reader["Telefon"].ToString();
                }
                return sonuc;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
