using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using ReaLTaiizor.Controls;

namespace Iqamah
{
    public partial class FormMain : Form
    {
        // =============================================
        // ALANLAR (FIELDS)
        // =============================================

        // Namaz vakitleri verisi
        private Dictionary<string, TimeSpan> vakitler = new Dictionary<string, TimeSpan>();

        // Zamanlayıcı
        private Timer kalanSureTimer = new Timer();

        // Sürükleme (drag)
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // Vakit label eşleştirmeleri
        private Dictionary<string, FoxBigLabel> vakitLabelMap;
        private Dictionary<string, BigLabel> saatLabelMap;

        // Renk sabitleri
        private static readonly Color ALTIN_RENK = Color.FromArgb(238, 193, 112);
        private static readonly Color BEYAZ_RENK = Color.FromArgb(249, 249, 249);
        private static readonly Color AKTIF_RENK = Color.FromArgb(76, 175, 80);
        private static readonly Color GECMIS_RENK = Color.FromArgb(90, 90, 120);
        private static readonly Color TAMAMLANDI_RENK = Color.FromArgb(40, 167, 69);

        // Bildirim takibi
        private HashSet<string> bildirilenVakitler = new HashSet<string>();
        private HashSet<string> onBildirilenVakitler = new HashSet<string>();
        private DateTime sonBildirimTarihi = DateTime.MinValue;

        // Erteleme takibi (vakit adı → erteleme sayısı)
        private Dictionary<string, int> ertelemeSayilari = new Dictionary<string, int>();
        private Dictionary<string, Timer> erteleTimerlari = new Dictionary<string, Timer>();

        // Namaz kılındı takibi
        private Label[] namazCheckLabels;

        // Gece yarısı yenileme kontrolü
        private DateTime sonYenilemeTarihi = DateTime.MinValue;

        // Hadis döngüsü
        private int hadisIndex = 0;

        // Cuma bildirimi gönderildi mi
        private bool cumaBildirimGonderildi = false;

        // Önbellek dosya yolu
        private readonly string cachePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Iqamah", "prayer_cache.json");

        // =============================================
        // CONSTRUCTOR
        // =============================================

        public FormMain()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyDown += FormMain_KeyDown;
            this.FormClosing += FormMain_FormClosing;

            kalanSureTimer.Interval = 1000;
            kalanSureTimer.Tick += KalanSureTimer_Tick;
        }

        // =============================================
        // NAMAZ VAKİTLERİ - API
        // =============================================

        public async Task LoadPrayerTimes()
        {
            string city = Properties.Settings.Default.City;
            string country = Properties.Settings.Default.Country;
            int method = Properties.Settings.Default.Method;
            string url = $"https://api.aladhan.com/v1/timingsByCity?city={city}&country={country}&method={method}";

            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(15);
                var response = await client.GetStringAsync(url);
                var json = JObject.Parse(response);
                    var timings = json["data"]["timings"];

                    vakitler.Clear();
                    vakitler["Fajr"] = TimeSpan.Parse(timings["Fajr"].ToString());
                    vakitler["Sunrise"] = TimeSpan.Parse(timings["Sunrise"].ToString());
                    vakitler["Dhuhr"] = TimeSpan.Parse(timings["Dhuhr"].ToString());
                    vakitler["Asr"] = TimeSpan.Parse(timings["Asr"].ToString());
                    vakitler["Maghrib"] = TimeSpan.Parse(timings["Maghrib"].ToString());
                    vakitler["Isha"] = TimeSpan.Parse(timings["Isha"].ToString());

                    labelSabahSaat.Text = vakitler["Fajr"].ToString(@"hh\:mm");
                    labelGunesSaat.Text = vakitler["Sunrise"].ToString(@"hh\:mm");
                    labelOgleSaat.Text = vakitler["Dhuhr"].ToString(@"hh\:mm");
                    labelIkindiSaat.Text = vakitler["Asr"].ToString(@"hh\:mm");
                    labelAksamSaat.Text = vakitler["Maghrib"].ToString(@"hh\:mm");
                    labelYatsiSaat.Text = vakitler["Isha"].ToString(@"hh\:mm");

                    var hijri = json["data"]["date"]["hijri"];
                    string hijriDate = $"{hijri["day"]} {hijri["month"]["en"]} {hijri["year"]}";
                    labelTarih.Text = DateTime.Now.ToString("dd MMMM yyyy, dddd") + "   ·   " + hijriDate;

                    labelKonum.Text = $"📍 {city}, {country}";

                    SavePrayerTimesToCache(response);
                }
            }
            catch (Exception ex)
            {
                labelInfo.Text = "Bağlantı hatası!";
                labelTime.Text = "--:--:--";
                labelKonum.Text = "📍 Konum Bilgisi Yok";
                labelTarih.Text = DateTime.Now.ToString("dd MMMM yyyy, dddd");

                if (LoadPrayerTimesFromCache())
                {
                    labelInfo.Text = "Çevrimdışı mod (önbellek)";
                }
                else
                {
                    MessageBox.Show(
                        "Namaz vakitleri yüklenirken hata oluştu.\nİnternet bağlantınızı kontrol edin.\n\nHata: " + ex.Message,
                        "Bağlantı Hatası",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        // =============================================
        // ÖNBELLEK (CACHE)
        // =============================================

        private void SavePrayerTimesToCache(string jsonResponse)
        {
            try
            {
                string dir = Path.GetDirectoryName(cachePath);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                File.WriteAllText(cachePath, jsonResponse);
            }
            catch { }
        }

        private bool LoadPrayerTimesFromCache()
        {
            try
            {
                if (!File.Exists(cachePath)) return false;

                string cached = File.ReadAllText(cachePath);
                var json = JObject.Parse(cached);
                var timings = json["data"]["timings"];

                vakitler.Clear();
                vakitler["Fajr"] = TimeSpan.Parse(timings["Fajr"].ToString());
                vakitler["Sunrise"] = TimeSpan.Parse(timings["Sunrise"].ToString());
                vakitler["Dhuhr"] = TimeSpan.Parse(timings["Dhuhr"].ToString());
                vakitler["Asr"] = TimeSpan.Parse(timings["Asr"].ToString());
                vakitler["Maghrib"] = TimeSpan.Parse(timings["Maghrib"].ToString());
                vakitler["Isha"] = TimeSpan.Parse(timings["Isha"].ToString());

                labelSabahSaat.Text = vakitler["Fajr"].ToString(@"hh\:mm");
                labelGunesSaat.Text = vakitler["Sunrise"].ToString(@"hh\:mm");
                labelOgleSaat.Text = vakitler["Dhuhr"].ToString(@"hh\:mm");
                labelIkindiSaat.Text = vakitler["Asr"].ToString(@"hh\:mm");
                labelAksamSaat.Text = vakitler["Maghrib"].ToString(@"hh\:mm");
                labelYatsiSaat.Text = vakitler["Isha"].ToString(@"hh\:mm");

                var hijri = json["data"]["date"]["hijri"];
                string hijriDate = $"{hijri["day"]} {hijri["month"]["en"]} {hijri["year"]}";
                labelTarih.Text = DateTime.Now.ToString("dd MMMM yyyy, dddd") + "   ·   " + hijriDate;

                labelKonum.Text = $"📍 {Properties.Settings.Default.City}, {Properties.Settings.Default.Country}";
                return true;
            }
            catch { return false; }
        }

        // =============================================
        // FORM YÜKLEME
        // =============================================

        private async void Form1_Load(object sender, EventArgs e)
        {
            vakitLabelMap = new Dictionary<string, FoxBigLabel>
            {
                { "Fajr", labelSabah }, { "Sunrise", labelGunes }, { "Dhuhr", labelOgle },
                { "Asr", labelIkindi }, { "Maghrib", labelAksam }, { "Isha", labelYatsi }
            };

            saatLabelMap = new Dictionary<string, BigLabel>
            {
                { "Fajr", labelSabahSaat }, { "Sunrise", labelGunesSaat }, { "Dhuhr", labelOgleSaat },
                { "Asr", labelIkindiSaat }, { "Maghrib", labelAksamSaat }, { "Isha", labelYatsiSaat }
            };

            namazCheckLabels = new Label[] { chkSabah, chkOgle, chkIkindi, chkAksam, chkYatsi };

            this.TopMost = Properties.Settings.Default.AlwaysOnTop;

            // ToolTip'ler
            var toolTip = new ToolTip();
            toolTip.BackColor = Color.FromArgb(32, 35, 82);
            toolTip.ForeColor = Color.FromArgb(200, 200, 220);
            toolTip.SetToolTip(btnAyarlar, "Ayarlar (⚙)");
            toolTip.SetToolTip(btnHakkinda, "Hakkında (F1)");
            toolTip.SetToolTip(btnKucult, "Küçült");
            toolTip.SetToolTip(btnKapat, "Kapat / Tepsiye (ESC)");

            // System tray
            notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon.Text = "Iqamah - Namaz Vakitleri";
            notifyIcon.Visible = true;

            // Günün hadisini göster + döngü başlat
            GununHadisiniGoster();
            hadisTimer.Start();

            // Cuma hutbe butonunu kontrol et
            CumaKontrol();

            // Vakitleri yükle ve timer başlat
            await LoadPrayerTimes();
            kalanSureTimer.Start();
        }

        // =============================================
        // ZAMANLAYICI TICK
        // =============================================

        private void KalanSureTimer_Tick(object sender, EventArgs e)
        {
            if (vakitler.Count == 0) return;

            TimeSpan now = DateTime.Now.TimeOfDay;
            bigLabel2.Text = DateTime.Now.ToString("HH:mm:ss");

            string[] sira = { "Fajr", "Sunrise", "Dhuhr", "Asr", "Maghrib", "Isha" };
            bool found = false;

            foreach (var vakit in sira)
            {
                if (vakitler.ContainsKey(vakit) && now < vakitler[vakit])
                {
                    TimeSpan kalan = vakitler[vakit] - now;
                    string turkceVakit = VakitTurkcesi(vakit);

                    labelInfo.Text = $"{turkceVakit} vaktine kalan süre";
                    labelTime.Text = kalan.ToString(@"hh\:mm\:ss");
                    notifyIcon.Text = $"Iqamah — {turkceVakit}: {kalan.Hours:D2}:{kalan.Minutes:D2}";
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                if (vakitler.ContainsKey("Fajr"))
                {
                    TimeSpan yarinFajr = (TimeSpan.FromHours(24) - now) + vakitler["Fajr"];
                    labelInfo.Text = "Yarın Sabah namazına kalan süre";
                    labelTime.Text = yarinFajr.ToString(@"hh\:mm\:ss");
                    notifyIcon.Text = $"Iqamah — Sabah'a: {yarinFajr.Hours:D2}:{yarinFajr.Minutes:D2}";
                }
            }

            VakitVurgula(now);
            CheckForPrayerTimeNotifications(now);
            CheckForPrePrayerNotifications(now);

            // Gece yarısı yenileme
            if (DateTime.Now.Date != sonYenilemeTarihi.Date && DateTime.Now.Hour == 0 && DateTime.Now.Minute == 0)
            {
                sonYenilemeTarihi = DateTime.Now;
                _ = LoadPrayerTimes();
                NamazCheckSifirla();
                GununHadisiniGoster();
                CumaKontrol();
                cumaBildirimGonderildi = false;

                // Erteleme sayaçlarını sıfırla
                ertelemeSayilari.Clear();
                foreach (var timer in erteleTimerlari.Values)
                    timer.Dispose();
                erteleTimerlari.Clear();
            }
        }

        // =============================================
        // VAKİT VURGULAMA
        // =============================================

        private void VakitVurgula(TimeSpan now)
        {
            string[] sira = { "Fajr", "Sunrise", "Dhuhr", "Asr", "Maghrib", "Isha" };
            string aktifVakit = null;

            for (int i = sira.Length - 1; i >= 0; i--)
            {
                if (vakitler.ContainsKey(sira[i]) && now >= vakitler[sira[i]])
                {
                    aktifVakit = sira[i];
                    break;
                }
            }

            foreach (var vakit in sira)
            {
                if (!vakitLabelMap.ContainsKey(vakit) || !saatLabelMap.ContainsKey(vakit)) continue;

                var vakitLabel = vakitLabelMap[vakit];
                var saatLabel = saatLabelMap[vakit];

                if (vakit == aktifVakit)
                {
                    vakitLabel.ForeColor = AKTIF_RENK;
                    saatLabel.ForeColor = AKTIF_RENK;
                }
                else if (vakitler.ContainsKey(vakit) && now > vakitler[vakit])
                {
                    vakitLabel.ForeColor = GECMIS_RENK;
                    saatLabel.ForeColor = GECMIS_RENK;
                }
                else
                {
                    vakitLabel.ForeColor = ALTIN_RENK;
                    saatLabel.ForeColor = BEYAZ_RENK;
                }
            }
        }

        // =============================================
        // CUSTOM BİLDİRİMLER — Vakit girişi
        // =============================================

        private void CheckForPrayerTimeNotifications(TimeSpan now)
        {
            if (!Properties.Settings.Default.NotificationsEnabled) return;

            if (DateTime.Now.Date != sonBildirimTarihi.Date)
            {
                bildirilenVakitler.Clear();
                onBildirilenVakitler.Clear();
                sonBildirimTarihi = DateTime.Now;
            }

            string[] namazVakitleri = { "Fajr", "Dhuhr", "Asr", "Maghrib", "Isha" };

            foreach (var vakit in namazVakitleri)
            {
                if (!vakitler.ContainsKey(vakit)) continue;
                if (bildirilenVakitler.Contains(vakit)) continue;

                TimeSpan vakitZamani = vakitler[vakit];
                TimeSpan fark = now - vakitZamani;

                if (fark.TotalSeconds >= 0 && fark.TotalSeconds < 60)
                {
                    bildirilenVakitler.Add(vakit);
                    CustomBildirimGoster(vakit, vakitZamani, false);
                }
            }

            // Cuma özel bildirimi
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday &&
                Properties.Settings.Default.CumaNotification &&
                !cumaBildirimGonderildi &&
                vakitler.ContainsKey("Dhuhr"))
            {
                TimeSpan dhuhr = vakitler["Dhuhr"];
                TimeSpan cumaUyari = dhuhr - TimeSpan.FromMinutes(60);
                TimeSpan farkCuma = now - cumaUyari;

                if (farkCuma.TotalSeconds >= 0 && farkCuma.TotalSeconds < 60)
                {
                    cumaBildirimGonderildi = true;
                    var bildirim = new FormBildirim
                    {
                        VakitAdi = "Cuma",
                        VakitSaati = dhuhr.ToString(@"hh\:mm"),
                        PrePrayerMode = true,
                        PrePrayerMinutes = 60
                    };
                    bildirim.Show();
                }
            }
        }

        // =============================================
        // CUSTOM BİLDİRİMLER — Vakitten önce uyarı
        // =============================================

        private void CheckForPrePrayerNotifications(TimeSpan now)
        {
            if (!Properties.Settings.Default.PrePrayerNotification) return;

            int dakika = Properties.Settings.Default.PrePrayerMinutes;
            if (dakika <= 0) return;

            string[] namazVakitleri = { "Fajr", "Dhuhr", "Asr", "Maghrib", "Isha" };

            foreach (var vakit in namazVakitleri)
            {
                if (!vakitler.ContainsKey(vakit)) continue;
                string key = "pre_" + vakit;
                if (onBildirilenVakitler.Contains(key)) continue;

                TimeSpan vakitZamani = vakitler[vakit];
                TimeSpan uyariZamani = vakitZamani - TimeSpan.FromMinutes(dakika);
                TimeSpan fark = now - uyariZamani;

                if (fark.TotalSeconds >= 0 && fark.TotalSeconds < 60)
                {
                    onBildirilenVakitler.Add(key);

                    var bildirim = new FormBildirim
                    {
                        VakitAdi = VakitTurkcesi(vakit),
                        VakitSaati = vakitZamani.ToString(@"hh\:mm"),
                        PrePrayerMode = true,
                        PrePrayerMinutes = dakika
                    };
                    bildirim.Show();
                }
            }
        }

        // =============================================
        // CUSTOM BİLDİRİM GÖSTERME + ERTELEME
        // =============================================

        private void CustomBildirimGoster(string vakit, TimeSpan vakitZamani, bool ertelemeden)
        {
            string turkce = VakitTurkcesi(vakit);

            if (!ertelemeSayilari.ContainsKey(vakit))
                ertelemeSayilari[vakit] = 0;

            int mevcut = ertelemeSayilari[vakit];

            // Ses susturma
            if (Properties.Settings.Default.MuteOnPrayer)
                AudioHelper.Sustur();

            var bildirim = new FormBildirim
            {
                VakitAdi = turkce,
                VakitSaati = vakitZamani.ToString(@"hh\:mm"),
                ErtelemeSayisi = mevcut,
                PrePrayerMode = false
            };

            bildirim.FormClosed += (s, args) =>
            {
                if (bildirim.Ertelendi && mevcut < bildirim.MaxErteleme)
                {
                    // Erteleme — 5 dakika sonra tekrar göster
                    ertelemeSayilari[vakit] = mevcut + 1;

                    // Ses aç (erteleme boyunca açık)
                    if (Properties.Settings.Default.MuteOnPrayer)
                        AudioHelper.SesAc();

                    var erteleTimer = new Timer();
                    erteleTimer.Interval = 5 * 60 * 1000; // 5 dakika
                    erteleTimer.Tick += (ts, te) =>
                    {
                        erteleTimer.Stop();
                        erteleTimer.Dispose();
                        if (erteleTimerlari.ContainsKey(vakit))
                            erteleTimerlari.Remove(vakit);
                        CustomBildirimGoster(vakit, vakitZamani, true);
                    };

                    if (erteleTimerlari.ContainsKey(vakit))
                    {
                        erteleTimerlari[vakit].Stop();
                        erteleTimerlari[vakit].Dispose();
                    }
                    erteleTimerlari[vakit] = erteleTimer;
                    erteleTimer.Start();
                }
                else
                {
                    // Tamam veya max erteleme — sesi aç
                    if (Properties.Settings.Default.MuteOnPrayer)
                        AudioHelper.SesAc();
                }
            };

            bildirim.Show();
        }

        // =============================================
        // HADİS DÖNGÜSÜ (30 saniyede bir)
        // =============================================

        private void GununHadisiniGoster()
        {
            hadisIndex = DateTime.Now.DayOfYear % GunlukIcerik.HadisSayisi;
            var (metin, kaynak) = GunlukIcerik.HadisGetir(hadisIndex);
            lblHadisMetin.Text = $"📖  \"{metin}\"     —  {kaynak}";
        }

        private void hadisTimer_Tick(object sender, EventArgs e)
        {
            hadisIndex++;
            var (metin, kaynak) = GunlukIcerik.HadisGetir(hadisIndex);
            lblHadisMetin.Text = $"📖  \"{metin}\"     —  {kaynak}";
        }

        // =============================================
        // CUMA KONTROLÜ
        // =============================================

        private void CumaKontrol()
        {
            // Hutbe butonu her gün erişilebilir olsun
            bool hutbeAyari = Properties.Settings.Default.CumaHutbeGoster;
            btnHutbeAc.Visible = hutbeAyari;
        }

        // =============================================
        // NAMAZ CHECK (Kılındı takibi)
        // =============================================

        private void NamazCheck_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;
            if (lbl == null) return;

            if (lbl.Text == "☐")
            {
                lbl.Text = "✓";
                lbl.ForeColor = TAMAMLANDI_RENK;
                lbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            }
            else
            {
                lbl.Text = "☐";
                lbl.ForeColor = Color.FromArgb(100, 100, 130);
                lbl.Font = new Font("Segoe UI", 20F);
            }
        }

        private void NamazCheckSifirla()
        {
            if (namazCheckLabels == null) return;
            foreach (var lbl in namazCheckLabels)
            {
                lbl.Text = "☐";
                lbl.ForeColor = Color.FromArgb(100, 100, 130);
                lbl.Font = new Font("Segoe UI", 20F);
            }
        }

        // =============================================
        // YARDIMCILAR
        // =============================================

        private string VakitTurkcesi(string ingilizce)
        {
            switch (ingilizce)
            {
                case "Fajr": return "Sabah";
                case "Sunrise": return "Güneş";
                case "Dhuhr": return "Öğle";
                case "Asr": return "İkindi";
                case "Maghrib": return "Akşam";
                case "Isha": return "Yatsı";
                default: return ingilizce;
            }
        }

        // =============================================
        // FORM SÜRÜKLEME
        // =============================================

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // =============================================
        // BUTON OLAYLARI
        // =============================================

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MinimizeToTray)
            {
                this.Hide();
                notifyIcon.Visible = true;
            }
            else
            {
                notifyIcon.Visible = false;
                notifyIcon.Dispose();
                Application.Exit();
            }
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new FormSettings())
            {
                if (settingsForm.ShowDialog(this) == DialogResult.OK)
                {
                    this.TopMost = Properties.Settings.Default.AlwaysOnTop;
                    CumaKontrol();
                    _ = LoadPrayerTimes();
                }
            }
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new FormAbout())
            {
                aboutForm.ShowDialog(this);
            }
        }

        private void btnTesbihAc_Click(object sender, EventArgs e)
        {
            var tesbihForm = new FormTesbih();
            tesbihForm.Show(this);
        }

        private void btnHutbeAc_Click(object sender, EventArgs e)
        {
            try
            {
                // Din Hizmetleri Genel Müdürlüğü - Hutbe Metinleri arşiv sayfası (her zaman güncel)
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://dinhizmetleri.diyanet.gov.tr/kategoriler/yayinlarimiz/hutbeler/t%C3%BCrk%C3%A7e",
                    UseShellExecute = true
                });
            }
            catch
            {
                MessageBox.Show(
                    "Diyanet hutbe sayfası açılamadı.\nLütfen tarayıcınızda manuel olarak açın:\nhttps://dinhizmetleri.diyanet.gov.tr",
                    "Hutbe Sayfası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // =============================================
        // SYSTEM TRAY
        // =============================================

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            FormuGoster();
        }

        private void trayMenuGoster_Click(object sender, EventArgs e)
        {
            FormuGoster();
        }

        /// <summary>
        /// Formu tray'den geri getirirken ekranın ortasına konumlar.
        /// </summary>
        private void FormuGoster()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;

            // Ekranın ortasına konumla
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(
                (screen.Width - this.Width) / 2 + screen.Left,
                (screen.Height - this.Height) / 2 + screen.Top
            );

            this.Activate();
        }

        private void trayMenuAyarlar_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            btnAyarlar_Click(sender, e);
        }

        private void trayMenuTesbih_Click(object sender, EventArgs e)
        {
            var tesbihForm = new FormTesbih();
            tesbihForm.Show();
        }

        private void trayMenuCikis_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
            Application.Exit();
        }

        // =============================================
        // FORM KAPANIŞ
        // =============================================

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Properties.Settings.Default.MinimizeToTray)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon.Visible = true;
            }
            else
            {
                // Tüm erteleme timer'larını temizle
                foreach (var timer in erteleTimerlari.Values)
                    timer.Dispose();
                erteleTimerlari.Clear();

                notifyIcon.Visible = false;
                notifyIcon.Dispose();
            }
        }

        // =============================================
        // KLAVYE KISAYOLLARI
        // =============================================

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btnKapat_Click(sender, e);
                    break;
                case Keys.F5:
                    _ = LoadPrayerTimes();
                    break;
                case Keys.F1:
                    btnHakkinda_Click(sender, e);
                    break;
                case Keys.T:
                    if (e.Control)
                    {
                        this.TopMost = !this.TopMost;
                        Properties.Settings.Default.AlwaysOnTop = this.TopMost;
                        Properties.Settings.Default.Save();
                    }
                    break;
            }
        }

    }
}
