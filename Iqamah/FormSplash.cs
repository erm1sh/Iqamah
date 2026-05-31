using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Iqamah
{
    /// <summary>
    /// Uygulama açılış ekranı.
    /// Güzel bir karşılama animasyonu gösterir.
    /// </summary>
    public partial class FormSplash : Form
    {
        private Timer animTimer;
        private int animStep = 0;
        private const int TOTAL_STEPS = 60; // ~3 saniye (50ms interval)
        private float progressValue = 0f;

        public FormSplash()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            animTimer = new Timer();
            animTimer.Interval = 50;
            animTimer.Tick += AnimTimer_Tick;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Opacity = 0;
            animTimer.Start();
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            animStep++;

            // Fade-in (ilk 10 adım)
            if (animStep <= 10)
            {
                this.Opacity = animStep / 10.0;
            }

            // Progress bar ilerlemesi
            progressValue = Math.Min(1.0f, (float)animStep / (TOTAL_STEPS - 10));
            panelProgress.Invalidate();

            // Fade-out (son 8 adım)
            if (animStep > TOTAL_STEPS - 8)
            {
                double remaining = TOTAL_STEPS - animStep;
                this.Opacity = remaining / 8.0;
            }

            // Bitir
            if (animStep >= TOTAL_STEPS)
            {
                animTimer.Stop();
                animTimer.Dispose();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void panelProgress_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int barHeight = 4;
            int barY = (panelProgress.Height - barHeight) / 2;
            int totalWidth = panelProgress.Width - 60;
            int barX = 30;

            // Arka plan çizgisi
            using (var bgBrush = new SolidBrush(Color.FromArgb(40, 44, 96)))
            {
                g.FillRoundedRectangle(bgBrush, barX, barY, totalWidth, barHeight, 2);
            }

            // İlerleme çizgisi
            int fillWidth = (int)(totalWidth * progressValue);
            if (fillWidth > 0)
            {
                using (var gradientBrush = new LinearGradientBrush(
                    new Rectangle(barX, barY, totalWidth, barHeight),
                    Color.FromArgb(238, 193, 112),
                    Color.FromArgb(200, 160, 80),
                    LinearGradientMode.Horizontal))
                {
                    g.FillRoundedRectangle(gradientBrush, barX, barY, fillWidth, barHeight, 2);
                }
            }
        }
    }

    // Extension method for rounded rectangle
    public static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics g, Brush brush, int x, int y, int width, int height, int radius)
        {
            if (width <= 0 || height <= 0) return;

            using (var path = new GraphicsPath())
            {
                if (radius <= 0)
                {
                    path.AddRectangle(new Rectangle(x, y, width, height));
                }
                else
                {
                    int d = radius * 2;
                    path.AddArc(x, y, d, d, 180, 90);
                    path.AddArc(x + width - d, y, d, d, 270, 90);
                    path.AddArc(x + width - d, y + height - d, d, d, 0, 90);
                    path.AddArc(x, y + height - d, d, d, 90, 90);
                    path.CloseFigure();
                }
                g.FillPath(brush, path);
            }
        }
    }
}

