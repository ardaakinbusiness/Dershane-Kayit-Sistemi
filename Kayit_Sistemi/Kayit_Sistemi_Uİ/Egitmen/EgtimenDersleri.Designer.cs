namespace Kayit_Sistemi_Uİ.Egitmen
{
    partial class EgtimenDersleri
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
            this.Kurs_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ders_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ders_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ders_Gunu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslangic_Tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2_NotGirisi = new System.Windows.Forms.Button();
            this.button1_İptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kurs_ID,
            this.Kurs_Adi,
            this.Ders_ID,
            this.Ders_Adi,
            this.Ders_Gunu,
            this.Baslangic_Tarihi});
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 418);
            this.dataGridView1.TabIndex = 3;
            // 
            // Kurs_ID
            // 
            this.Kurs_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kurs_ID.Frozen = true;
            this.Kurs_ID.HeaderText = "Kurs_ID";
            this.Kurs_ID.MinimumWidth = 100;
            this.Kurs_ID.Name = "Kurs_ID";
            // 
            // Kurs_Adi
            // 
            this.Kurs_Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kurs_Adi.Frozen = true;
            this.Kurs_Adi.HeaderText = "Kurs_Adi";
            this.Kurs_Adi.MinimumWidth = 150;
            this.Kurs_Adi.Name = "Kurs_Adi";
            this.Kurs_Adi.ReadOnly = true;
            this.Kurs_Adi.Width = 150;
            // 
            // Ders_ID
            // 
            this.Ders_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ders_ID.Frozen = true;
            this.Ders_ID.HeaderText = "Ders_ID";
            this.Ders_ID.MinimumWidth = 150;
            this.Ders_ID.Name = "Ders_ID";
            this.Ders_ID.ReadOnly = true;
            this.Ders_ID.Width = 150;
            // 
            // Ders_Adi
            // 
            this.Ders_Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ders_Adi.Frozen = true;
            this.Ders_Adi.HeaderText = "Ders_Adi";
            this.Ders_Adi.MinimumWidth = 100;
            this.Ders_Adi.Name = "Ders_Adi";
            // 
            // Ders_Gunu
            // 
            this.Ders_Gunu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ders_Gunu.Frozen = true;
            this.Ders_Gunu.HeaderText = "Ders_Gunu";
            this.Ders_Gunu.MinimumWidth = 150;
            this.Ders_Gunu.Name = "Ders_Gunu";
            this.Ders_Gunu.ReadOnly = true;
            this.Ders_Gunu.Width = 150;
            // 
            // Baslangic_Tarihi
            // 
            this.Baslangic_Tarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Baslangic_Tarihi.Frozen = true;
            this.Baslangic_Tarihi.HeaderText = "Baslangic_Tarihi";
            this.Baslangic_Tarihi.MinimumWidth = 150;
            this.Baslangic_Tarihi.Name = "Baslangic_Tarihi";
            this.Baslangic_Tarihi.Width = 150;
            // 
            // button2_NotGirisi
            // 
            this.button2_NotGirisi.BackColor = System.Drawing.Color.Lime;
            this.button2_NotGirisi.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button2_NotGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2_NotGirisi.Location = new System.Drawing.Point(35, 452);
            this.button2_NotGirisi.Name = "button2_NotGirisi";
            this.button2_NotGirisi.Size = new System.Drawing.Size(249, 57);
            this.button2_NotGirisi.TabIndex = 4;
            this.button2_NotGirisi.Text = "NOT GİRİŞİ";
            this.button2_NotGirisi.UseVisualStyleBackColor = false;
            this.button2_NotGirisi.Click += new System.EventHandler(this.button2_NotGirisi_Click);
            // 
            // button1_İptal
            // 
            this.button1_İptal.BackColor = System.Drawing.Color.Aqua;
            this.button1_İptal.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1_İptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_İptal.Location = new System.Drawing.Point(501, 452);
            this.button1_İptal.Name = "button1_İptal";
            this.button1_İptal.Size = new System.Drawing.Size(249, 57);
            this.button1_İptal.TabIndex = 5;
            this.button1_İptal.Text = "İPTAL";
            this.button1_İptal.UseVisualStyleBackColor = false;
            this.button1_İptal.Click += new System.EventHandler(this.button1_İptal_Click);
            // 
            // EgtimenDersleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2_NotGirisi);
            this.Controls.Add(this.button1_İptal);
            this.Name = "EgtimenDersleri";
            this.Text = "EgtimenDersleri";
            this.Load += new System.EventHandler(this.EgtimenDersleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2_NotGirisi;
        private System.Windows.Forms.Button button1_İptal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ders_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ders_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ders_Gunu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslangic_Tarihi;
    }
}