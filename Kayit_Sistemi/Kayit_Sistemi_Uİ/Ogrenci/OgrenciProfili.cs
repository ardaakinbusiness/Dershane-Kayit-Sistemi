using Kayit_Sistemi_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayit_Sistemi_Uİ.Ogrenci
{
    public partial class OgrenciProfili : Form
    {
        public OgrenciProfili()
        {
            InitializeComponent();
        }

        private void OgrenciProfili_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new KS_DBEntities();
                var kullanici = context.Kullanici.FirstOrDefault(k => k.KullaniciAdi == Program.KullaniciAdi);

                if (kullanici != null)
                {
                    var ogrenci = kullanici.Ogrenci;
                    if (ogrenci != null)
                    {
                        Text = ogrenci.Ad + " " + ogrenci.Soyad;
                        textBoxad.Text = ogrenci.Ad;
                        textBoxsoyad.Text = ogrenci.Soyad;
                        textBoxadres.Text = ogrenci.Adres;
                        textBoxceptelefonu.Text = ogrenci.CepTelefonu;
                        textBoxdogumtarihi.Text = ogrenci.DogumTarihi.ToString("dd.MM.yyyy");
                        textBoxtcnumarasi.Text = ogrenci.TC;
                        textBoxemail.Text = ogrenci.Email;
                    }
                }
            }
            catch { }
        }
    }
}
