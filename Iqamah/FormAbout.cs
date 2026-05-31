using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Iqamah
{
    public partial class FormAbout : Form
    {
        // Sürükleme değişkenleri
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FormAbout()
        {
            InitializeComponent();
        }

        private void btnKapatAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com",
                    UseShellExecute = true
                });
            }
            catch { }
        }

        // Form sürükleme
        private void FormAbout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void FormAbout_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void FormAbout_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

