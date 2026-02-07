using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Iqamah
{
    /// <summary>
    /// Genişletilmiş tesbihat ve zikir penceresi.
    /// Namaz sonrası tesbihat (33'lük) + günlük zikirler (100'lük).
    /// </summary>
    public partial class FormTesbih : Form
    {
        // Zikir verileri: (buton, isim, hedef, sayaç)
        private class ZikirItem
        {
            public Button Buton;
            public string Isim;
            public int Hedef;
            public int Sayac;
        }

        private List<ZikirItem> zikirler;
        private static readonly Color TAMAMLANDI = Color.FromArgb(40, 167, 69);
        private static readonly Color NORMAL = Color.FromArgb(230, 230, 240);
        private static readonly Color BORDER_NORMAL = Color.FromArgb(50, 54, 110);

        // Sürükleme
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FormTesbih()
        {
            InitializeComponent();
            ZikirleriHazirla();
            TumunuGuncelle();
        }

        private void ZikirleriHazirla()
        {
            zikirler = new List<ZikirItem>
            {
                new ZikirItem { Buton = btnSubhanallah, Isim = "Sübhanallah", Hedef = 33, Sayac = 0 },
                new ZikirItem { Buton = btnElhamdulillah, Isim = "Elhamdülillah", Hedef = 33, Sayac = 0 },
                new ZikirItem { Buton = btnAllahuEkber, Isim = "Allahü Ekber", Hedef = 33, Sayac = 0 },
                new ZikirItem { Buton = btnLaIlahe, Isim = "Lâ ilâhe illallah", Hedef = 100, Sayac = 0 },
                new ZikirItem { Buton = btnSubhanallahiBihamdihi, Isim = "Sübhanallahi ve bihamdihi", Hedef = 100, Sayac = 0 },
                new ZikirItem { Buton = btnEstagfirullah, Isim = "Estağfirullah", Hedef = 100, Sayac = 0 },
                new ZikirItem { Buton = btnSalavat, Isim = "Salavat-ı Şerife", Hedef = 100, Sayac = 0 },
            };
        }

        // =============================================
        // ZİKİR CLICK HANDLER (Tüm butonlar aynı handler)
        // =============================================

        private void btnZikir_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            var zikir = zikirler.Find(z => z.Buton == btn);
            if (zikir == null) return;

            if (zikir.Sayac < zikir.Hedef)
            {
                zikir.Sayac++;
                ZikirGuncelle(zikir);
                ToplamGuncelle();
            }
        }

        // =============================================
        // GÜNCELLEME
        // =============================================

        private void ZikirGuncelle(ZikirItem zikir)
        {
            string sayiText = $"{zikir.Sayac} / {zikir.Hedef}";
            int toplamKar = 44;
            int bosluk = toplamKar - zikir.Isim.Length - sayiText.Length;
            if (bosluk < 3) bosluk = 3;
            zikir.Buton.Text = zikir.Isim + new string(' ', bosluk) + sayiText;

            bool tamamlandi = zikir.Sayac >= zikir.Hedef;
            zikir.Buton.ForeColor = tamamlandi ? TAMAMLANDI : NORMAL;
            zikir.Buton.FlatAppearance.BorderColor = tamamlandi ? TAMAMLANDI : BORDER_NORMAL;
        }

        private void TumunuGuncelle()
        {
            foreach (var z in zikirler)
                ZikirGuncelle(z);
            ToplamGuncelle();
        }

        private void ToplamGuncelle()
        {
            int toplam = 0;
            foreach (var z in zikirler)
                toplam += z.Sayac;
            lblToplam.Text = $"Toplam: {toplam}";
        }

        // =============================================
        // SIFIRLA
        // =============================================

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            foreach (var z in zikirler)
                z.Sayac = 0;
            TumunuGuncelle();
        }

        // =============================================
        // KLAVYE KISAYOLLARI
        // =============================================

        private void FormTesbih_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    SimulateClick(0);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    SimulateClick(1);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    SimulateClick(2);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    SimulateClick(3);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    SimulateClick(4);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    SimulateClick(5);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    SimulateClick(6);
                    break;
                case Keys.R:
                    btnSifirla_Click(sender, e);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void SimulateClick(int index)
        {
            if (index >= 0 && index < zikirler.Count)
                btnZikir_Click(zikirler[index].Buton, EventArgs.Empty);
        }

        // =============================================
        // KAPAT
        // =============================================

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =============================================
        // SÜRÜKLEME
        // =============================================

        private void FormTesbih_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void FormTesbih_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void FormTesbih_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

