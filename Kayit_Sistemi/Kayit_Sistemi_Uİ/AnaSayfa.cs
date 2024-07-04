using Kayit_Sistemi_DAL;
using Kayit_Sistemi_Uİ.Egitmen;
using Kayit_Sistemi_Uİ.Ogrenci;
using Kayit_Sistemi_Uİ.Yonetim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayit_Sistemi_Uİ
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnprofil_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu==0)
            {
                OgrenciProfili ogrenciprofili = new OgrenciProfili();
                ogrenciprofili.ShowDialog();
            }
            else if (Program.KullaniciRolu == 1)
            {
                EgitmenProfili egitmenProfili = new EgitmenProfili();
                egitmenProfili.ShowDialog();
            }
            else if (Program.KullaniciRolu == 2)
            {
                YonetimProfili yonetimProfili = new YonetimProfili();
                yonetimProfili.ShowDialog();
            }
        }

        private void btndersler_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 0)
            {
                OgrenciDersleri ogrenciDersleri = new OgrenciDersleri();
                ogrenciDersleri.ShowDialog();
            }
            else if (Program.KullaniciRolu == 1)
            {
                EgtimenDersleri egitmenDersleri= new EgtimenDersleri();
                egitmenDersleri.ShowDialog();
            }
            else if (Program.KullaniciRolu == 2)
            {
                Dersler Dersler = new Dersler();
                Dersler.ShowDialog();
            }
        }

        private void btnkurslar_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu==2)
            {
                Kurslar Kurslarformu =new Kurslar();
                Kurslarformu.ShowDialog();
            }
        }

        private void btnegitmenler_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 2)
            {
                Egitmenler Egitmenlerformu = new Egitmenler();
                Egitmenlerformu.ShowDialog();
            }
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu!=2)
            {
                btnkurslar.Hide();
                btnegitmenler.Hide();

            }

            try
            {
                var context = new KS_DBEntities();
                var kullanici = context.Kullanici.First(k => k.KullaniciAdi== Program.KullaniciAdi);
                switch (kullanici.Rol)
                {
                    case 0:
                        var ogrenci = kullanici.Ogrenci; 
                        lbl_HosGeldiniz.Text=ogrenci.Ad + " " + ogrenci.Soyad + " " + lbl_HosGeldiniz.Text;
                        break;

                    case 1:
                        var egitmen = kullanici.Egitmen;
                        lbl_HosGeldiniz.Text = egitmen.Ad + " " + egitmen.Soyad + " " + lbl_HosGeldiniz.Text;
                        break;

                    case 2:
                        lbl_HosGeldiniz.Text = "ÜÇÜNCÜ BİNYIL YÖNETİMİ" + lbl_HosGeldiniz.Text;
                        break;
                }

            }
            catch
            {

            }
        }
    }
}
