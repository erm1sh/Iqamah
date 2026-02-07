namespace Iqamah
{
    partial class FormMain
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.labelKonum = new System.Windows.Forms.Label();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.labelTarih = new System.Windows.Forms.Label();
            this.panelVakitler = new System.Windows.Forms.Panel();
            this.lblVakitBaslik = new System.Windows.Forms.Label();
            this.labelSabah = new ReaLTaiizor.Controls.FoxBigLabel();
            this.labelSabahSaat = new ReaLTaiizor.Controls.BigLabel();
            this.chkSabah = new System.Windows.Forms.Label();
            this.labelGunes = new ReaLTaiizor.Controls.FoxBigLabel();
            this.labelGunesSaat = new ReaLTaiizor.Controls.BigLabel();
            this.labelOgle = new ReaLTaiizor.Controls.FoxBigLabel();
            this.labelOgleSaat = new ReaLTaiizor.Controls.BigLabel();
            this.chkOgle = new System.Windows.Forms.Label();
            this.labelIkindi = new ReaLTaiizor.Controls.FoxBigLabel();
            this.labelIkindiSaat = new ReaLTaiizor.Controls.BigLabel();
            this.chkIkindi = new System.Windows.Forms.Label();
            this.labelAksam = new ReaLTaiizor.Controls.FoxBigLabel();
            this.labelAksamSaat = new ReaLTaiizor.Controls.BigLabel();
            this.chkAksam = new System.Windows.Forms.Label();
            this.labelYatsi = new ReaLTaiizor.Controls.FoxBigLabel();
            this.labelYatsiSaat = new ReaLTaiizor.Controls.BigLabel();
            this.chkYatsi = new System.Windows.Forms.Label();
            this.panelGeriSayim = new System.Windows.Forms.Panel();
            this.labelInfo = new ReaLTaiizor.Controls.BigLabel();
            this.labelTime = new ReaLTaiizor.Controls.BigLabel();
            this.panelAyirici = new System.Windows.Forms.Panel();
            this.labelSaatBaslik = new System.Windows.Forms.Label();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.panelHizliErisim = new System.Windows.Forms.Panel();
            this.lblHizliErisimBaslik = new System.Windows.Forms.Label();
            this.btnTesbihAc = new System.Windows.Forms.Button();
            this.btnHutbeAc = new System.Windows.Forms.Button();
            this.lblKisayollar = new System.Windows.Forms.Label();
            this.panelHadis = new System.Windows.Forms.Panel();
            this.lblHadisMetin = new System.Windows.Forms.Label();
            this.parrotFormEllipse1 = new ReaLTaiizor.Controls.ParrotFormEllipse();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuTesbih = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.hadisTimer = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelVakitler.SuspendLayout();
            this.panelGeriSayim.SuspendLayout();
            this.panelHizliErisim.SuspendLayout();
            this.panelHadis.SuspendLayout();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(45)))));
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.labelKonum);
            this.panelHeader.Controls.Add(this.btnAyarlar);
            this.panelHeader.Controls.Add(this.btnHakkinda);
            this.panelHeader.Controls.Add(this.btnKucult);
            this.panelHeader.Controls.Add(this.btnKapat);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 60);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Iqamah.Properties.Resources.iqamah;
            this.pictureBoxLogo.Location = new System.Drawing.Point(14, 6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.lblTitle.Location = new System.Drawing.Point(68, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Iqamah";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(170)))));
            this.lblSubtitle.Location = new System.Drawing.Point(70, 37);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(88, 15);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Namaz Vakitleri";
            // 
            // labelKonum
            // 
            this.labelKonum.AutoSize = true;
            this.labelKonum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelKonum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.labelKonum.Location = new System.Drawing.Point(200, 18);
            this.labelKonum.Name = "labelKonum";
            this.labelKonum.Size = new System.Drawing.Size(0, 19);
            this.labelKonum.TabIndex = 3;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAyarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnAyarlar.Location = new System.Drawing.Point(940, 12);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(36, 36);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "⚙";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHakkinda.BackColor = System.Drawing.Color.Transparent;
            this.btnHakkinda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHakkinda.FlatAppearance.BorderSize = 0;
            this.btnHakkinda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(96)))));
            this.btnHakkinda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHakkinda.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnHakkinda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnHakkinda.Location = new System.Drawing.Point(980, 12);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(36, 36);
            this.btnHakkinda.TabIndex = 5;
            this.btnHakkinda.Text = "ℹ";
            this.btnHakkinda.UseVisualStyleBackColor = false;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKucult.BackColor = System.Drawing.Color.Transparent;
            this.btnKucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnKucult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnKucult.Location = new System.Drawing.Point(1020, 12);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(36, 36);
            this.btnKucult.TabIndex = 6;
            this.btnKucult.Text = "━";
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnKapat.Location = new System.Drawing.Point(1056, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(36, 36);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "✕";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // labelTarih
            // 
            this.labelTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(56)))));
            this.labelTarih.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.labelTarih.Location = new System.Drawing.Point(0, 60);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(1100, 30);
            this.labelTarih.TabIndex = 8;
            this.labelTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelVakitler
            // 
            this.panelVakitler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.panelVakitler.Controls.Add(this.lblVakitBaslik);
            this.panelVakitler.Controls.Add(this.labelSabah);
            this.panelVakitler.Controls.Add(this.labelSabahSaat);
            this.panelVakitler.Controls.Add(this.chkSabah);
            this.panelVakitler.Controls.Add(this.labelGunes);
            this.panelVakitler.Controls.Add(this.labelGunesSaat);
            this.panelVakitler.Controls.Add(this.labelOgle);
            this.panelVakitler.Controls.Add(this.labelOgleSaat);
            this.panelVakitler.Controls.Add(this.chkOgle);
            this.panelVakitler.Controls.Add(this.labelIkindi);
            this.panelVakitler.Controls.Add(this.labelIkindiSaat);
            this.panelVakitler.Controls.Add(this.chkIkindi);
            this.panelVakitler.Controls.Add(this.labelAksam);
            this.panelVakitler.Controls.Add(this.labelAksamSaat);
            this.panelVakitler.Controls.Add(this.chkAksam);
            this.panelVakitler.Controls.Add(this.labelYatsi);
            this.panelVakitler.Controls.Add(this.labelYatsiSaat);
            this.panelVakitler.Controls.Add(this.chkYatsi);
            this.panelVakitler.Location = new System.Drawing.Point(15, 100);
            this.panelVakitler.Name = "panelVakitler";
            this.panelVakitler.Size = new System.Drawing.Size(445, 500);
            this.panelVakitler.TabIndex = 9;
            // 
            // lblVakitBaslik
            // 
            this.lblVakitBaslik.AutoSize = true;
            this.lblVakitBaslik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblVakitBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.lblVakitBaslik.Location = new System.Drawing.Point(18, 14);
            this.lblVakitBaslik.Name = "lblVakitBaslik";
            this.lblVakitBaslik.Size = new System.Drawing.Size(175, 20);
            this.lblVakitBaslik.TabIndex = 0;
            this.lblVakitBaslik.Text = "☪  NAMAZ VAKİTLERİ";
            // 
            // labelSabah
            // 
            this.labelSabah.BackColor = System.Drawing.Color.Transparent;
            this.labelSabah.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.labelSabah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.labelSabah.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.labelSabah.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(110)))));
            this.labelSabah.Location = new System.Drawing.Point(18, 50);
            this.labelSabah.Name = "labelSabah";
            this.labelSabah.Size = new System.Drawing.Size(110, 38);
            this.labelSabah.TabIndex = 1;
            this.labelSabah.Text = "Sabah";
            // 
            // labelSabahSaat
            // 
            this.labelSabahSaat.BackColor = System.Drawing.Color.Transparent;
            this.labelSabahSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 19F);
            this.labelSabahSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelSabahSaat.Location = new System.Drawing.Point(220, 48);
            this.labelSabahSaat.Name = "labelSabahSaat";
            this.labelSabahSaat.Size = new System.Drawing.Size(130, 40);
            this.labelSabahSaat.TabIndex = 2;
            this.labelSabahSaat.Text = "--:--";
            // 
            // chkSabah
            // 
            this.chkSabah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSabah.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.chkSabah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.chkSabah.Location = new System.Drawing.Point(385, 46);
            this.chkSabah.Name = "chkSabah";
            this.chkSabah.Size = new System.Drawing.Size(42, 42);
            this.chkSabah.TabIndex = 3;
            this.chkSabah.Text = "☐";
            this.chkSabah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSabah.Click += new System.EventHandler(this.NamazCheck_Click);
            // 
            // labelGunes
            // 
            this.labelGunes.BackColor = System.Drawing.Color.Transparent;
            this.labelGunes.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.labelGunes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.labelGunes.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.labelGunes.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(110)))));
            this.labelGunes.Location = new System.Drawing.Point(18, 122);
            this.labelGunes.Name = "labelGunes";
            this.labelGunes.Size = new System.Drawing.Size(110, 38);
            this.labelGunes.TabIndex = 4;
            this.labelGunes.Text = "Güneş";
            // 
            // labelGunesSaat
            // 
            this.labelGunesSaat.BackColor = System.Drawing.Color.Transparent;
            this.labelGunesSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 19F);
            this.labelGunesSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelGunesSaat.Location = new System.Drawing.Point(220, 120);
            this.labelGunesSaat.Name = "labelGunesSaat";
            this.labelGunesSaat.Size = new System.Drawing.Size(130, 40);
            this.labelGunesSaat.TabIndex = 5;
            this.labelGunesSaat.Text = "--:--";
            // 
            // labelOgle
            // 
            this.labelOgle.BackColor = System.Drawing.Color.Transparent;
            this.labelOgle.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.labelOgle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.labelOgle.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.labelOgle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(110)))));
            this.labelOgle.Location = new System.Drawing.Point(18, 194);
            this.labelOgle.Name = "labelOgle";
            this.labelOgle.Size = new System.Drawing.Size(110, 38);
            this.labelOgle.TabIndex = 6;
            this.labelOgle.Text = "Öğle";
            // 
            // labelOgleSaat
            // 
            this.labelOgleSaat.BackColor = System.Drawing.Color.Transparent;
            this.labelOgleSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 19F);
            this.labelOgleSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelOgleSaat.Location = new System.Drawing.Point(220, 192);
            this.labelOgleSaat.Name = "labelOgleSaat";
            this.labelOgleSaat.Size = new System.Drawing.Size(130, 40);
            this.labelOgleSaat.TabIndex = 7;
            this.labelOgleSaat.Text = "--:--";
            // 
            // chkOgle
            // 
            this.chkOgle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOgle.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.chkOgle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.chkOgle.Location = new System.Drawing.Point(385, 190);
            this.chkOgle.Name = "chkOgle";
            this.chkOgle.Size = new System.Drawing.Size(42, 42);
            this.chkOgle.TabIndex = 8;
            this.chkOgle.Text = "☐";
            this.chkOgle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOgle.Click += new System.EventHandler(this.NamazCheck_Click);
            // 
            // labelIkindi
            // 
            this.labelIkindi.BackColor = System.Drawing.Color.Transparent;
            this.labelIkindi.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.labelIkindi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.labelIkindi.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.labelIkindi.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(110)))));
            this.labelIkindi.Location = new System.Drawing.Point(18, 266);
            this.labelIkindi.Name = "labelIkindi";
            this.labelIkindi.Size = new System.Drawing.Size(110, 38);
            this.labelIkindi.TabIndex = 9;
            this.labelIkindi.Text = "İkindi";
            // 
            // labelIkindiSaat
            // 
            this.labelIkindiSaat.BackColor = System.Drawing.Color.Transparent;
            this.labelIkindiSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 19F);
            this.labelIkindiSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelIkindiSaat.Location = new System.Drawing.Point(220, 264);
            this.labelIkindiSaat.Name = "labelIkindiSaat";
            this.labelIkindiSaat.Size = new System.Drawing.Size(130, 40);
            this.labelIkindiSaat.TabIndex = 10;
            this.labelIkindiSaat.Text = "--:--";
            // 
            // chkIkindi
            // 
            this.chkIkindi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIkindi.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.chkIkindi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.chkIkindi.Location = new System.Drawing.Point(385, 262);
            this.chkIkindi.Name = "chkIkindi";
            this.chkIkindi.Size = new System.Drawing.Size(42, 42);
            this.chkIkindi.TabIndex = 11;
            this.chkIkindi.Text = "☐";
            this.chkIkindi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIkindi.Click += new System.EventHandler(this.NamazCheck_Click);
            // 
            // labelAksam
            // 
            this.labelAksam.BackColor = System.Drawing.Color.Transparent;
            this.labelAksam.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.labelAksam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.labelAksam.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.labelAksam.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(110)))));
            this.labelAksam.Location = new System.Drawing.Point(18, 338);
            this.labelAksam.Name = "labelAksam";
            this.labelAksam.Size = new System.Drawing.Size(110, 38);
            this.labelAksam.TabIndex = 12;
            this.labelAksam.Text = "Akşam";
            // 
            // labelAksamSaat
            // 
            this.labelAksamSaat.BackColor = System.Drawing.Color.Transparent;
            this.labelAksamSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 19F);
            this.labelAksamSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelAksamSaat.Location = new System.Drawing.Point(220, 336);
            this.labelAksamSaat.Name = "labelAksamSaat";
            this.labelAksamSaat.Size = new System.Drawing.Size(130, 40);
            this.labelAksamSaat.TabIndex = 13;
            this.labelAksamSaat.Text = "--:--";
            // 
            // chkAksam
            // 
            this.chkAksam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAksam.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.chkAksam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.chkAksam.Location = new System.Drawing.Point(385, 334);
            this.chkAksam.Name = "chkAksam";
            this.chkAksam.Size = new System.Drawing.Size(42, 42);
            this.chkAksam.TabIndex = 14;
            this.chkAksam.Text = "☐";
            this.chkAksam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAksam.Click += new System.EventHandler(this.NamazCheck_Click);
            // 
            // labelYatsi
            // 
            this.labelYatsi.BackColor = System.Drawing.Color.Transparent;
            this.labelYatsi.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.labelYatsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.labelYatsi.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.labelYatsi.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(110)))));
            this.labelYatsi.Location = new System.Drawing.Point(18, 410);
            this.labelYatsi.Name = "labelYatsi";
            this.labelYatsi.Size = new System.Drawing.Size(110, 38);
            this.labelYatsi.TabIndex = 15;
            this.labelYatsi.Text = "Yatsı";
            // 
            // labelYatsiSaat
            // 
            this.labelYatsiSaat.BackColor = System.Drawing.Color.Transparent;
            this.labelYatsiSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 19F);
            this.labelYatsiSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.labelYatsiSaat.Location = new System.Drawing.Point(220, 408);
            this.labelYatsiSaat.Name = "labelYatsiSaat";
            this.labelYatsiSaat.Size = new System.Drawing.Size(130, 40);
            this.labelYatsiSaat.TabIndex = 16;
            this.labelYatsiSaat.Text = "--:--";
            // 
            // chkYatsi
            // 
            this.chkYatsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkYatsi.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.chkYatsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.chkYatsi.Location = new System.Drawing.Point(385, 406);
            this.chkYatsi.Name = "chkYatsi";
            this.chkYatsi.Size = new System.Drawing.Size(42, 42);
            this.chkYatsi.TabIndex = 17;
            this.chkYatsi.Text = "☐";
            this.chkYatsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkYatsi.Click += new System.EventHandler(this.NamazCheck_Click);
            // 
            // panelGeriSayim
            // 
            this.panelGeriSayim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.panelGeriSayim.Controls.Add(this.labelInfo);
            this.panelGeriSayim.Controls.Add(this.labelTime);
            this.panelGeriSayim.Controls.Add(this.panelAyirici);
            this.panelGeriSayim.Controls.Add(this.labelSaatBaslik);
            this.panelGeriSayim.Controls.Add(this.bigLabel2);
            this.panelGeriSayim.Location = new System.Drawing.Point(475, 100);
            this.panelGeriSayim.Name = "panelGeriSayim";
            this.panelGeriSayim.Size = new System.Drawing.Size(610, 230);
            this.panelGeriSayim.TabIndex = 10;
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.labelInfo.Location = new System.Drawing.Point(15, 15);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(580, 30);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Yükleniyor...";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.labelTime.Location = new System.Drawing.Point(15, 45);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(580, 80);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "--:--:--";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAyirici
            // 
            this.panelAyirici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(110)))));
            this.panelAyirici.Location = new System.Drawing.Point(50, 132);
            this.panelAyirici.Name = "panelAyirici";
            this.panelAyirici.Size = new System.Drawing.Size(510, 1);
            this.panelAyirici.TabIndex = 2;
            // 
            // labelSaatBaslik
            // 
            this.labelSaatBaslik.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelSaatBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(170)))));
            this.labelSaatBaslik.Location = new System.Drawing.Point(15, 142);
            this.labelSaatBaslik.Name = "labelSaatBaslik";
            this.labelSaatBaslik.Size = new System.Drawing.Size(580, 22);
            this.labelSaatBaslik.TabIndex = 3;
            this.labelSaatBaslik.Text = "Şu anki saat";
            this.labelSaatBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigLabel2
            // 
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.bigLabel2.Location = new System.Drawing.Point(15, 165);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(580, 55);
            this.bigLabel2.TabIndex = 4;
            this.bigLabel2.Text = "--:--:--";
            this.bigLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHizliErisim
            // 
            this.panelHizliErisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.panelHizliErisim.Controls.Add(this.lblHizliErisimBaslik);
            this.panelHizliErisim.Controls.Add(this.btnTesbihAc);
            this.panelHizliErisim.Controls.Add(this.btnHutbeAc);
            this.panelHizliErisim.Controls.Add(this.lblKisayollar);
            this.panelHizliErisim.Location = new System.Drawing.Point(475, 345);
            this.panelHizliErisim.Name = "panelHizliErisim";
            this.panelHizliErisim.Size = new System.Drawing.Size(610, 255);
            this.panelHizliErisim.TabIndex = 11;
            // 
            // lblHizliErisimBaslik
            // 
            this.lblHizliErisimBaslik.AutoSize = true;
            this.lblHizliErisimBaslik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHizliErisimBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(112)))));
            this.lblHizliErisimBaslik.Location = new System.Drawing.Point(18, 14);
            this.lblHizliErisimBaslik.Name = "lblHizliErisimBaslik";
            this.lblHizliErisimBaslik.Size = new System.Drawing.Size(131, 20);
            this.lblHizliErisimBaslik.TabIndex = 0;
            this.lblHizliErisimBaslik.Text = "🔗  HIZLI ERİŞİM";
            // 
            // btnTesbihAc
            // 
            this.btnTesbihAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(66)))));
            this.btnTesbihAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTesbihAc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(110)))));
            this.btnTesbihAc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btnTesbihAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesbihAc.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnTesbihAc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnTesbihAc.Location = new System.Drawing.Point(18, 48);
            this.btnTesbihAc.Name = "btnTesbihAc";
            this.btnTesbihAc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTesbihAc.Size = new System.Drawing.Size(574, 56);
            this.btnTesbihAc.TabIndex = 1;
            this.btnTesbihAc.Text = "📿   Tesbihat && Zikir";
            this.btnTesbihAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTesbihAc.UseVisualStyleBackColor = false;
            this.btnTesbihAc.Click += new System.EventHandler(this.btnTesbihAc_Click);
            // 
            // btnHutbeAc
            // 
            this.btnHutbeAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(66)))));
            this.btnHutbeAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHutbeAc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(110)))));
            this.btnHutbeAc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btnHutbeAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHutbeAc.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnHutbeAc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnHutbeAc.Location = new System.Drawing.Point(18, 114);
            this.btnHutbeAc.Name = "btnHutbeAc";
            this.btnHutbeAc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHutbeAc.Size = new System.Drawing.Size(574, 56);
            this.btnHutbeAc.TabIndex = 2;
            this.btnHutbeAc.Text = "🕌   Cuma Hutbesi (Diyanet)";
            this.btnHutbeAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHutbeAc.UseVisualStyleBackColor = false;
            this.btnHutbeAc.Click += new System.EventHandler(this.btnHutbeAc_Click);
            // 
            // lblKisayollar
            // 
            this.lblKisayollar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKisayollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.lblKisayollar.Location = new System.Drawing.Point(18, 185);
            this.lblKisayollar.Name = "lblKisayollar";
            this.lblKisayollar.Size = new System.Drawing.Size(574, 55);
            this.lblKisayollar.TabIndex = 3;
            this.lblKisayollar.Text = "F5 → Yenile  |  F1 → Hakkında  |  Ctrl+T → Üstte Tut  |  ESC → Tepsiye";
            this.lblKisayollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHadis
            // 
            this.panelHadis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(56)))));
            this.panelHadis.Controls.Add(this.lblHadisMetin);
            this.panelHadis.Location = new System.Drawing.Point(15, 615);
            this.panelHadis.Name = "panelHadis";
            this.panelHadis.Size = new System.Drawing.Size(1070, 70);
            this.panelHadis.TabIndex = 12;
            // 
            // lblHadisMetin
            // 
            this.lblHadisMetin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHadisMetin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.lblHadisMetin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.lblHadisMetin.Location = new System.Drawing.Point(0, 0);
            this.lblHadisMetin.Name = "lblHadisMetin";
            this.lblHadisMetin.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.lblHadisMetin.Size = new System.Drawing.Size(1070, 70);
            this.lblHadisMetin.TabIndex = 0;
            this.lblHadisMetin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parrotFormEllipse1
            // 
            this.parrotFormEllipse1.CornerRadius = 20;
            this.parrotFormEllipse1.EffectedForm = this;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayContextMenu;
            this.notifyIcon.Text = "Iqamah - Namaz Vakitleri";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuGoster,
            this.trayMenuAyarlar,
            this.trayMenuTesbih,
            this.trayMenuSeparator,
            this.trayMenuCikis});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(140, 98);
            // 
            // trayMenuGoster
            // 
            this.trayMenuGoster.Name = "trayMenuGoster";
            this.trayMenuGoster.Size = new System.Drawing.Size(139, 22);
            this.trayMenuGoster.Text = "Göster";
            this.trayMenuGoster.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.trayMenuGoster.Click += new System.EventHandler(this.trayMenuGoster_Click);
            // 
            // trayMenuAyarlar
            // 
            this.trayMenuAyarlar.Name = "trayMenuAyarlar";
            this.trayMenuAyarlar.Size = new System.Drawing.Size(139, 22);
            this.trayMenuAyarlar.Text = "⚙  Ayarlar";
            this.trayMenuAyarlar.Click += new System.EventHandler(this.trayMenuAyarlar_Click);
            // 
            // trayMenuTesbih
            // 
            this.trayMenuTesbih.Name = "trayMenuTesbih";
            this.trayMenuTesbih.Size = new System.Drawing.Size(139, 22);
            this.trayMenuTesbih.Text = "📿  Tesbihat";
            this.trayMenuTesbih.Click += new System.EventHandler(this.trayMenuTesbih_Click);
            // 
            // trayMenuSeparator
            // 
            this.trayMenuSeparator.Name = "trayMenuSeparator";
            this.trayMenuSeparator.Size = new System.Drawing.Size(136, 6);
            // 
            // trayMenuCikis
            // 
            this.trayMenuCikis.Name = "trayMenuCikis";
            this.trayMenuCikis.Size = new System.Drawing.Size(139, 22);
            this.trayMenuCikis.Text = "Çıkış";
            this.trayMenuCikis.Click += new System.EventHandler(this.trayMenuCikis_Click);
            // 
            // hadisTimer
            // 
            this.hadisTimer.Interval = 30000;
            this.hadisTimer.Tick += new System.EventHandler(this.hadisTimer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelHadis);
            this.Controls.Add(this.panelHizliErisim);
            this.Controls.Add(this.panelGeriSayim);
            this.Controls.Add(this.panelVakitler);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iqamah - Namaz Vakitleri";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelVakitler.ResumeLayout(false);
            this.panelVakitler.PerformLayout();
            this.panelGeriSayim.ResumeLayout(false);
            this.panelHizliErisim.ResumeLayout(false);
            this.panelHizliErisim.PerformLayout();
            this.panelHadis.ResumeLayout(false);
            this.trayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Panels
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelVakitler;
        private System.Windows.Forms.Panel panelGeriSayim;
        private System.Windows.Forms.Panel panelAyirici;
        private System.Windows.Forms.Panel panelHizliErisim;
        private System.Windows.Forms.Panel panelHadis;

        // Header
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label labelKonum;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnHakkinda;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label labelTarih;

        // Vakit labels
        private System.Windows.Forms.Label lblVakitBaslik;
        private ReaLTaiizor.Controls.FoxBigLabel labelSabah;
        private ReaLTaiizor.Controls.BigLabel labelSabahSaat;
        private System.Windows.Forms.Label chkSabah;
        private ReaLTaiizor.Controls.FoxBigLabel labelGunes;
        private ReaLTaiizor.Controls.BigLabel labelGunesSaat;
        private ReaLTaiizor.Controls.FoxBigLabel labelOgle;
        private ReaLTaiizor.Controls.BigLabel labelOgleSaat;
        private System.Windows.Forms.Label chkOgle;
        private ReaLTaiizor.Controls.FoxBigLabel labelIkindi;
        private ReaLTaiizor.Controls.BigLabel labelIkindiSaat;
        private System.Windows.Forms.Label chkIkindi;
        private ReaLTaiizor.Controls.FoxBigLabel labelAksam;
        private ReaLTaiizor.Controls.BigLabel labelAksamSaat;
        private System.Windows.Forms.Label chkAksam;
        private ReaLTaiizor.Controls.FoxBigLabel labelYatsi;
        private ReaLTaiizor.Controls.BigLabel labelYatsiSaat;
        private System.Windows.Forms.Label chkYatsi;

        // Geri sayım
        private ReaLTaiizor.Controls.BigLabel labelInfo;
        private ReaLTaiizor.Controls.BigLabel labelTime;
        private System.Windows.Forms.Label labelSaatBaslik;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;

        // Hızlı erişim
        private System.Windows.Forms.Label lblHizliErisimBaslik;
        private System.Windows.Forms.Button btnTesbihAc;
        private System.Windows.Forms.Button btnHutbeAc;
        private System.Windows.Forms.Label lblKisayollar;

        // Hadis
        private System.Windows.Forms.Label lblHadisMetin;

        // Diğer
        private ReaLTaiizor.Controls.ParrotFormEllipse parrotFormEllipse1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem trayMenuGoster;
        private System.Windows.Forms.ToolStripMenuItem trayMenuAyarlar;
        private System.Windows.Forms.ToolStripMenuItem trayMenuTesbih;
        private System.Windows.Forms.ToolStripSeparator trayMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem trayMenuCikis;
        private System.Windows.Forms.Timer hadisTimer;
    }
}
