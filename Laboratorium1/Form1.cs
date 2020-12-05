using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium1
{
    public partial class Okno : Form
    {
        public Okno()
        {
            InitializeComponent();
        }

        public Color WybierzKolor() {
            Color zwracanyKolor = Color.Black;
            switch(kolor.SelectedIndex){
                case 0:
                    zwracanyKolor = Color.Black;
                    break;
                case 1:
                    zwracanyKolor = Color.Red;
                    break;
                case 2:
                    zwracanyKolor = Color.Blue;
                    break;
            }
            return zwracanyKolor;
        }

        public void Przerysowywanie() {
            Pen pen = new Pen(WybierzKolor());
            System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(WybierzKolor());
            if (krzywa.Count > 1) {
                if (wypelnienie.Checked)
                {
                    rysowanie.FillPolygon(brush, krzywa.ToArray());
                }
                else
                {
                    rysowanie.DrawPolygon(pen, krzywa.ToArray());
                }
            }
            if (!o.IsEmpty) {
                if (wypelnienie.Checked)
                {
                    rysowanie.FillEllipse(brush, new RectangleF(o.X - promien, o.Y - promien, promien * 2, promien * 2));
                }
                else
                {
                    rysowanie.DrawEllipse(pen, new RectangleF(o.X - promien, o.Y - promien, promien * 2, promien * 2));
                }
            }
        }

        private void rysuj_Click(object sender, EventArgs e)
        {
            rysowanie.Clear(Color.White);
            Przerysowywanie();
            p1 = new Point((int)x1.Value, (int)y1.Value);
            p2 = new Point((int)x2.Value, (int)y2.Value);
            Pen pen = new Pen(WybierzKolor());
            rysowanie.DrawLine(pen, p1, p2);
        }

        private void Okno_Load(object sender, EventArgs e)
        {
            rysowanie = scena.CreateGraphics();
            krzywa = new List<PointF>();
        }

        private void scena_Click(object sender, EventArgs e)
        {
            krzywa.Add(new PointF(Control.MousePosition.X - this.Location.X - 8, Control.MousePosition.Y - this.Location.Y - 30));
            rysowanie.Clear(Color.White);
            Pen pen = new Pen(WybierzKolor());
            rysowanie.DrawLine(pen, p1, p2);
            Przerysowywanie();
        }

        private void scena_DoubleClick(object sender, EventArgs e)
        {
            promien = 10;
            o = new Point(Control.MousePosition.X - this.Location.X - 8, Control.MousePosition.Y - this.Location.Y - 30);
            rysowanie.Clear(Color.White);
            Przerysowywanie();
        }

        private void scena_MouseWheel(object sender, MouseEventArgs e)
        {
            rysowanie.Clear(Color.White);
            if (e.Delta > 0)
            {
                promien += 10;
            }
            else
            {
                promien -= 10;
            }
            Przerysowywanie();
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            rysowanie.Clear(Color.White);
            krzywa.Clear();
            promien = 0;
        }
    }
}
