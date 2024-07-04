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

namespace Kayit_Sistemi_Uİ.Egitmen
{
    public partial class EgitmenProfili : Form
    {
        public EgitmenProfili()
        {
            InitializeComponent();
        }

        private void EgitmenProfili_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new KS_DBEntities();
                var kullanici = context.Kullanici.FirstOrDefault(k=> k.KullaniciAdi== Program.KullaniciAdi);

                if(kullanici!=null)
                {
                    var profil = kullanici.Egitmen;
                    if(profil!=null)
                    {
                        Text = profil.Ad + " " + profil.Soyad;
                        textBoxad.Text = profil.Ad;
                        textBoxsoyad.Text = profil.Soyad;
                        textBoxadres.Text = profil.Adres;
                        textBoxceptelefonu.Text = profil.CepTelefonu;
                        textBoxdogumtarihi.Text=profil.DogumTarihi.ToString("dd.MM.yyyy");
                        textBoxtcnumarasi.Text = profil.TC;
                        textBoxemail.Text = profil.Email;
                    }
                }
            }
            catch { }
        }
    }
}
