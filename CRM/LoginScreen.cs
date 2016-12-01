using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace CRM

{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            Kullanici kln = Kullanici.Kullanici_;
            kln.KullaniciAdi = txtKadi.Text.Trim();
            kln.Sifre = txtSifre.Text.Trim();
            using (LoginBL lbl = new LoginBL())
            {

                if (lbl.GirisYap(kln))
                {
                    MessageBox.Show("Giriş Başarılı.");
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş hatalı.");
                }
            }


        }
    }
}
