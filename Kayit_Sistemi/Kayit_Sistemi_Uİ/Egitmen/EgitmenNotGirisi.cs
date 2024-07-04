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
    public partial class EgitmenNotGirisi : Form
    {
        private int _dersID { get; set; }
        public EgitmenNotGirisi()
        {
            InitializeComponent();
        }

        public EgitmenNotGirisi(int dersID)
        {
            _dersID = dersID;
            InitializeComponent();
        }

        private void EgitmenNotGirisi_Load_1(object sender, EventArgs e)
        {
            try
            {
                var context = new KS_DBEntities();
                var ders = context.Ders.Find(_dersID);
                if (ders != null) 
                {
                    Text = ders.DersAdi.ToUpper() + "Not Girişi";

                    foreach (var ogrenci in ders.Kurs.Ogrenci)
                    {
                        var not = ders.DersNotu.FirstOrDefault(d => d.OgrenciID == ogrenci.KullaniciID);

                        dataGridView1.Rows.Add(
                            ogrenci.KullaniciID,
                            ogrenci.Ad,
                            ogrenci.Soyad,
                            not != null ? not.DersNotu1.ToString() : string.Empty
                            );
                    }
                }
            }
            catch
            {
                MessageBox.Show("Veritabanı Erişim Hatası");
            }
        }

        private void button1_İptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Kayitet_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new KS_DBEntities();

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    bool sonuc1 = int.TryParse(dataGridView1.Rows[i].Cells[0].Value?.ToString(), out int OgrenciNumarası);

                    bool sonuc2 = double.TryParse(dataGridView1.Rows[i].Cells[3].Value?.ToString(), out double OgrencNotu);

                    if (sonuc1 == false || sonuc2 == false)
                    {
                        MessageBox.Show("Ders Notu Boş Olamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    var not = context.DersNotu.FirstOrDefault(d => d.DersID == _dersID && d.OgrenciID == OgrenciNumarası);

                    if (not != null)  
                    {
                       not.DersNotu1 = OgrencNotu;

                    }
                    else
                    {
                        context.DersNotu.Add(new DersNotu()
                        {
                            DersID = _dersID,
                            OgrenciID = OgrenciNumarası,
                            DersNotu1 = OgrencNotu
                        });
                    }
                    context.SaveChanges();
                    MessageBox.Show("Kayıt İşlemi Başarılı", "TAMAM!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Kayıt İşlemi Başarısız", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
