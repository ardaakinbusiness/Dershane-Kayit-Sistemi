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
    public partial class OgrenciDersleri : Form
    {
        public OgrenciDersleri()
        {
            InitializeComponent();
        }

        private void OgrenciDersleri_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new KS_DBEntities();

                var kullanici = context.Kullanici.FirstOrDefault(k=>k.KullaniciAdi== Program.KullaniciAdi);

                if (kullanici != null)
                {
                    var ogrenci = kullanici.Ogrenci;
                    Text = ogrenci.Ad + " " + ogrenci.Soyad;

                    var dersler = ogrenci.Kurs.Ders.ToList();

                    foreach (var ders in dersler )
                    {
                        dataGridView1.Rows.Add(
                           ders.DersAdi,
                           ders.Kurs.BaslangicTarihi.ToString("dd.MM.yyyy"),
                           ders.DersGunu,
                           ders.Kurs.Egitmen.Ad + " " + ders.Kurs.Egitmen.Soyad,
                           ders.DersNotu.FirstOrDefault(n => n.OgrenciID==ogrenci.KullaniciID)?.DersNotu1.ToString()
                           ) ;
                    }
                }

            }
            catch { }
        }
    }
}
