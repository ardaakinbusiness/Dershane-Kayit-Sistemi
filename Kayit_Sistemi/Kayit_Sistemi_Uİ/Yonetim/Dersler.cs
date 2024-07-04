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
    public partial class Dersler : Form
    {
        public int dersID { get; set; }

        public Dersler()
        {
            InitializeComponent();
        }

        private void Dersler_Load(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.Rows.Clear();

                var context = new KS_DBEntities();
                var dersler = context.Ders.ToList();
                foreach (var ders in dersler)
                {
                    dataGridView1.Rows.Add(
                        ders.ID,
                        ders.DersAdi,
                        ders.Kurs.KursAdi + " - " + ders.Kurs.BaslangicTarihi.ToString("dd.MM.yyyy"),
                        ders.Kurs.Egitmen.Ad + " " + ders.Kurs.Egitmen.Soyad,
                        ders.DersGunu
                        );
                }

            }
            catch { }
        }

        private void button2_DersEkle_Click(object sender, EventArgs e)
        {
            DersEkle dersEkleme = new DersEkle();
            dersEkleme.ShowDialog();
            Dersler_Load(sender, e);
        }

        private void button1_KursDegistir_Click(object sender, EventArgs e)
        {
            try
            {

                var DersID =int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var context = new KS_DBEntities();
                var ders = context.Ders.Find(DersID);
                if (ders != null)
                {
                    Kurslar kurslarformu = new Kurslar();
                    kurslarformu.ShowDialog();
                    ders.KursID = kurslarformu.KursID;
                    context.SaveChanges();
                    Dersler_Load(sender, e);
                }
            }
            catch { }
        }


    }
}
