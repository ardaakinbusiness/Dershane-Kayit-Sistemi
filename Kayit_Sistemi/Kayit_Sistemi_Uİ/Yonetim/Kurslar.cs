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
    public partial class Kurslar : Form
    {
        public int KursID {  get; set; }
        public Kurslar()
        {
            InitializeComponent();
        }

        private void Kurslar_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();

                var context = new KS_DBEntities();
                var kurslar = context.Kurs.ToList();
                foreach (var kurs in kurslar)
                {
                    dataGridView1.Rows.Add(
                        kurs.ID,
                        kurs.KursAdi,
                        kurs.BaslangicTarihi.ToString("dd.MM.yyyy"),
                        kurs.Egitmen.Ad + " " + kurs.Egitmen.Soyad,
                        kurs.KursKontenjani.ToString()
                        );
                }

            }
            catch { }
        }

        private void button1_KursEkle_Click(object sender, EventArgs e)
        {
            KursEkle kursEklemeFormu = new KursEkle();
            kursEklemeFormu.ShowDialog();

            Kurslar_Load(sender, e);

        }

        private void button2_EgitmenDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                var kursID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                var context = new KS_DBEntities();
                var kurs = context.Kurs.Find(kursID);
                if (kurs != null)
                {
                    Egitmenler egitmenlerFormu = new Egitmenler();
                    egitmenlerFormu.ShowDialog();
                    kurs.EgitmenID = egitmenlerFormu.EgitmenID;
                    context.SaveChanges();

                    Kurslar_Load(sender, e);
                }
            }
            catch { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            KursID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}
