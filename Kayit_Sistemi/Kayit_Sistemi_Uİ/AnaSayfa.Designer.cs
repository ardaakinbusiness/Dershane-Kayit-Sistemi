namespace Kayit_Sistemi_Uİ
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btnprofil = new System.Windows.Forms.Button();
            this.btndersler = new System.Windows.Forms.Button();
            this.btnkurslar = new System.Windows.Forms.Button();
            this.btnegitmenler = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.lbl_HosGeldiniz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnprofil
            // 
            this.btnprofil.BackColor = System.Drawing.Color.Black;
            this.btnprofil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnprofil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprofil.Location = new System.Drawing.Point(54, 542);
            this.btnprofil.Name = "btnprofil";
            this.btnprofil.Size = new System.Drawing.Size(212, 70);
            this.btnprofil.TabIndex = 0;
            this.btnprofil.Text = "PROFİL";
            this.btnprofil.UseVisualStyleBackColor = false;
            this.btnprofil.Click += new System.EventHandler(this.btnprofil_Click);
            // 
            // btndersler
            // 
            this.btndersler.BackColor = System.Drawing.Color.Black;
            this.btndersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndersler.ForeColor = System.Drawing.Color.Lime;
            this.btndersler.Location = new System.Drawing.Point(306, 542);
            this.btndersler.Name = "btndersler";
            this.btndersler.Size = new System.Drawing.Size(212, 70);
            this.btndersler.TabIndex = 0;
            this.btndersler.Text = "DERSLER";
            this.btndersler.UseVisualStyleBackColor = false;
            this.btndersler.Click += new System.EventHandler(this.btndersler_Click);
            // 
            // btnkurslar
            // 
            this.btnkurslar.BackColor = System.Drawing.Color.Black;
            this.btnkurslar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkurslar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnkurslar.Location = new System.Drawing.Point(543, 542);
            this.btnkurslar.Name = "btnkurslar";
            this.btnkurslar.Size = new System.Drawing.Size(212, 70);
            this.btnkurslar.TabIndex = 0;
            this.btnkurslar.Text = "KURSLAR";
            this.btnkurslar.UseVisualStyleBackColor = false;
            this.btnkurslar.Click += new System.EventHandler(this.btnkurslar_Click);
            // 
            // btnegitmenler
            // 
            this.btnegitmenler.BackColor = System.Drawing.Color.Black;
            this.btnegitmenler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnegitmenler.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnegitmenler.Location = new System.Drawing.Point(798, 542);
            this.btnegitmenler.Name = "btnegitmenler";
            this.btnegitmenler.Size = new System.Drawing.Size(212, 70);
            this.btnegitmenler.TabIndex = 0;
            this.btnegitmenler.Text = "EĞİTMENLER";
            this.btnegitmenler.UseVisualStyleBackColor = false;
            this.btnegitmenler.Click += new System.EventHandler(this.btnegitmenler_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.White;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.Red;
            this.btncikis.Location = new System.Drawing.Point(438, 443);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(212, 70);
            this.btncikis.TabIndex = 0;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // lbl_HosGeldiniz
            // 
            this.lbl_HosGeldiniz.AutoSize = true;
            this.lbl_HosGeldiniz.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HosGeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HosGeldiniz.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_HosGeldiniz.Location = new System.Drawing.Point(48, 41);
            this.lbl_HosGeldiniz.Name = "lbl_HosGeldiniz";
            this.lbl_HosGeldiniz.Size = new System.Drawing.Size(197, 36);
            this.lbl_HosGeldiniz.TabIndex = 1;
            this.lbl_HosGeldiniz.Text = "Hoş Geldiniz";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 631);
            this.Controls.Add(this.lbl_HosGeldiniz);
            this.Controls.Add(this.btnegitmenler);
            this.Controls.Add(this.btnkurslar);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btndersler);
            this.Controls.Add(this.btnprofil);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprofil;
        private System.Windows.Forms.Button btndersler;
        private System.Windows.Forms.Button btnkurslar;
        private System.Windows.Forms.Button btnegitmenler;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Label lbl_HosGeldiniz;
    }
}