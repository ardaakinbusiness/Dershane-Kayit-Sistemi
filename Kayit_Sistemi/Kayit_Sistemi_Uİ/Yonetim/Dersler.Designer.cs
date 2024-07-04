namespace Kayit_Sistemi_Uİ.Yonetim
{
    partial class Dersler
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
            this.Ders_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ders_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egitmen_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ders_Gunu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1_KursDegistir = new System.Windows.Forms.Button();
            this.button2_DersEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ders_ID,
            this.Ders_Adi,
            this.Kurs_Adi,
            this.Egitmen_Adi,
            this.Ders_Gunu});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 418);
            this.dataGridView1.TabIndex = 1;
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
            this.Ders_Adi.Frozen = true;
            this.Ders_Adi.HeaderText = "Ders_Adi";
            this.Ders_Adi.MinimumWidth = 6;
            this.Ders_Adi.Name = "Ders_Adi";
            this.Ders_Adi.Width = 125;
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
            // Egitmen_Adi
            // 
            this.Egitmen_Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Egitmen_Adi.Frozen = true;
            this.Egitmen_Adi.HeaderText = "Egitmen_Adi";
            this.Egitmen_Adi.MinimumWidth = 150;
            this.Egitmen_Adi.Name = "Egitmen_Adi";
            this.Egitmen_Adi.ReadOnly = true;
            this.Egitmen_Adi.Width = 150;
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
            // button1_KursDegistir
            // 
            this.button1_KursDegistir.BackColor = System.Drawing.Color.Aqua;
            this.button1_KursDegistir.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1_KursDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_KursDegistir.Location = new System.Drawing.Point(488, 458);
            this.button1_KursDegistir.Name = "button1_KursDegistir";
            this.button1_KursDegistir.Size = new System.Drawing.Size(249, 57);
            this.button1_KursDegistir.TabIndex = 2;
            this.button1_KursDegistir.Text = "KURS DEĞİŞTİR";
            this.button1_KursDegistir.UseVisualStyleBackColor = false;
            this.button1_KursDegistir.Click += new System.EventHandler(this.button1_KursDegistir_Click);
            // 
            // button2_DersEkle
            // 
            this.button2_DersEkle.BackColor = System.Drawing.Color.Lime;
            this.button2_DersEkle.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button2_DersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2_DersEkle.Location = new System.Drawing.Point(41, 458);
            this.button2_DersEkle.Name = "button2_DersEkle";
            this.button2_DersEkle.Size = new System.Drawing.Size(249, 57);
            this.button2_DersEkle.TabIndex = 2;
            this.button2_DersEkle.Text = "DERS EKLE";
            this.button2_DersEkle.UseVisualStyleBackColor = false;
            this.button2_DersEkle.Click += new System.EventHandler(this.button2_DersEkle_Click);
            // 
            // Dersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 549);
            this.Controls.Add(this.button2_DersEkle);
            this.Controls.Add(this.button1_KursDegistir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dersler";
            this.Text = "Dersler";
            this.Load += new System.EventHandler(this.Dersler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ders_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ders_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egitmen_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ders_Gunu;
        private System.Windows.Forms.Button button1_KursDegistir;
        private System.Windows.Forms.Button button2_DersEkle;
    }
}