using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labroatorium_6
{
    public partial class okno : Form
    {

        Graphics rysuj;
        PointF center;
        float size = 5;    // rozmiar kreski
        float distance = 20;  // odleglosc miedy kreskami
        int zoom = 0;
        int zoomOffset = 1;

        public okno()
        {
            InitializeComponent();
        }

        public void drawAxes(int xOffset, int yOffset, Color kolor) {
            Pen pen = new Pen(kolor);
            Font font = new Font("Arial", 8);
            SolidBrush brush = new SolidBrush(kolor);
            // rysowanie osi
            // offsety przesuwają srodek układu odniesienia
            rysuj.DrawLine(pen, xOffset, 0, xOffset, obraz.Height);
            rysuj.DrawLine(pen, 0, yOffset, obraz.Width, yOffset);

            // zoomowanie zmienia skale
            if (zoom < 5)
            {
                zoomOffset = 1;
            }
            else if (zoom < 10)
            {
                zoomOffset = 5;
            }
            else if (zoom < 25)
            {
                zoomOffset = 10;
            }
            else if (zoom < 50)
            {
                zoomOffset = 25;
            }
            else if (zoom < 100)
            {
                zoomOffset = 100;
            }


            // rysowanie przedziałek dla dodatnich wartosci osi X
            int positiveX = 0;
            for (int x = xOffset / zoomOffset; x < obraz.Width; x += (int)distance) {
                positiveX++;
                if (x != xOffset / zoomOffset)
                {
                    rysuj.DrawLine(pen, x * zoomOffset, yOffset - size / 2, x * zoomOffset, yOffset + size / 2);
                }
                rysuj.DrawString((positiveX* zoomOffset) +"", font, brush, (x * zoomOffset) + (int)distance * zoomOffset - 4, yOffset - size - 12);
            }

            // rysowanie przedziałek dla ujemnych wartosci osi X
            int negativeX = 0;
            for (int x = xOffset / zoomOffset; x > 0; x -= (int)distance)
            {
                negativeX--;
                if (x != xOffset / zoomOffset)
                {
                    rysuj.DrawLine(pen, x * zoomOffset, yOffset - size / 2, x * zoomOffset, yOffset + size / 2);
                }
                rysuj.DrawString((negativeX * zoomOffset) + "", font, brush, (x * zoomOffset) - (int)distance * zoomOffset - 4, yOffset - size - 12);
            }

            // rysowanie przedziałek dla dodatnich wartosci osi Y
            int negativeY = 0;
            for (int y = yOffset / zoomOffset; y < obraz.Height; y += (int)distance)
            {
                negativeY--;
                if (y != yOffset / zoomOffset)
                {
                    rysuj.DrawLine(pen, xOffset - size / 2, y * zoomOffset, xOffset + size / 2, y * zoomOffset);
                }
                rysuj.DrawString(negativeY * zoomOffset + "", font, brush, xOffset + size , y * zoomOffset + (int)distance * zoomOffset - 8);
            }

            // rysowanie przedziałek dla ujemnych wartosci osi Y
            int positiveY = 0;
            for (int y = yOffset / zoomOffset; y > 0; y -= (int)distance)
            {
                positiveY++;
                if (y != yOffset / zoomOffset)
                {
                    rysuj.DrawLine(pen, xOffset - size / 2, y * zoomOffset, xOffset + size / 2, y * zoomOffset);
                }
                rysuj.DrawString(positiveY * zoomOffset + "", font, brush, xOffset + size, y * zoomOffset - (int)distance * zoomOffset - 8);
            }
        }

        private void okno_Load(object sender, EventArgs e)
        {
            rysuj = obraz.CreateGraphics();
            center = new Point(obraz.Width / 2, obraz.Height / 2);
        }

        public double funkcjaSzescienna(double x) {
            // pobranie wartosci z interfejsu
            double wartoscA = (double) a.Value;
            double wartoscB = (double) b.Value;
            double wartoscC = (double) c.Value;
            double wartoscD = (double) d.Value;

            // uwzglendienie operatorow wybranych przez uzytkownika [+/-]
            // wzasadzie tylko interesuje nas czy zmieniamy wartosc na negatywną
            if (operator1.Text == "-")
            {
                wartoscA = -wartoscA;
            }
            if (operator2.Text == "-")
            {
                wartoscB = -wartoscB;
            }
            if (operator3.Text == "-")
            {
                wartoscC = -wartoscC;
            }
            if (operator4.Text == "-")
            {
                wartoscD = -wartoscD;
            }

            // wyliczanie wartosci funkcji
            return -(Math.Pow((x * wartoscA), 3) + Math.Pow((x * wartoscB), 2) + (x * wartoscC) + wartoscD);
        }

        public void rysowanie() {
            rysuj.Clear(Color.White);
            center = new Point(obraz.Width / 2, obraz.Height / 2);
            drawAxes((int)center.X, (int)center.Y, Color.Black);
            for (double x = -(double)(probki.Value / 2); x < (double)(probki.Value / 2); x += 1)
            {
                double punkt = funkcjaSzescienna(x);
                double kolejny = funkcjaSzescienna(x + 1);
                rysuj.DrawLine(Pens.Red, (float)x * size + center.X, (float)punkt * size + center.Y, (float)(x + 1) * size + center.X, (float)kolejny * size + center.Y);
            }
        }

        private void paint_Click(object sender, EventArgs e)
        {
            rysowanie();
        }

        private void obraz_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 100)
            { // zoom in
                size -= 0.1f;
                distance -= 0.2f;
                zoom++;
            }
            else if (e.Delta < -100)
            { // zoom out 
                size += 0.1f;
                distance += 0.2f;
                zoom--;
            }

            //zabespiezenie przed wyswietleniem nieskończonego przedziału
            if (size < 0.2f || distance < 0.4f)
            {
                size = 0.2f;
                distance = 0.4f;
            }

            rysowanie();
        }
    }
}
