namespace Iqamah
{
    partial class FormBildirim
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
            this.components = new System.ComponentModel.Container();

            this.panelUst = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblVakitAdi = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblErteleInfo = new System.Windows.Forms.Label();
            this.btnErtele = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.otomatikKapatTimer = new System.Windows.Forms.Timer(this.components);

            this.panelUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst (Başlık çubuğu)
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(16, 18, 45);
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(420, 40);
            this.panelUst.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(238, 193, 112);
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblBaslik.Size = new System.Drawing.Size(420, 40);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "🕌  NAMAZ VAKTİ";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVakitAdi
            // 
            this.lblVakitAdi.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblVakitAdi.ForeColor = System.Drawing.Color.FromArgb(249, 249, 249);
            this.lblVakitAdi.Location = new System.Drawing.Point(0, 50);
            this.lblVakitAdi.Name = "lblVakitAdi";
            this.lblVakitAdi.Size = new System.Drawing.Size(420, 42);
            this.lblVakitAdi.TabIndex = 1;
            this.lblVakitAdi.Text = "Öğle Namazı";
            this.lblVakitAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaat
            // 
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.lblSaat.ForeColor = System.Drawing.Color.FromArgb(238, 193, 112);
            this.lblSaat.Location = new System.Drawing.Point(0, 92);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(420, 50);
            this.lblSaat.TabIndex = 2;
            this.lblSaat.Text = "12:15";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMesaj
            // 
            this.lblMesaj.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMesaj.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.lblMesaj.Location = new System.Drawing.Point(0, 145);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(420, 22);
            this.lblMesaj.TabIndex = 3;
            this.lblMesaj.Text = "Namaz vakti girdi!";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnErtele
            // 
            this.btnErtele.BackColor = System.Drawing.Color.FromArgb(40, 44, 96);
            this.btnErtele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErtele.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 120);
            this.btnErtele.FlatAppearance.BorderSize = 1;
            this.btnErtele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 60, 120);
            this.btnErtele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErtele.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnErtele.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.btnErtele.Location = new System.Drawing.Point(20, 180);
            this.btnErtele.Name = "btnErtele";
            this.btnErtele.Size = new System.Drawing.Size(185, 42);
            this.btnErtele.TabIndex = 4;
            this.btnErtele.Text = "⏰  Ertele (5dk)";
            this.btnErtele.UseVisualStyleBackColor = false;
            this.btnErtele.Click += new System.EventHandler(this.btnErtele_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnTamam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTamam.FlatAppearance.BorderSize = 0;
            this.btnTamam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnTamam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTamam.ForeColor = System.Drawing.Color.White;
            this.btnTamam.Location = new System.Drawing.Point(215, 180);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(185, 42);
            this.btnTamam.TabIndex = 5;
            this.btnTamam.Text = "✓  Tamam";
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // lblErteleInfo
            // 
            this.lblErteleInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblErteleInfo.ForeColor = System.Drawing.Color.FromArgb(120, 120, 150);
            this.lblErteleInfo.Location = new System.Drawing.Point(0, 228);
            this.lblErteleInfo.Name = "lblErteleInfo";
            this.lblErteleInfo.Size = new System.Drawing.Size(420, 18);
            this.lblErteleInfo.TabIndex = 6;
            this.lblErteleInfo.Text = "";
            this.lblErteleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otomatikKapatTimer
            // 
            this.otomatikKapatTimer.Interval = 60000;
            this.otomatikKapatTimer.Tick += new System.EventHandler(this.otomatikKapatTimer_Tick);
            // 
            // FormBildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(24, 27, 66);
            this.ClientSize = new System.Drawing.Size(420, 250);
            this.Controls.Add(this.lblErteleInfo);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnErtele);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblVakitAdi);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBildirim";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Namaz Vakti Bildirimi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormBildirim_Load);
            this.panelUst.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblVakitAdi;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblErteleInfo;
        private System.Windows.Forms.Button btnErtele;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Timer otomatikKapatTimer;
    }
}

