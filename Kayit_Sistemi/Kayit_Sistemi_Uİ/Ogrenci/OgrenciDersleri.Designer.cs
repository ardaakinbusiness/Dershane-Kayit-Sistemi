namespace Kayit_Sistemi_Uİ.Ogrenci
{
    partial class OgrenciDersleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ders_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslangic_Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ders_Gunu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egitmen_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ders_Notu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ders_Adi,
            this.Baslangic_Tarih,
            this.Ders_Gunu,
            this.Egitmen_Adi,
            this.Ders_Notu});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(619, 550);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ders_Adi
            // 
            this.Ders_Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ders_Adi.Frozen = true;
            this.Ders_Adi.HeaderText = "Ders_Adi";
            this.Ders_Adi.MinimumWidth = 100;
            this.Ders_Adi.Name = "Ders_Adi";
            this.Ders_Adi.ReadOnly = true;
            // 
            // Baslangic_Tarih
            // 
            this.Baslangic_Tarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Baslangic_Tarih.Frozen = true;
            this.Baslangic_Tarih.HeaderText = "Baslangic_Tarih";
            this.Baslangic_Tarih.MinimumWidth = 150;
            this.Baslangic_Tarih.Name = "Baslangic_Tarih";
            this.Baslangic_Tarih.ReadOnly = true;
            this.Baslangic_Tarih.Width = 150;
            // 
            // Ders_Gunu
            // 
            this.Ders_Gunu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ders_Gunu.Frozen = true;
            this.Ders_Gunu.HeaderText = "Ders_Gunu";
            this.Ders_Gunu.MinimumWidth = 100;
            this.Ders_Gunu.Name = "Ders_Gunu";
            this.Ders_Gunu.ReadOnly = true;
            this.Ders_Gunu.Width = 103;
            // 
            // Egitmen_Adi
            // 
            this.Egitmen_Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Egitmen_Adi.Frozen = true;
            this.Egitmen_Adi.HeaderText = "Egitmen_Adi";
            this.Egitmen_Adi.MinimumWidth = 100;
            this.Egitmen_Adi.Name = "Egitmen_Adi";
            this.Egitmen_Adi.ReadOnly = true;
            this.Egitmen_Adi.Width = 112;
            // 
            // Ders_Notu
            // 
            this.Ders_Notu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ders_Notu.Frozen = true;
            this.Ders_Notu.HeaderText = "Ders_Notu";
            this.Ders_Notu.MinimumWidth = 100;
            this.Ders_Notu.Name = "Ders_Notu";
            this.Ders_Notu.ReadOnly = true;
            // 
            // OgrenciDersleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 552);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OgrenciDersleri";
            this.Text = "OgrenciDersleri";
            this.Load += new System.EventHandler(this.OgrenciDersleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ders_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslangic_Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ders_Gunu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egitmen_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ders_Notu;
    }
}