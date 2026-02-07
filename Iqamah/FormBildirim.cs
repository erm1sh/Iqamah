using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Iqamah
{
    /// <summary>
    /// Özel namaz vakti bildirim penceresi.
    /// Windows bildirimlerinin yerine kullanılır.
    /// Ertele (5dk, max 3 kez) ve Tamam seçenekleri sunar.
    /// </summary>
    public partial class FormBildirim : Form
    {
        // Bildirim verileri
        public string VakitAdi { get; set; }
        public string VakitSaati { get; set; }
        public int ErtelemeSayisi { get; set; }
        public int MaxErteleme { get; } = 3;
        public bool PrePrayerMode { get; set; } = false;
        public int PrePrayerMinutes { get; set; } = 0;

        // Sonuç
        public bool Ertelendi { get; private set; } = false;

        // Ses çalıcı
        private SoundPlayer soundPlayer;

        public FormBildirim()
        {
            InitializeComponent();
        }

        // Odak çalmadan göster
        protected override bool ShowWithoutActivation => true;

        // Click-through değil ama odak çalmaz
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x00000008; // WS_EX_TOPMOST
                return cp;
            }
        }

        private void FormBildirim_Load(object sender, EventArgs e)
        {
            // Ekranın sağ alt köşesine konumla (görev çubuğunun üstü)
            Rectangle workArea = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(
                workArea.Right - this.Width - 15,
                workArea.Bottom - this.Height - 15
            );

            if (PrePrayerMode)
            {
                // Vakitten önce uyarı modu
                lblBaslik.Text = "⏰  VAKİT YAKLAŞIYOR";
                lblVakitAdi.Text = $"{VakitAdi} Namazı";
                lblSaat.Text = VakitSaati;
                lblMesaj.Text = $"Namaz vaktine {PrePrayerMinutes} dakika kaldı";
                btnErtele.Visible = false;
                btnTamam.Location = new Point(118, 180);
                btnTamam.Size = new Size(185, 42);
                lblErteleInfo.Text = "";

                // Ön bildirim sesi: alert.wav
                BildirimSesiCal("alert.wav");
            }
            else
            {
                // Normal vakit bildirimi
                lblVakitAdi.Text = $"{VakitAdi} Namazı";
                lblSaat.Text = VakitSaati;
                lblMesaj.Text = "Namaz vakti girdi!";

                if (ErtelemeSayisi >= MaxErteleme)
                {
                    // 3. ertelemeden sonra: son bildirim
                    btnErtele.Visible = false;
                    btnTamam.Location = new Point(118, 180);
                    btnTamam.Size = new Size(185, 42);
                    lblErteleInfo.Text = "Bu vakit için artık bildirim yapılmayacaktır.";
                    lblErteleInfo.ForeColor = Color.FromArgb(220, 53, 69);
                }
                else
                {
                    btnErtele.Visible = true;
                    if (ErtelemeSayisi > 0)
                    {
                        lblErteleInfo.Text = $"Erteleme: {ErtelemeSayisi}/{MaxErteleme}";
                    }
                }

                // Namaz vakti / erteleme sesi: prayerNotif.wav
                BildirimSesiCal("prayerNotif.wav");
            }

            // 60 saniye sonra otomatik kapat
            otomatikKapatTimer.Start();
        }

        /// <summary>
        /// Resources klasöründen belirtilen ses dosyasını çalar.
        /// </summary>
        private void BildirimSesiCal(string dosyaAdi)
        {
            try
            {
                string sesYolu = Path.Combine(Application.StartupPath, "Resources", dosyaAdi);
                if (File.Exists(sesYolu))
                {
                    soundPlayer = new SoundPlayer(sesYolu);
                    soundPlayer.Play();
                }
            }
            catch
            {
                // Ses çalınamazsa sessizce devam et
            }
        }

        private void btnErtele_Click(object sender, EventArgs e)
        {
            SesiDurdur();
            Ertelendi = true;
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            SesiDurdur();
            Ertelendi = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void otomatikKapatTimer_Tick(object sender, EventArgs e)
        {
            otomatikKapatTimer.Stop();
            SesiDurdur();
            // Otomatik kapanırsa ertele sayılmaz
            Ertelendi = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Çalan sesi durdurur ve kaynağı serbest bırakır.
        /// </summary>
        private void SesiDurdur()
        {
            try
            {
                if (soundPlayer != null)
                {
                    soundPlayer.Stop();
                    soundPlayer.Dispose();
                    soundPlayer = null;
                }
            }
            catch { }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            SesiDurdur();
            base.OnFormClosed(e);
        }
    }
}
