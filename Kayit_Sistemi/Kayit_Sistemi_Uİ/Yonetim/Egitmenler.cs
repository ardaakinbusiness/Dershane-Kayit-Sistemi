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
    public partial class Egitmenler : Form
    {
        public int EgitmenID { get; set; }

        public Egitmenler()
        {
            InitializeComponent();
        }

        private void Egitmenler_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                var context = new KS_DBEntities();
                var egitmenler = context.Egitmen.ToList();
                foreach(var egitmen in egitmenler)
                {
                    dataGridView1.Rows.Add(
                        egitmen.KullaniciID,
                        egitmen.Ad,
                        egitmen,Soyad,
                        egitmen,TC,egitmen.DogumTarihi.ToString("dd.MM.yyyy"),
                        egitmen.Email,
                        egitmen.CepTelefonu,
                        egitmen.Adres
                        );
                }
            }
            catch 
            {
                MessageBox.Show("Load Error");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EgitmenID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
