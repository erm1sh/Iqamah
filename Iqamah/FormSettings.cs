using System;
using System.Drawing;
using System.Windows.Forms;

namespace Iqamah
{
    public partial class FormSettings : Form
    {
        // Sürükleme değişkenleri
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // Hesaplama metodu isimleri
        private readonly string[] methodNames = new string[]
        {
            "Shia Ithna-Ashari",                             // 0
            "University of Islamic Sciences, Karachi",       // 1
            "Islamic Society of North America (ISNA)",       // 2
            "Muslim World League",                           // 3
            "Umm Al-Qura University, Makkah",                // 4
            "Egyptian General Authority of Survey",          // 5
            "(Kullanılmıyor)",                               // 6
            "Institute of Geophysics, University of Tehran", // 7
            "Gulf Region",                                   // 8
            "Kuwait",                                        // 9
            "Qatar",                                         // 10
            "Majlis Ugama Islam Singapura",                   // 11
            "Union Organization Islamic de France",          // 12
            "Diyanet İşleri Başkanlığı, Türkiye",            // 13
            "Spiritual Administration of Muslims of Russia", // 14
            "Moonsighting Committee Worldwide"               // 15
        };

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            // Konum ayarları
            txtCity.Text = Properties.Settings.Default.City;
            txtCountry.Text = Properties.Settings.Default.Country;

            // Metod combobox'ını doldur
            cmbMethod.Items.Clear();
            for (int i = 0; i < methodNames.Length; i++)
            {
                if (i == 6) continue;
                cmbMethod.Items.Add($"{i} - {methodNames[i]}");
            }

            int currentMethod = Properties.Settings.Default.Method;
            for (int i = 0; i < cmbMethod.Items.Count; i++)
            {
                if (cmbMethod.Items[i].ToString().StartsWith(currentMethod.ToString() + " -"))
                {
                    cmbMethod.SelectedIndex = i;
                    break;
                }
            }

            // Bildirim ayarları
            chkNotifications.Checked = Properties.Settings.Default.NotificationsEnabled;
            chkPrePrayerNotification.Checked = Properties.Settings.Default.PrePrayerNotification;
            nudPrePrayerMinutes.Value = Math.Max(1, Math.Min(60, Properties.Settings.Default.PrePrayerMinutes));
            chkMuteOnPrayer.Checked = Properties.Settings.Default.MuteOnPrayer;

            // Cuma ayarları
            chkCumaNotification.Checked = Properties.Settings.Default.CumaNotification;
            chkCumaHutbe.Checked = Properties.Settings.Default.CumaHutbeGoster;

            // Genel ayarlar
            chkAlwaysOnTop.Checked = Properties.Settings.Default.AlwaysOnTop;
            chkMinimizeToTray.Checked = Properties.Settings.Default.MinimizeToTray;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Şehir adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Ülke adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konum
            Properties.Settings.Default.City = txtCity.Text.Trim();
            Properties.Settings.Default.Country = txtCountry.Text.Trim();

            if (cmbMethod.SelectedItem != null)
            {
                string selected = cmbMethod.SelectedItem.ToString();
                int methodNum = int.Parse(selected.Split('-')[0].Trim());
                Properties.Settings.Default.Method = methodNum;
            }

            // Bildirim
            Properties.Settings.Default.NotificationsEnabled = chkNotifications.Checked;
            Properties.Settings.Default.PrePrayerNotification = chkPrePrayerNotification.Checked;
            Properties.Settings.Default.PrePrayerMinutes = (int)nudPrePrayerMinutes.Value;
            Properties.Settings.Default.MuteOnPrayer = chkMuteOnPrayer.Checked;

            // Cuma
            Properties.Settings.Default.CumaNotification = chkCumaNotification.Checked;
            Properties.Settings.Default.CumaHutbeGoster = chkCumaHutbe.Checked;

            // Genel
            Properties.Settings.Default.AlwaysOnTop = chkAlwaysOnTop.Checked;
            Properties.Settings.Default.MinimizeToTray = chkMinimizeToTray.Checked;

            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnKapatSettings_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Form sürükleme
        private void FormSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void FormSettings_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void FormSettings_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
