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
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
        }

        private void button1_DersEkle_Click(object sender, EventArgs e)
        {
            try
            {

                var context = new KS_DBEntities();
                context.Ders.Add(new Ders()
                {
                    DersAdi = textBox1_dersAdi.Text,
                    DersGunu = textBox3_DersGunu.Text,
                    KursID = ((ComboboxItem)comboBox1_kursdegistir.SelectedItem).value
                });
                context.SaveChanges();
                MessageBox.Show("Ders Ekleme Başarılı", "BARŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            catch
            {
            }
        }

        private void DersEkle_Load(object sender, EventArgs e)
        {
            try
            {

                var context = new KS_DBEntities();
                

                comboBox1_kursdegistir.DataSource = context.Kurs.ToList().Select(k => new ComboboxItem()
                {
                    text = k.KursAdi + " " + k.BaslangicTarihi.ToString("dd.MM.yyyy"),
                    value = k.ID,
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

        private void button_SİL_Click(object sender, EventArgs e)
        {
            textBox1_dersAdi.Clear();
            textBox3_DersGunu.Clear();
            comboBox1_kursdegistir.ResetText();
        }
    }
}
