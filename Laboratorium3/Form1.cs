using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium3
{
    public partial class okno : Form
    {
        Boolean drawLine = true;
        Graphics rysuj;
        Stopwatch zegarek;

        void DrawPixel(int x, int y, Color kolor) {
            rysuj.DrawRectangle(new Pen(kolor), x, y, 1, 1); //rysuje linie na 1 pixel
        }

        void rysowanieLiniiPrzyrost(int x0, int y0, int x1, int y1, Color kolor)
        {
            int x;
            float dx, dy, y, m;
            dx = x1 - x0;
            dy = y1 - y0;
            m = dy / dx;
            y = y0;
            for (x = x0; x <= x1; x++)
            {
                // DrawPixel(x, (int)y, color); <- zaokrąglenie nie zmienia wyglądu odcinka
                DrawPixel(x, (int)Math.Floor(y + 0.5), kolor);
                y += m;
            }
        }
        void rysowanieLiniiBresenhama(int x0, int y0, int x1, int y1, Color kolor)
        {
           int dx, dy, incrementE, incrementNE, d, x, y;
           dx = x1 - x0;
           dy = y1 - y0;
           d = 2 * (dy - dx);
           incrementE = dy * 2;
           incrementNE = (dy - dx) * 2;
           x = x0;
           y = y0;
           DrawPixel(x, y, kolor);
           while (x < x1) {
               if (d <= 0) {
                   d += incrementE;
                   x++;
               }
               else {
                   d += incrementNE;
                   x++;
                   y++;
               }
               DrawPixel(x, y, kolor);
           }
           /* 
           * int x, y;
           * float tx = x1 - x0;
           * float ty = y1 - y0;
           * float odl = Math.Abs(tx) + Math.Abs(ty);
           * 
           * float dx = tx / odl;
           * float dy = ty / odl;
           *
           * for (int i = 0; i <= Math.Ceiling(odl); i++)
           * {
           *     x = (int)Math.Floor(x0 + dx * i);
           *     y = (int)Math.Floor(y0 + dy * i);
           *     DrawPixel(x, y, kolor);
           * }
           */
        }

        void rysowanieOkreguPrzyrost(int x, int y, int r, Color kolor)
        {

            int tx = r, ty = 0;
            int d = 1 - r;
            while (tx > ty)
            {

                ty++;
                if (d <= 0)
                {
                    d = d + 2 * ty + 1;
                }
                else
                {
                    tx--;
                    d = d + 2 * ty - 2 * tx + 1;
                }
                if (tx < ty)
                    break;

                rysowanieOktagonu(x, y, tx, ty, kolor);
                if (tx != ty)
                {
                    rysowanieOktagonu(x, y, tx, ty, kolor);
                }
            }
        }

        void rysowanieOktagonu(int xc, int yc, int x, int y, Color kolor) 
        {   //rysowanie 8 punktów - korzystanie z symetri okręgu
            DrawPixel(xc + x, yc + y, kolor);
            DrawPixel(xc - x, yc + y, kolor);
            DrawPixel(xc + x, yc - y, kolor);
            DrawPixel(xc - x, yc - y, kolor);
            DrawPixel(xc + y, yc + x, kolor);
            DrawPixel(xc - y, yc + x, kolor);
            DrawPixel(xc + y, yc - x, kolor);
            DrawPixel(xc - y, yc - x, kolor);
        }

        void rysowanieOkreguBresenhama(int xc, int yc, int r, Color kolor)
        {
            int x = 0;
            int y = r;
            int d = 3 - 2 * r;
            rysowanieOktagonu(xc, yc, x, y, kolor);
            while (y >= x)
            {
                x++;
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                {
                    d = d + 4 * x + 6;
                }
                rysowanieOktagonu(xc, yc, x, y, kolor);
            }
        }

        public okno()
        {
            InitializeComponent();
        }

        private void okno_Load(object sender, EventArgs e)
        {
            rysuj = paint.CreateGraphics();
            panel2.Location = new Point(-1000, -1000);
            rysuj.Clear(Color.White);
        }

        private void odcinek_CheckedChanged(object sender, EventArgs e)
        {
            rysuj.Clear(Color.White);
            panel1.Location = new Point(12, 386);
            panel2.Location = new Point(-1000, -1000);
            drawLine = true;
        }

        private void okrag_CheckedChanged(object sender, EventArgs e)
        {
            rysuj.Clear(Color.White);
            panel2.Location = new Point(12, 386);
            panel1.Location = new Point(-1000, -1000);
            drawLine = false;
        }

        private void przyrostowy_Click(object sender, EventArgs e)
        {
            rysuj.Clear(Color.White);
            zegarek = new System.Diagnostics.Stopwatch();
            if (drawLine)
            {
                zegarek.Start();
                rysowanieLiniiPrzyrost((int)xp.Value, (int)yp.Value, (int)xk.Value, (int)yk.Value, Color.Red);
                zegarek.Stop();
                czas.Text = "Czas: " + zegarek.ElapsedMilliseconds;
            }
            else
            {
                zegarek.Start();
                rysowanieOkreguPrzyrost((int)xo.Value, (int)yo.Value, (int)r.Value, Color.Red);
                zegarek.Stop();
                czas.Text = "Czas: " + zegarek.ElapsedMilliseconds;
            }
        }

        private void bresenhmana_Click(object sender, EventArgs e)
        {
            rysuj.Clear(Color.White);
            zegarek = new System.Diagnostics.Stopwatch();
            if (drawLine)
            {
                zegarek.Start();
                rysowanieLiniiBresenhama((int)xp.Value, (int)yp.Value, (int)xk.Value, (int)yk.Value, Color.Blue);
                zegarek.Stop();
                czas.Text = "Czas: " + zegarek.ElapsedMilliseconds;
            }
            else
            {
                zegarek.Start();
                rysowanieOkreguBresenhama((int)xo.Value, (int)yo.Value, (int)r.Value, Color.Blue);
                zegarek.Stop();
                czas.Text = "Czas: " + zegarek.ElapsedMilliseconds;
            }
        }

        private void standardowe_Click(object sender, EventArgs e)
        {
            rysuj.Clear(Color.White);
            zegarek = new System.Diagnostics.Stopwatch();
            if (drawLine)
            {
                zegarek.Start();
                rysuj.DrawLine(new Pen(Color.Black), (int)xp.Value, (int)yp.Value, (int)xk.Value, (int)yk.Value);
                zegarek.Stop();
                czas.Text = "Czas: " + zegarek.ElapsedMilliseconds;
            }
            else
            {
                zegarek.Start();
                rysuj.DrawEllipse(new Pen(Color.Black), (int)xo.Value - (int)r.Value, (int)yo.Value - (int)r.Value, (int)xo.Value, (int)yo.Value);
                zegarek.Stop();
                czas.Text = "Czas: " + zegarek.ElapsedMilliseconds;
            }
        }
    }
}
