using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium5
{
    public partial class window : Form
    {
        Graphics rysuj;
        float speed = 0;
        float distance = 0;
        PointF screenCenter;

        //SZABLONY FIGUR
        PointF[] kwadrat = {
            new PointF(-50,-50),
            new PointF(50,-50),
            new PointF(50,50),
            new PointF(-50,50)
        };
        PointF[] trojkat = {
            new PointF(0,-50),
            new PointF(50,50),
            new PointF(-50,50)
        };
        PointF[] A, B, C, D, E;

        void rysujFigure(Graphics g, PointF[] punkty, Color kolor)
        {
            int tempID = 0;
            Pen pen = new Pen(kolor);
            foreach (PointF punkt in punkty)
            {
                tempID++;
                if (tempID >= punkty.Length)
                {
                    tempID = 0;
                }
                g.DrawLine(pen, punkt, punkty[tempID]);
            }
        }

        PointF[] przygotujFigure(float x, float y, PointF[] punkty) 
        {
            PointF[] tempFigura = new PointF[punkty.Length];
            int tempID = 0;
            foreach (PointF punkt in punkty)
            {
                tempFigura[tempID].X = punkty[tempID].X + x;
                tempFigura[tempID].Y = punkty[tempID].Y + y;
                tempID++;
            }
            return tempFigura;
        }
        PointF[] przygotujFigure(PointF p, PointF[] punkty)
        {
            PointF[] tempFigura = new PointF[punkty.Length];
            int tempID = 0;
            foreach (PointF punkt in punkty)
            {
                tempFigura[tempID].X = punkty[tempID].X + p.X;
                tempFigura[tempID].Y = punkty[tempID].Y + p.Y;
                tempID++;
            }
            return tempFigura;
        }

        void przesunFigure(PointF[] figura, float rotate, float moveX, float moveY)
        {
            Matrix matrix = new Matrix();
            matrix.RotateAt(rotate, screenCenter);
            matrix.Translate(moveX, moveY);
            matrix.TransformPoints(figura);
        }

        public window()
        {
            InitializeComponent();
        }

        private void window_Load(object sender, EventArgs e)
        {
            screenCenter = new Point(screen.Width / 2, screen.Height / 2); 
            rysuj = screen.CreateGraphics();

            A = przygotujFigure(screenCenter, kwadrat);
            B = przygotujFigure(screenCenter.X - 100, screenCenter.Y - 100, trojkat);
            C = przygotujFigure(screenCenter.X + 100, screenCenter.Y - 100, trojkat);
            D = przygotujFigure(screenCenter.X - 100, screenCenter.Y + 100, trojkat);
            E = przygotujFigure(screenCenter.X + 100, screenCenter.Y + 100, trojkat);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            rysuj.Clear(Color.White);
            przesunFigure(A, speed, 0, 0);
            przesunFigure(B, -speed, -distance, -distance);
            przesunFigure(C, -speed, distance, -distance);
            przesunFigure(D, -speed, -distance, distance);
            przesunFigure(E, -speed, distance, distance);

            rysujFigure(rysuj, A, Color.Blue);
            rysujFigure(rysuj, B, Color.Red);
            rysujFigure(rysuj, C, Color.Lime);
            rysujFigure(rysuj, D, Color.Orange);
            rysujFigure(rysuj, E, Color.Magenta);

            //rysuj.DrawLine(new Pen(Color.Brown),new PointF(screenCenter.X, 0), new PointF(screenCenter.X, screen.Height));
            //rysuj.DrawLine(new Pen(Color.Brown), new PointF(0, screenCenter.Y), new PointF(screen.Width, screenCenter.Y));
        }

        private void speedTrack_Scroll(object sender, ScrollEventArgs e)
        {
            speed = (float)((speedTrack.Value - 500)/100f);
        }

        private void distanceTrack_Scroll(object sender, ScrollEventArgs e)
        {
            distance = (float)((distanceTrack.Value - 500)/100f);
        }
    }
}
