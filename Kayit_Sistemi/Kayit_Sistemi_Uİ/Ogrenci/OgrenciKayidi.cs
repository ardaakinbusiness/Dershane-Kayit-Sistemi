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
    public partial class OgrenciKayidi : Form
    {
        public OgrenciKayidi()
        {
            InitializeComponent();
        }

        private void button1_Sil_Click(object sender, EventArgs e)
        {
            textBoxad.Clear();
            textBoxsoyad.Clear();
            textBoxemail.Clear();
            textBoxadres.Clear();
            maskedTextBox1_tc.Clear();
            maskedTextBox_cep.Clear();
            dateTimePicker1_dogumtarihi.ResetText();
            comboBox1_kurs.ResetText();
        }

        private void button3_iptal_Click(object sender, EventArgs e)
        {
            button1_Sil_Click(sender, e);
            Close();
        }

        private void button2_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new KS_DBEntities();
                var yeniKullanici = new Kullanici
                {
                    KullaniciAdi = Program.KullaniciAdi,
                    Sifre = Program.Sifre,
                    Rol = 0,
                    Ogrenci = new Kayit_Sistemi_DAL.Ogrenci
                    {
                        Ad = textBoxad.Text,
                        Soyad = textBoxsoyad.Text,
                        Email = textBoxemail.Text,
                        TC = maskedTextBox1_tc.Text,
                        Adres = textBoxadres.Text,
                        CepTelefonu =maskedTextBox_cep.Text,
                        DogumTarihi = DateTime.Parse(dateTimePicker1_dogumtarihi.Text),
                        KursID = ((ComboboxItem)comboBox1_kurs.SelectedItem).value,                       
                    }
                };

                context.Kullanici.Add(yeniKullanici);
                context.SaveChanges();

                MessageBox.Show("kayıt işlemi başarılı", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Form bilgileri eksik veya hatalı ı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OgrenciKayidi_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new KS_DBEntities();
                var Kurslar = context.Kurs.ToList();

                comboBox1_kurs.DataSource =
                    Kurslar.Select(k => new ComboboxItem()
                    {
                        text = k.KursAdi + " - " + k.BaslangicTarihi.ToString("dd.MM.yyyy"),
                        value = k.ID,
                    }).ToList()
                    ;
            }
            catch
            {
            }
        }
    }
}
