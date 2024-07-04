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

namespace Kayit_Sistemi_Uİ.Yonetim
{
    public partial class YonetimProfili : Form
    {
        public YonetimProfili()
        {
            InitializeComponent();
        }

        private void YonetimProfili_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new KS_DBEntities();
                var kullanici = context.Kullanici.FirstOrDefault(k => k.KullaniciAdi == Program.KullaniciAdi);

                if (kullanici != null)
                {
                    var profil = kullanici.Yonetim;
                    if (profil != null)
                    {
                        Text = profil.Ad + " " + profil.Soyad;
                        textBoxad.Text = profil.Ad;
                        textBoxsoyad.Text = profil.Soyad;                       
                        textBoxceptelefonu.Text = profil.CepTelefonu;                        
                        textBoxtcnumarasi.Text = profil.TC;
                        textBoxemail.Text = profil.Email;
                    }
                }
            }
            catch { }
        }
    }
}
