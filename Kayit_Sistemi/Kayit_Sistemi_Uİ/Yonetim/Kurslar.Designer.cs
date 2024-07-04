namespace Kayit_Sistemi_Uİ.Yonetim
{
    partial class Kurslar
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
            this.Kurs_Baslangic_Tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egitmen_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs_Kontenjan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2_EgitmenDegistir = new System.Windows.Forms.Button();
            this.button1_KursEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kurs_ID,
            this.Kurs_Baslangic_Tarihi,
            this.Kurs_Adi,
            this.Egitmen_Adi,
            this.Kurs_Kontenjan});
            this.dataGridView1.Location = new System.Drawing.Point(-6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(823, 418);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Kurs_ID
            // 
            this.Kurs_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kurs_ID.HeaderText = "Kurs_ID";
            this.Kurs_ID.MinimumWidth = 150;
            this.Kurs_ID.Name = "Kurs_ID";
            this.Kurs_ID.ReadOnly = true;
            this.Kurs_ID.Width = 150;
            // 
            // Kurs_Baslangic_Tarihi
            // 
            this.Kurs_Baslangic_Tarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kurs_Baslangic_Tarihi.HeaderText = "Kurs_Baslangic_Tarihi";
            this.Kurs_Baslangic_Tarihi.MinimumWidth = 100;
            this.Kurs_Baslangic_Tarihi.Name = "Kurs_Baslangic_Tarihi";
            this.Kurs_Baslangic_Tarihi.Width = 170;
            // 
            // Kurs_Adi
            // 
            this.Kurs_Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kurs_Adi.HeaderText = "Kurs_Adi";
            this.Kurs_Adi.MinimumWidth = 150;
            this.Kurs_Adi.Name = "Kurs_Adi";
            this.Kurs_Adi.ReadOnly = true;
            this.Kurs_Adi.Width = 150;
            // 
            // Egitmen_Adi
            // 
            this.Egitmen_Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Egitmen_Adi.HeaderText = "Egitmen_Adi";
            this.Egitmen_Adi.MinimumWidth = 150;
            this.Egitmen_Adi.Name = "Egitmen_Adi";
            this.Egitmen_Adi.ReadOnly = true;
            this.Egitmen_Adi.Width = 150;
            // 
            // Kurs_Kontenjan
            // 
            this.Kurs_Kontenjan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kurs_Kontenjan.HeaderText = "Kurs_Kontenjan";
            this.Kurs_Kontenjan.MinimumWidth = 150;
            this.Kurs_Kontenjan.Name = "Kurs_Kontenjan";
            this.Kurs_Kontenjan.ReadOnly = true;
            this.Kurs_Kontenjan.Width = 150;
            // 
            // button2_EgitmenDegistir
            // 
            this.button2_EgitmenDegistir.BackColor = System.Drawing.Color.Lime;
            this.button2_EgitmenDegistir.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button2_EgitmenDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2_EgitmenDegistir.Location = new System.Drawing.Point(514, 463);
            this.button2_EgitmenDegistir.Name = "button2_EgitmenDegistir";
            this.button2_EgitmenDegistir.Size = new System.Drawing.Size(249, 57);
            this.button2_EgitmenDegistir.TabIndex = 4;
            this.button2_EgitmenDegistir.Text = "EĞİTMEN DEĞİŞTİR";
            this.button2_EgitmenDegistir.UseVisualStyleBackColor = false;
            this.button2_EgitmenDegistir.Click += new System.EventHandler(this.button2_EgitmenDegistir_Click);
            // 
            // button1_KursEkle
            // 
            this.button1_KursEkle.BackColor = System.Drawing.Color.Silver;
            this.button1_KursEkle.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1_KursEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_KursEkle.Location = new System.Drawing.Point(35, 463);
            this.button1_KursEkle.Name = "button1_KursEkle";
            this.button1_KursEkle.Size = new System.Drawing.Size(249, 57);
            this.button1_KursEkle.TabIndex = 5;
            this.button1_KursEkle.Text = "KURS EKLE";
            this.button1_KursEkle.UseVisualStyleBackColor = false;
            this.button1_KursEkle.Click += new System.EventHandler(this.button1_KursEkle_Click);
            // 
            // Kurslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 549);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2_EgitmenDegistir);
            this.Controls.Add(this.button1_KursEkle);
            this.Name = "Kurslar";
            this.Text = "Kurslar";
            this.Load += new System.EventHandler(this.Kurslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2_EgitmenDegistir;
        private System.Windows.Forms.Button button1_KursEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs_Baslangic_Tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egitmen_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs_Kontenjan;
    }
}