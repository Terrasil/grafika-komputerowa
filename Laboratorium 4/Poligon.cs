using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_4
{
    class Poligon
    {
        Point[] p = new Point[6];
        int[] inter = new int[10];
        int x, v = 5, c; //zapasowe posX , ilość wierzchołków,
        float d = 0.1f; //dokładność
        int xmin, ymin, xmax, ymax; //ekstrema
        Random rng = new Random();
        public void read() // wczytywanie wygenerowanych wierzchołków do tablicy
        {
            int i;
            if (v > 2)
            {
                for (i = 0; i < v; i++)
                {
                    p[i] = new Point(rng.Next(1, 800), rng.Next(1, 360));
                }
                p[i].X = p[0].X;
                p[i].Y = p[0].Y;
                xmin = xmax = p[0].X;
                ymin = ymax = p[0].Y;
            }
        }
        public void calcs() // obliczanie ekstremum max i min
        {
            for (int i = 0; i < v; i++)
            {
                if (xmin > p[i].X)
                    xmin = p[i].X;
                if (xmax < p[i].X)
                    xmax = p[i].X;
                if (ymin > p[i].Y)
                    ymin = p[i].Y;
                if (ymax < p[i].Y)
                    ymax = p[i].Y;
            }
        }
        public void display(Graphics g) // wyświetlanie zapelnienia
        {
            float s;
            s = ymin + d;
            while (s <= ymax)
            {
                ints(s);
                sort(g, (int)s);
                s++;
            } 
        }

        public void ints(float z) //określanie parzystości
        {
            int x1, x2, y1, y2, temp;
            c = 0;
            for (int i = 0; i < v; i++)
            {
                x1 = p[i].X;
                y1 = p[i].Y;
                x2 = p[i + 1].X;
                y2 = p[i + 1].Y;
                if (y2 < y1)
                {
                    temp = x1;
                    x1 = x2;
                    x2 = temp;
                    temp = y1;
                    y1 = y2;
                    y2 = temp;
                }
                if (z <= y2 && z >= y1)
                {
                    if ((y1 - y2) == 0)
                    {
                        x = x1;
                    }
                    else
                    {
                        x = (int)((x2 - x1) * (z - y1)) / (y2 - y1);
                        x = x + x1;
                    }

                    if (x <= xmax && x >= xmin)
                    {
                        inter[c++] = x;
                    }
                }
            }
        }
        public void draw(Graphics g) //rysowanie krawedzi figury
        {
            int i;
            Pen krawedzie = new Pen(Color.Black);
            for (i = 0; i < v; i++)
            {
                g.DrawLine(krawedzie, p[i].X, p[i].Y, p[i + 1].X, p[i + 1].Y);
            }
        }
        public void sort(Graphics g, int z) //rysoawnie wypełnienia figury
        {
            int i;
            Pen wypelnienie = new Pen(Color.Blue);
            for (i = 0; i < c; i += 2)
            {
                g.DrawLine(wypelnienie, inter[i], z, inter[i + 1], z);
            }
        }
    }
}
