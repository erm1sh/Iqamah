namespace Iqamah
{
    partial class FormSplash
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblBismillah = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.lblYukleniyor = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Iqamah.Properties.Resources.iqamah;
            this.pictureBoxLogo.Location = new System.Drawing.Point(200, 40);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblBismillah
            // 
            this.lblBismillah.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.lblBismillah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.lblBismillah.Location = new System.Drawing.Point(0, 150);
            this.lblBismillah.Name = "lblBismillah";
            this.lblBismillah.Size = new System.Drawing.Size(500, 30);
            this.lblBismillah.TabIndex = 1;
            this.lblBismillah.Text = "\u0628\u0650\u0633\u0652\u0645\u0650 \u0627\u0644\u0644\u0647\u0650 \u0627\u0644\u0631\u0651\u064E\u062D\u0652\u0645\u0670\u0646\u0650 \u0627\u0644\u0631\u0651\u064E\u062D\u0650\u064A\u0645\u0650";
            this.lblBismillah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.lblAppName.Location = new System.Drawing.Point(0, 185);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(500, 65);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "Iqamah";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSlogan
            // 
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.lblSlogan.Location = new System.Drawing.Point(0, 250);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(500, 25);
            this.lblSlogan.TabIndex = 3;
            this.lblSlogan.Text = "Namaz Vakitleri & Manevi Rehber";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.Color.Transparent;
            this.panelProgress.Location = new System.Drawing.Point(0, 310);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(500, 20);
            this.panelProgress.TabIndex = 4;
            this.panelProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProgress_Paint);
            // 
            // lblYukleniyor
            // 
            this.lblYukleniyor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYukleniyor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.lblYukleniyor.Location = new System.Drawing.Point(0, 332);
            this.lblYukleniyor.Name = "lblYukleniyor";
            this.lblYukleniyor.Size = new System.Drawing.Size(500, 20);
            this.lblYukleniyor.TabIndex = 5;
            this.lblYukleniyor.Text = "Y\u00FCkleniyor...";
            this.lblYukleniyor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.lblVersion.Location = new System.Drawing.Point(0, 365);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(500, 18);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "v2.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblYukleniyor);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblBismillah);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iqamah";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblBismillah;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Label lblYukleniyor;
        private System.Windows.Forms.Label lblVersion;
    }
}

