namespace Kayit_Sistemi_Uİ.Yonetim
{
    partial class Egitmenler
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
            this.Egitmn_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dogum_Tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep_Telefonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Egitmn_ID,
            this.Ad,
            this.Soyad,
            this.TC,
            this.Dogum_Tarihi,
            this.Email,
            this.Cep_Telefonu,
            this.Adres});
            this.dataGridView1.Location = new System.Drawing.Point(-2, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(895, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Egitmn_ID
            // 
            this.Egitmn_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Egitmn_ID.Frozen = true;
            this.Egitmn_ID.HeaderText = "Egitmn ID";
            this.Egitmn_ID.MinimumWidth = 100;
            this.Egitmn_ID.Name = "Egitmn_ID";
            // 
            // Ad
            // 
            this.Ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ad.Frozen = true;
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 100;
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Soyad.Frozen = true;
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 100;
            this.Soyad.Name = "Soyad";
            // 
            // TC
            // 
            this.TC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TC.Frozen = true;
            this.TC.HeaderText = "TC";
            this.TC.MinimumWidth = 100;
            this.TC.Name = "TC";
            // 
            // Dogum_Tarihi
            // 
            this.Dogum_Tarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dogum_Tarihi.Frozen = true;
            this.Dogum_Tarihi.HeaderText = "Dogum_Tarihi";
            this.Dogum_Tarihi.MinimumWidth = 100;
            this.Dogum_Tarihi.Name = "Dogum_Tarihi";
            this.Dogum_Tarihi.Width = 121;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.Frozen = true;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 100;
            this.Email.Name = "Email";
            // 
            // Cep_Telefonu
            // 
            this.Cep_Telefonu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cep_Telefonu.Frozen = true;
            this.Cep_Telefonu.HeaderText = "Cep_Telefonu";
            this.Cep_Telefonu.MinimumWidth = 100;
            this.Cep_Telefonu.Name = "Cep_Telefonu";
            this.Cep_Telefonu.Width = 121;
            // 
            // Adres
            // 
            this.Adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adres.Frozen = true;
            this.Adres.HeaderText = "Adres";
            this.Adres.MinimumWidth = 100;
            this.Adres.Name = "Adres";
            // 
            // Egitmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Egitmenler";
            this.Text = "Egitmenler";
            this.Load += new System.EventHandler(this.Egitmenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egitmn_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dogum_Tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep_Telefonu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
    }
}