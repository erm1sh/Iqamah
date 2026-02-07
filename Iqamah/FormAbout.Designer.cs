namespace Iqamah
{
    partial class FormAbout
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
            this.btnKapatAbout = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblApiInfo = new System.Windows.Forms.Label();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(60)))));
            this.panelUst.Controls.Add(this.lblBaslik);
            this.panelUst.Controls.Add(this.btnKapatAbout);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(420, 50);
            this.panelUst.TabIndex = 0;
            this.panelUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAbout_MouseDown);
            this.panelUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAbout_MouseMove);
            this.panelUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAbout_MouseUp);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.lblBaslik.Location = new System.Drawing.Point(16, 10);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(118, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "ℹ Hakkında";
            // 
            // btnKapatAbout
            // 
            this.btnKapatAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapatAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapatAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapatAbout.FlatAppearance.BorderSize = 0;
            this.btnKapatAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapatAbout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKapatAbout.ForeColor = System.Drawing.Color.White;
            this.btnKapatAbout.Location = new System.Drawing.Point(382, 10);
            this.btnKapatAbout.Name = "btnKapatAbout";
            this.btnKapatAbout.Size = new System.Drawing.Size(28, 28);
            this.btnKapatAbout.TabIndex = 1;
            this.btnKapatAbout.Text = "✕";
            this.btnKapatAbout.UseVisualStyleBackColor = false;
            this.btnKapatAbout.Click += new System.EventHandler(this.btnKapatAbout_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Iqamah.Properties.Resources.iqamah;
            this.pictureBoxLogo.Location = new System.Drawing.Point(60, 65);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(300, 80);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.lblAppName.Location = new System.Drawing.Point(0, 155);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(420, 40);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "Iqamah";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblVersion.Location = new System.Drawing.Point(0, 195);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(420, 25);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Sürüm 2.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblDescription.Location = new System.Drawing.Point(30, 235);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(360, 50);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Namaz vakitleri, geri sayım, özel bildirimler, tesbihat, hadis-i şerif ve hutbe erişimi sunan kapsamlı manevi rehber uygulaması.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApiInfo
            // 
            this.lblApiInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblApiInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.lblApiInfo.Location = new System.Drawing.Point(30, 295);
            this.lblApiInfo.Name = "lblApiInfo";
            this.lblApiInfo.Size = new System.Drawing.Size(360, 20);
            this.lblApiInfo.TabIndex = 5;
            this.lblApiInfo.Text = "Veri kaynağı: Aladhan Prayer Times API";
            this.lblApiInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.lblCopyright.Location = new System.Drawing.Point(0, 330);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(420, 20);
            this.lblCopyright.TabIndex = 6;
            this.lblCopyright.Text = "© 2026 Sixteen Digital";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(420, 370);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblApiInfo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hakkında";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAbout_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAbout_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAbout_MouseUp);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapatAbout;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblApiInfo;
    }
}

