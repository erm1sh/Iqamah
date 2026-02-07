namespace Iqamah
{
    partial class FormSettings
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.chkNotifications = new System.Windows.Forms.CheckBox();
            this.chkMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.chkPrePrayerNotification = new System.Windows.Forms.CheckBox();
            this.nudPrePrayerMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblPrePrayerDk = new System.Windows.Forms.Label();
            this.chkCumaNotification = new System.Windows.Forms.CheckBox();
            this.chkCumaHutbe = new System.Windows.Forms.CheckBox();
            this.chkMuteOnPrayer = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKapatSettings = new System.Windows.Forms.Button();
            this.panelUst = new System.Windows.Forms.Panel();
            this.panelIcerik = new System.Windows.Forms.Panel();
            this.lblBildirimBaslik = new System.Windows.Forms.Label();
            this.lblCumaBaslik = new System.Windows.Forms.Label();
            this.lblGenelBaslik = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.nudPrePrayerMinutes)).BeginInit();
            this.panelUst.SuspendLayout();
            this.panelIcerik.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(16, 18, 45);
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Controls.Add(this.btnKapatSettings);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(500, 50);
            this.panelUst.TabIndex = 0;
            this.panelUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSettings_MouseDown);
            this.panelUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSettings_MouseMove);
            this.panelUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormSettings_MouseUp);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(238, 193, 112);
            this.lblBaslik.Location = new System.Drawing.Point(16, 10);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(98, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "⚙ Ayarlar";
            // 
            // btnKapatSettings
            // 
            this.btnKapatSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapatSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnKapatSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapatSettings.FlatAppearance.BorderSize = 0;
            this.btnKapatSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnKapatSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapatSettings.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnKapatSettings.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnKapatSettings.Location = new System.Drawing.Point(456, 8);
            this.btnKapatSettings.Name = "btnKapatSettings";
            this.btnKapatSettings.Size = new System.Drawing.Size(36, 36);
            this.btnKapatSettings.TabIndex = 1;
            this.btnKapatSettings.Text = "✕";
            this.btnKapatSettings.UseVisualStyleBackColor = false;
            this.btnKapatSettings.Click += new System.EventHandler(this.btnKapatSettings_Click);
            // 
            // panelIcerik
            // 
            this.panelIcerik.AutoScroll = true;
            this.panelIcerik.BackColor = System.Drawing.Color.FromArgb(24, 27, 66);
            this.panelIcerik.Controls.Add(this.lblCity);
            this.panelIcerik.Controls.Add(this.txtCity);
            this.panelIcerik.Controls.Add(this.lblCountry);
            this.panelIcerik.Controls.Add(this.txtCountry);
            this.panelIcerik.Controls.Add(this.lblMethod);
            this.panelIcerik.Controls.Add(this.cmbMethod);
            this.panelIcerik.Controls.Add(this.lblBildirimBaslik);
            this.panelIcerik.Controls.Add(this.chkNotifications);
            this.panelIcerik.Controls.Add(this.chkPrePrayerNotification);
            this.panelIcerik.Controls.Add(this.nudPrePrayerMinutes);
            this.panelIcerik.Controls.Add(this.lblPrePrayerDk);
            this.panelIcerik.Controls.Add(this.chkMuteOnPrayer);
            this.panelIcerik.Controls.Add(this.lblCumaBaslik);
            this.panelIcerik.Controls.Add(this.chkCumaNotification);
            this.panelIcerik.Controls.Add(this.chkCumaHutbe);
            this.panelIcerik.Controls.Add(this.lblGenelBaslik);
            this.panelIcerik.Controls.Add(this.chkAlwaysOnTop);
            this.panelIcerik.Controls.Add(this.chkMinimizeToTray);
            this.panelIcerik.Controls.Add(this.btnKaydet);
            this.panelIcerik.Controls.Add(this.btnIptal);
            this.panelIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIcerik.Location = new System.Drawing.Point(0, 50);
            this.panelIcerik.Name = "panelIcerik";
            this.panelIcerik.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelIcerik.Size = new System.Drawing.Size(500, 600);
            this.panelIcerik.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblCity.Location = new System.Drawing.Point(20, 15);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 20);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Şehir";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(40, 44, 96);
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(20, 38);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(460, 29);
            this.txtCity.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblCountry.Location = new System.Drawing.Point(20, 74);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(41, 20);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Ülke";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(40, 44, 96);
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCountry.ForeColor = System.Drawing.Color.White;
            this.txtCountry.Location = new System.Drawing.Point(20, 97);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(460, 29);
            this.txtCountry.TabIndex = 3;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMethod.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblMethod.Location = new System.Drawing.Point(20, 133);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(121, 20);
            this.lblMethod.TabIndex = 4;
            this.lblMethod.Text = "Hesaplama Metodu";
            // 
            // cmbMethod
            // 
            this.cmbMethod.BackColor = System.Drawing.Color.FromArgb(40, 44, 96);
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMethod.ForeColor = System.Drawing.Color.White;
            this.cmbMethod.Location = new System.Drawing.Point(20, 156);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(460, 25);
            this.cmbMethod.TabIndex = 5;

            // ═══════════════ BİLDİRİM AYARLARI ═══════════════
            // 
            // lblBildirimBaslik
            // 
            this.lblBildirimBaslik.AutoSize = true;
            this.lblBildirimBaslik.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBildirimBaslik.ForeColor = System.Drawing.Color.FromArgb(238, 193, 112);
            this.lblBildirimBaslik.Location = new System.Drawing.Point(20, 198);
            this.lblBildirimBaslik.Name = "lblBildirimBaslik";
            this.lblBildirimBaslik.Size = new System.Drawing.Size(140, 19);
            this.lblBildirimBaslik.TabIndex = 6;
            this.lblBildirimBaslik.Text = "BİLDİRİM AYARLARI";
            // 
            // chkNotifications
            // 
            this.chkNotifications.AutoSize = true;
            this.chkNotifications.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkNotifications.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.chkNotifications.Location = new System.Drawing.Point(20, 224);
            this.chkNotifications.Name = "chkNotifications";
            this.chkNotifications.Size = new System.Drawing.Size(227, 23);
            this.chkNotifications.TabIndex = 7;
            this.chkNotifications.Text = "Vakit girince bildirim göster";
            // 
            // chkPrePrayerNotification
            // 
            this.chkPrePrayerNotification.AutoSize = true;
            this.chkPrePrayerNotification.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkPrePrayerNotification.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.chkPrePrayerNotification.Location = new System.Drawing.Point(20, 252);
            this.chkPrePrayerNotification.Name = "chkPrePrayerNotification";
            this.chkPrePrayerNotification.Size = new System.Drawing.Size(200, 23);
            this.chkPrePrayerNotification.TabIndex = 8;
            this.chkPrePrayerNotification.Text = "Vakitten önce uyarı ver:";
            // 
            // nudPrePrayerMinutes
            // 
            this.nudPrePrayerMinutes.BackColor = System.Drawing.Color.FromArgb(40, 44, 96);
            this.nudPrePrayerMinutes.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.nudPrePrayerMinutes.ForeColor = System.Drawing.Color.White;
            this.nudPrePrayerMinutes.Location = new System.Drawing.Point(228, 250);
            this.nudPrePrayerMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            this.nudPrePrayerMinutes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudPrePrayerMinutes.Name = "nudPrePrayerMinutes";
            this.nudPrePrayerMinutes.Size = new System.Drawing.Size(60, 26);
            this.nudPrePrayerMinutes.TabIndex = 9;
            this.nudPrePrayerMinutes.Value = new decimal(new int[] { 15, 0, 0, 0 });
            this.nudPrePrayerMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrePrayerDk
            // 
            this.lblPrePrayerDk.AutoSize = true;
            this.lblPrePrayerDk.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblPrePrayerDk.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblPrePrayerDk.Location = new System.Drawing.Point(294, 253);
            this.lblPrePrayerDk.Name = "lblPrePrayerDk";
            this.lblPrePrayerDk.Size = new System.Drawing.Size(63, 19);
            this.lblPrePrayerDk.TabIndex = 10;
            this.lblPrePrayerDk.Text = "dk önce";
            // 
            // chkMuteOnPrayer
            // 
            this.chkMuteOnPrayer.AutoSize = true;
            this.chkMuteOnPrayer.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkMuteOnPrayer.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.chkMuteOnPrayer.Location = new System.Drawing.Point(20, 280);
            this.chkMuteOnPrayer.Name = "chkMuteOnPrayer";
            this.chkMuteOnPrayer.Size = new System.Drawing.Size(350, 23);
            this.chkMuteOnPrayer.TabIndex = 11;
            this.chkMuteOnPrayer.Text = "Namaz vaktinde bilgisayarı sessiz moda al";

            // ═══════════════ CUMA AYARLARI ═══════════════
            // 
            // lblCumaBaslik
            // 
            this.lblCumaBaslik.AutoSize = true;
            this.lblCumaBaslik.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCumaBaslik.ForeColor = System.Drawing.Color.FromArgb(238, 193, 112);
            this.lblCumaBaslik.Location = new System.Drawing.Point(20, 318);
            this.lblCumaBaslik.Name = "lblCumaBaslik";
            this.lblCumaBaslik.Size = new System.Drawing.Size(180, 19);
            this.lblCumaBaslik.TabIndex = 12;
            this.lblCumaBaslik.Text = "CUMA NAMAZI AYARLARI";
            // 
            // chkCumaNotification
            // 
            this.chkCumaNotification.AutoSize = true;
            this.chkCumaNotification.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkCumaNotification.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.chkCumaNotification.Location = new System.Drawing.Point(20, 344);
            this.chkCumaNotification.Name = "chkCumaNotification";
            this.chkCumaNotification.Size = new System.Drawing.Size(270, 23);
            this.chkCumaNotification.TabIndex = 13;
            this.chkCumaNotification.Text = "Cuma namazı için özel bildirim göster";
            // 
            // chkCumaHutbe
            // 
            this.chkCumaHutbe.AutoSize = true;
            this.chkCumaHutbe.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkCumaHutbe.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.chkCumaHutbe.Location = new System.Drawing.Point(20, 372);
            this.chkCumaHutbe.Name = "chkCumaHutbe";
            this.chkCumaHutbe.Size = new System.Drawing.Size(320, 23);
            this.chkCumaHutbe.TabIndex = 14;
            this.chkCumaHutbe.Text = "Hutbe erişim butonu göster";

            // ═══════════════ GENEL AYARLAR ═══════════════
            // 
            // lblGenelBaslik
            // 
            this.lblGenelBaslik.AutoSize = true;
            this.lblGenelBaslik.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenelBaslik.ForeColor = System.Drawing.Color.FromArgb(238, 193, 112);
            this.lblGenelBaslik.Location = new System.Drawing.Point(20, 412);
            this.lblGenelBaslik.Name = "lblGenelBaslik";
            this.lblGenelBaslik.Size = new System.Drawing.Size(120, 19);
            this.lblGenelBaslik.TabIndex = 15;
            this.lblGenelBaslik.Text = "GENEL AYARLAR";
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkAlwaysOnTop.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(20, 438);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(147, 23);
            this.chkAlwaysOnTop.TabIndex = 16;
            this.chkAlwaysOnTop.Text = "Her zaman üstte";
            // 
            // chkMinimizeToTray
            // 
            this.chkMinimizeToTray.AutoSize = true;
            this.chkMinimizeToTray.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkMinimizeToTray.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.chkMinimizeToTray.Location = new System.Drawing.Point(20, 466);
            this.chkMinimizeToTray.Name = "chkMinimizeToTray";
            this.chkMinimizeToTray.Size = new System.Drawing.Size(280, 23);
            this.chkMinimizeToTray.TabIndex = 17;
            this.chkMinimizeToTray.Text = "Kapatınca sistem tepsisine küçült";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(20, 510);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(222, 42);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "💾  Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(258, 510);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(222, 42);
            this.btnIptal.TabIndex = 19;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(24, 27, 66);
            this.ClientSize = new System.Drawing.Size(500, 650);
            this.Controls.Add(this.panelIcerik);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSettings_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSettings_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormSettings_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrePrayerMinutes)).EndInit();
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelIcerik.ResumeLayout(false);
            this.panelIcerik.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapatSettings;
        private System.Windows.Forms.Panel panelIcerik;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Label lblBildirimBaslik;
        private System.Windows.Forms.CheckBox chkNotifications;
        private System.Windows.Forms.CheckBox chkPrePrayerNotification;
        private System.Windows.Forms.NumericUpDown nudPrePrayerMinutes;
        private System.Windows.Forms.Label lblPrePrayerDk;
        private System.Windows.Forms.CheckBox chkMuteOnPrayer;
        private System.Windows.Forms.Label lblCumaBaslik;
        private System.Windows.Forms.CheckBox chkCumaNotification;
        private System.Windows.Forms.CheckBox chkCumaHutbe;
        private System.Windows.Forms.Label lblGenelBaslik;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.CheckBox chkMinimizeToTray;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}
