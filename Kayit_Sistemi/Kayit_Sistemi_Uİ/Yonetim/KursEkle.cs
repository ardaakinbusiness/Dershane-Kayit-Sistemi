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
    public partial class KursEkle : Form
    {
        public KursEkle()
        {
            InitializeComponent();
        }

        private void button1_KursEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var Context = new KS_DBEntities();
                Context.Kurs.Add(new Kurs()
                {
                    KursAdi = textBox1_KursAdi.Text,
                    KursKontenjani = int.Parse(textBox3_Kursontenjani.Text),
                    BaslangicTarihi = DateTime.Parse(dateTimePicker1_KursBaslangicTarihi.Text),
                    EgitmenID = ((ComboboxItem)comboBox1_Egitmen.SelectedItem).value,
                });
                Context.SaveChanges();
                MessageBox.Show("Kayıt İşlemi BAŞARILI ", "BAŞARILI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Kayıt İşlemi Eksik veya Hatalı ", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KursEkle_Load(object sender, EventArgs e)
        {

            try
            {

                var context = new KS_DBEntities();
                var egitmenler = context.Egitmen.ToList();
                comboBox1_Egitmen.DataSource = egitmenler.Select(k => new ComboboxItem()
                {
                    text = k.Ad + " " + k.Soyad,
                    value = k.KullaniciID,
                }).ToList();

            }

            catch
            {
            }
        }

        private void button2_İptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
