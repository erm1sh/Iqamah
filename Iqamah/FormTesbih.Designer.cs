namespace Iqamah
{
    partial class FormTesbih
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelUst = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblKategori1 = new System.Windows.Forms.Label();
            this.btnSubhanallah = new System.Windows.Forms.Button();
            this.btnElhamdulillah = new System.Windows.Forms.Button();
            this.btnAllahuEkber = new System.Windows.Forms.Button();
            this.lblKategori2 = new System.Windows.Forms.Label();
            this.btnLaIlahe = new System.Windows.Forms.Button();
            this.btnSubhanallahiBihamdihi = new System.Windows.Forms.Button();
            this.btnEstagfirullah = new System.Windows.Forms.Button();
            this.btnSalavat = new System.Windows.Forms.Button();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnSifirla = new System.Windows.Forms.Button();

            this.panelUst.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(16, 18, 45);
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Controls.Add(this.btnKapat);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(520, 50);
            this.panelUst.TabIndex = 0;
            this.panelUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTesbih_MouseDown);
            this.panelUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTesbih_MouseMove);
            this.panelUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTesbih_MouseUp);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(238, 193, 112);
            this.lblBaslik.Location = new System.Drawing.Point(16, 10);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(200, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "📿  Tesbihat & Zikir";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnKapat.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnKapat.Location = new System.Drawing.Point(476, 8);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(36, 36);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "✕";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblKategori1 (Namaz Sonrası Tesbihat)
            // 
            this.lblKategori1.AutoSize = true;
            this.lblKategori1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKategori1.ForeColor = System.Drawing.Color.FromArgb(160, 160, 190);
            this.lblKategori1.Location = new System.Drawing.Point(20, 62);
            this.lblKategori1.Name = "lblKategori1";
            this.lblKategori1.Size = new System.Drawing.Size(180, 19);
            this.lblKategori1.TabIndex = 2;
            this.lblKategori1.Text = "NAMAZ SONRASI TESBİHAT";
            // 
            // btnSubhanallah
            // 
            this.btnSubhanallah.BackColor = System.Drawing.Color.FromArgb(28, 31, 72);
            this.btnSubhanallah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubhanallah.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 54, 110);
            this.btnSubhanallah.FlatAppearance.BorderSize = 1;
            this.btnSubhanallah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 42, 90);
            this.btnSubhanallah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubhanallah.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSubhanallah.ForeColor = System.Drawing.Color.FromArgb(230, 230, 240);
            this.btnSubhanallah.Location = new System.Drawing.Point(20, 88);
            this.btnSubhanallah.Name = "btnSubhanallah";
            this.btnSubhanallah.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnSubhanallah.Size = new System.Drawing.Size(480, 48);
            this.btnSubhanallah.TabIndex = 3;
            this.btnSubhanallah.Text = "Sübhanallah                                   0 / 33";
            this.btnSubhanallah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubhanallah.UseVisualStyleBackColor = false;
            this.btnSubhanallah.Click += new System.EventHandler(this.btnZikir_Click);
            // 
            // btnElhamdulillah
            // 
            this.btnElhamdulillah.BackColor = System.Drawing.Color.FromArgb(28, 31, 72);
            this.btnElhamdulillah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElhamdulillah.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 54, 110);
            this.btnElhamdulillah.FlatAppearance.BorderSize = 1;
            this.btnElhamdulillah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 42, 90);
            this.btnElhamdulillah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElhamdulillah.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnElhamdulillah.ForeColor = System.Drawing.Color.FromArgb(230, 230, 240);
            this.btnElhamdulillah.Location = new System.Drawing.Point(20, 142);
            this.btnElhamdulillah.Name = "btnElhamdulillah";
            this.btnElhamdulillah.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnElhamdulillah.Size = new System.Drawing.Size(480, 48);
            this.btnElhamdulillah.TabIndex = 4;
            this.btnElhamdulillah.Text = "Elhamdülillah                                 0 / 33";
            this.btnElhamdulillah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElhamdulillah.UseVisualStyleBackColor = false;
            this.btnElhamdulillah.Click += new System.EventHandler(this.btnZikir_Click);
            // 
            // btnAllahuEkber
            // 
            this.btnAllahuEkber.BackColor = System.Drawing.Color.FromArgb(28, 31, 72);
            this.btnAllahuEkber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllahuEkber.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 54, 110);
            this.btnAllahuEkber.FlatAppearance.BorderSize = 1;
            this.btnAllahuEkber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 42, 90);
            this.btnAllahuEkber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllahuEkber.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAllahuEkber.ForeColor = System.Drawing.Color.FromArgb(230, 230, 240);
            this.btnAllahuEkber.Location = new System.Drawing.Point(20, 196);
            this.btnAllahuEkber.Name = "btnAllahuEkber";
            this.btnAllahuEkber.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnAllahuEkber.Size = new System.Drawing.Size(480, 48);
            this.btnAllahuEkber.TabIndex = 5;
            this.btnAllahuEkber.Text = "Allahü Ekber                                  0 / 33";
            this.btnAllahuEkber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllahuEkber.UseVisualStyleBackColor = false;
            this.btnAllahuEkber.Click += new System.EventHandler(this.btnZikir_Click);
            // 
            // lblKategori2 (Günlük Zikirler)
            // 
            this.lblKategori2.AutoSize = true;
            this.lblKategori2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKategori2.ForeColor = System.Drawing.Color.FromArgb(160, 160, 190);
            this.lblKategori2.Location = new System.Drawing.Point(20, 260);
            this.lblKategori2.Name = "lblKategori2";
            this.lblKategori2.Size = new System.Drawing.Size(130, 19);
            this.lblKategori2.TabIndex = 6;
            this.lblKategori2.Text = "GÜNLÜK ZİKİRLER";
            // 
            // btnLaIlahe
            // 
            this.btnLaIlahe.BackColor = System.Drawing.Color.FromArgb(28, 31, 72);
            this.btnLaIlahe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaIlahe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 54, 110);
            this.btnLaIlahe.FlatAppearance.BorderSize = 1;
            this.btnLaIlahe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 42, 90);
            this.btnLaIlahe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaIlahe.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnLaIlahe.ForeColor = System.Drawing.Color.FromArgb(230, 230, 240);
            this.btnLaIlahe.Location = new System.Drawing.Point(20, 286);
            this.btnLaIlahe.Name = "btnLaIlahe";
            this.btnLaIlahe.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnLaIlahe.Size = new System.Drawing.Size(480, 48);
            this.btnLaIlahe.TabIndex = 7;
            this.btnLaIlahe.Text = "Lâ ilâhe illallah                              0 / 100";
            this.btnLaIlahe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaIlahe.UseVisualStyleBackColor = false;
            this.btnLaIlahe.Click += new System.EventHandler(this.btnZikir_Click);
            // 
            // btnSubhanallahiBihamdihi
            // 
            this.btnSubhanallahiBihamdihi.BackColor = System.Drawing.Color.FromArgb(28, 31, 72);
            this.btnSubhanallahiBihamdihi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubhanallahiBihamdihi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 54, 110);
            this.btnSubhanallahiBihamdihi.FlatAppearance.BorderSize = 1;
            this.btnSubhanallahiBihamdihi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 42, 90);
            this.btnSubhanallahiBihamdihi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubhanallahiBihamdihi.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSubhanallahiBihamdihi.ForeColor = System.Drawing.Color.FromArgb(230, 230, 240);
            this.btnSubhanallahiBihamdihi.Location = new System.Drawing.Point(20, 340);
            this.btnSubhanallahiBihamdihi.Name = "btnSubhanallahiBihamdihi";
            this.btnSubhanallahiBihamdihi.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnSubhanallahiBihamdihi.Size = new System.Drawing.Size(480, 48);
            this.btnSubhanallahiBihamdihi.TabIndex = 8;
            this.btnSubhanallahiBihamdihi.Text = "Sübhanallahi ve bihamdihi                    0 / 100";
            this.btnSubhanallahiBihamdihi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubhanallahiBihamdihi.UseVisualStyleBackColor = false;
            this.btnSubhanallahiBihamdihi.Click += new System.EventHandler(this.btnZikir_Click);
            // 
            // btnEstagfirullah
            // 
            this.btnEstagfirullah.BackColor = System.Drawing.Color.FromArgb(28, 31, 72);
            this.btnEstagfirullah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstagfirullah.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 54, 110);
            this.btnEstagfirullah.FlatAppearance.BorderSize = 1;
            this.btnEstagfirullah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 42, 90);
            this.btnEstagfirullah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstagfirullah.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnEstagfirullah.ForeColor = System.Drawing.Color.FromArgb(230, 230, 240);
            this.btnEstagfirullah.Location = new System.Drawing.Point(20, 394);
            this.btnEstagfirullah.Name = "btnEstagfirullah";
            this.btnEstagfirullah.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnEstagfirullah.Size = new System.Drawing.Size(480, 48);
            this.btnEstagfirullah.TabIndex = 9;
            this.btnEstagfirullah.Text = "Estağfirullah                                  0 / 100";
            this.btnEstagfirullah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstagfirullah.UseVisualStyleBackColor = false;
            this.btnEstagfirullah.Click += new System.EventHandler(this.btnZikir_Click);
            // 
            // btnSalavat
            // 
            this.btnSalavat.BackColor = System.Drawing.Color.FromArgb(28, 31, 72);
            this.btnSalavat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalavat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 54, 110);
            this.btnSalavat.FlatAppearance.BorderSize = 1;
            this.btnSalavat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 42, 90);
            this.btnSalavat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalavat.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSalavat.ForeColor = System.Drawing.Color.FromArgb(230, 230, 240);
            this.btnSalavat.Location = new System.Drawing.Point(20, 448);
            this.btnSalavat.Name = "btnSalavat";
            this.btnSalavat.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnSalavat.Size = new System.Drawing.Size(480, 48);
            this.btnSalavat.TabIndex = 10;
            this.btnSalavat.Text = "Salavat-ı Şerife                               0 / 100";
            this.btnSalavat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalavat.UseVisualStyleBackColor = false;
            this.btnSalavat.Click += new System.EventHandler(this.btnZikir_Click);
            // 
            // lblKisayolBilgi
            // 
            this.lblKisayolBilgi = new System.Windows.Forms.Label();
            this.lblKisayolBilgi.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblKisayolBilgi.ForeColor = System.Drawing.Color.FromArgb(100, 100, 130);
            this.lblKisayolBilgi.Location = new System.Drawing.Point(20, 506);
            this.lblKisayolBilgi.Name = "lblKisayolBilgi";
            this.lblKisayolBilgi.Size = new System.Drawing.Size(480, 18);
            this.lblKisayolBilgi.TabIndex = 12;
            this.lblKisayolBilgi.Text = "Kısayollar:  1-7 → Zikir say  |  R → Sıfırla  |  ESC → Kapat";
            this.lblKisayolBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(16, 18, 45);
            this.panelAlt.Controls.Add(this.lblToplam);
            this.panelAlt.Controls.Add(this.btnSifirla);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 530);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(520, 55);
            this.panelAlt.TabIndex = 11;
            // 
            // lblToplam
            // 
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblToplam.ForeColor = System.Drawing.Color.FromArgb(238, 193, 112);
            this.lblToplam.Location = new System.Drawing.Point(16, 14);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(250, 28);
            this.lblToplam.TabIndex = 0;
            this.lblToplam.Text = "Toplam: 0";
            // 
            // btnSifirla
            // 
            this.btnSifirla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSifirla.BackColor = System.Drawing.Color.FromArgb(28, 31, 72);
            this.btnSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifirla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 80, 110);
            this.btnSifirla.FlatAppearance.BorderSize = 1;
            this.btnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifirla.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSifirla.ForeColor = System.Drawing.Color.FromArgb(180, 180, 200);
            this.btnSifirla.Location = new System.Drawing.Point(370, 12);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(130, 32);
            this.btnSifirla.TabIndex = 1;
            this.btnSifirla.Text = "Tümünü Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // FormTesbih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(24, 27, 66);
            this.ClientSize = new System.Drawing.Size(520, 585);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.lblKisayolBilgi);
            this.Controls.Add(this.btnSalavat);
            this.Controls.Add(this.btnEstagfirullah);
            this.Controls.Add(this.btnSubhanallahiBihamdihi);
            this.Controls.Add(this.btnLaIlahe);
            this.Controls.Add(this.lblKategori2);
            this.Controls.Add(this.btnAllahuEkber);
            this.Controls.Add(this.btnElhamdulillah);
            this.Controls.Add(this.btnSubhanallah);
            this.Controls.Add(this.lblKategori1);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormTesbih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tesbihat & Zikir";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTesbih_KeyDown);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelAlt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblKategori1;
        private System.Windows.Forms.Button btnSubhanallah;
        private System.Windows.Forms.Button btnElhamdulillah;
        private System.Windows.Forms.Button btnAllahuEkber;
        private System.Windows.Forms.Label lblKategori2;
        private System.Windows.Forms.Button btnLaIlahe;
        private System.Windows.Forms.Button btnSubhanallahiBihamdihi;
        private System.Windows.Forms.Button btnEstagfirullah;
        private System.Windows.Forms.Button btnSalavat;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Label lblKisayolBilgi;
    }
}

