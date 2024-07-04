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
    public partial class EgtimenDersleri : Form
    {
        public EgtimenDersleri()
        {
            InitializeComponent();
        }

        private void EgtimenDersleri_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new KS_DBEntities();
                var kullanici = context.Kullanici.FirstOrDefault(k=> k.KullaniciAdi== Program.KullaniciAdi);
                if (kullanici!=null)
                {
                    var egitmen = kullanici.Egitmen;
                    Text = egitmen.Ad + " " + egitmen.Soyad; 

                    var kurslar =egitmen.Kurs.ToList();

                    foreach (var kurs in kurslar) 
                    { 
                        foreach(var ders in kurs.Ders) 
                        {
                            dataGridView1.Rows.Add(
                                kurs.ID,
                                kurs.KursAdi,
                                ders.ID,
                                ders.DersAdi,
                                ders.DersGunu,
                                kurs.BaslangicTarihi.ToString("dd.MM.yyyy")                   

                                );
                        }
                        
                    }
                }

            }
            catch { }
        }

        private void button1_İptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_NotGirisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var dersID = int.Parse(dataGridView1.SelectedCells[2].Value.ToString());
                EgitmenNotGirisi egitmenNotGirisi = new EgitmenNotGirisi(dersID);
                egitmenNotGirisi.ShowDialog();
            }
            else
            {
              MessageBox.Show("Bir Satır Seçiniz","HATA",MessageBoxButtons.OK);
            }
        }
    }
}
