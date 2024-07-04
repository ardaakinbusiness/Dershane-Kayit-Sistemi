using Kayit_Sistemi_DAL;
using Kayit_Sistemi_Uİ.Egitmen;
using Kayit_Sistemi_Uİ.Ogrenci;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                

                var context = new KS_DBEntities();

                var Kullanici = context.Kullanici.FirstOrDefault(k =>
                k.KullaniciAdi == txtbxKullaniciAdi.Text.ToLower() && k.Sifre == txtbxSifre.Text && k.Rol == cmbobxRol.SelectedIndex);

                if (Kullanici != null)
                {
                    Program.KullaniciAdi = Kullanici.KullaniciAdi;
                    Program.KullaniciRolu = Kullanici.Rol;
                    Hide();
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.ShowDialog(); 
                    Show(); 

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
        }
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxKullaniciAdi.Text) || string.IsNullOrEmpty(txtbxSifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifrenizi girin", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var context = new KS_DBEntities();
                var kullanici = context.Kullanici.FirstOrDefault(k => k.KullaniciAdi == txtbxKullaniciAdi.Text.ToLower());
                if (kullanici != null)
                {
                    if (kullanici.Rol == 0)
                    {
                        MessageBox.Show("Kullanıcı Öğrenci olarak Sistemde Mevcuttur", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (kullanici.Rol == 1)
                    {
                        MessageBox.Show("Kullanıcı Eğitmen olarak Sistemde Mevcuttur", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (kullanici.Rol == 2)
                    {
                        MessageBox.Show("Kullanıcı Yönetim olarak Sistemde Mevcuttur", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (cmbobxRol.SelectedIndex == 0)
                    {
                        Program.KullaniciAdi = txtbxKullaniciAdi.Text;
                        Program.Sifre = txtbxSifre.Text;


                        OgrenciKayidi ogrenciKayidi =new OgrenciKayidi();
                        ogrenciKayidi.ShowDialog();
                    }
                    else if (cmbobxRol.SelectedIndex == 1)
                    {
                        Program.KullaniciAdi = txtbxKullaniciAdi.Text;
                        Program.Sifre = txtbxSifre.Text;


                        EgitmenKayidi  egitmenKayidi = new EgitmenKayidi();
                        egitmenKayidi.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Yönetim olarak Sistemde Mevcuttur", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
