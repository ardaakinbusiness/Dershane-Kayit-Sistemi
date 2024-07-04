namespace Kayit_Sistemi_Uİ.Egitmen
{
    partial class EgitmenNotGirisi
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
            this.Ogrenci_Numarası = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ogrenci_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ogrenci_Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ogrenci_Notu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2_Kayitet = new System.Windows.Forms.Button();
            this.button1_İptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ogrenci_Numarası,
            this.Ogrenci_Adi,
            this.Ogrenci_Soyadi,
            this.Ogrenci_Notu});
            this.dataGridView1.Location = new System.Drawing.Point(8, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(755, 418);
            this.dataGridView1.TabIndex = 6;
            // 
            // Ogrenci_Numarası
            // 
            this.Ogrenci_Numarası.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ogrenci_Numarası.HeaderText = "Ogrenci_Numarası";
            this.Ogrenci_Numarası.MinimumWidth = 200;
            this.Ogrenci_Numarası.Name = "Ogrenci_Numarası";
            this.Ogrenci_Numarası.ReadOnly = true;
            this.Ogrenci_Numarası.Width = 200;
            // 
            // Ogrenci_Adi
            // 
            this.Ogrenci_Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ogrenci_Adi.HeaderText = "Ogrenci_Adi";
            this.Ogrenci_Adi.MinimumWidth = 150;
            this.Ogrenci_Adi.Name = "Ogrenci_Adi";
            this.Ogrenci_Adi.ReadOnly = true;
            this.Ogrenci_Adi.Width = 150;
            // 
            // Ogrenci_Soyadi
            // 
            this.Ogrenci_Soyadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ogrenci_Soyadi.HeaderText = "Ogrenci_Soyadi";
            this.Ogrenci_Soyadi.MinimumWidth = 200;
            this.Ogrenci_Soyadi.Name = "Ogrenci_Soyadi";
            this.Ogrenci_Soyadi.ReadOnly = true;
            this.Ogrenci_Soyadi.Width = 200;
            // 
            // Ogrenci_Notu
            // 
            this.Ogrenci_Notu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ogrenci_Notu.HeaderText = "Ogrenci_Notu";
            this.Ogrenci_Notu.MinimumWidth = 150;
            this.Ogrenci_Notu.Name = "Ogrenci_Notu";
            this.Ogrenci_Notu.Width = 150;
            // 
            // button2_Kayitet
            // 
            this.button2_Kayitet.BackColor = System.Drawing.Color.Lime;
            this.button2_Kayitet.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button2_Kayitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2_Kayitet.Location = new System.Drawing.Point(39, 454);
            this.button2_Kayitet.Name = "button2_Kayitet";
            this.button2_Kayitet.Size = new System.Drawing.Size(249, 57);
            this.button2_Kayitet.TabIndex = 7;
            this.button2_Kayitet.Text = "KAYIT ET";
            this.button2_Kayitet.UseVisualStyleBackColor = false;
            this.button2_Kayitet.Click += new System.EventHandler(this.button2_Kayitet_Click);
            // 
            // button1_İptal
            // 
            this.button1_İptal.BackColor = System.Drawing.Color.Aqua;
            this.button1_İptal.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1_İptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_İptal.Location = new System.Drawing.Point(369, 454);
            this.button1_İptal.Name = "button1_İptal";
            this.button1_İptal.Size = new System.Drawing.Size(249, 57);
            this.button1_İptal.TabIndex = 8;
            this.button1_İptal.Text = "İPTAL";
            this.button1_İptal.UseVisualStyleBackColor = false;
            this.button1_İptal.Click += new System.EventHandler(this.button1_İptal_Click);
            // 
            // EgitmenNotGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 544);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2_Kayitet);
            this.Controls.Add(this.button1_İptal);
            this.Name = "EgitmenNotGirisi";
            this.Text = "EgitmenNotGirisi";
            this.Load += new System.EventHandler(this.EgitmenNotGirisi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2_Kayitet;
        private System.Windows.Forms.Button button1_İptal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ogrenci_Numarası;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ogrenci_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ogrenci_Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ogrenci_Notu;
    }
}