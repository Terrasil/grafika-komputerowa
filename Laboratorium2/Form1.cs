using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium2
{
    public partial class Form1 : Form
    {
        Bitmap obraz;

        public Form1()
        {
            InitializeComponent();
        }

        private void zaladujPlik_FileOk(object sender, CancelEventArgs e)
        {
            string nazwaPliku;
            nazwaPliku = zaladujPlik.FileName;
            obraz = new Bitmap(nazwaPliku);
            podglad.Image = obraz;
            wynik.Image = obraz;
        }

        private void wybierz_Click(object sender, EventArgs e)
        {
            if (zaladujPlik.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(zaladujPlik.FileName);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Wystąpił błąd!\n\nError: {ex.Message}\n\n" +
                    $"Szczegłóy:\n\n{ex.StackTrace}");
                }
            }
        }

        private void cmy_Click(object sender, EventArgs e)
        {
            //konwersja na CMYK
            Bitmap pomoc = new Bitmap(obraz.Width, obraz.Height);
            Color punkt;
            for (int i = 0; i < obraz.Width; i++)
                for (int j = 0; j < obraz.Height; j++)
                {
                    punkt = obraz.GetPixel(i, j);
                    pomoc.SetPixel(i, j, Color.FromArgb(255 - punkt.R, 255 - punkt.G, 255 - punkt.B));
                }

            wynik.Image = pomoc;
        }

        private void rgb_Click(object sender, EventArgs e)
        {
            // przywracanie
            wynik.Image = obraz;
        }

        private void szary1_Click(object sender, EventArgs e)
        {
            /* Zmiana koloru metoda pierwsza:
             * Pobierane są wartości poszczególnych pikseli a następnie zgodnie ze wzorem odpowiednio modyfikowane
             * w = 0.3 * r + 0.59 * g + 0.11 * b; <- wartości subpikseli są mnożone przez ułamki co skutkuje ustaienie wartości procentowej względem surowego piksela
             * tzn. 0.3 * r to inaczej 30% waroś R z danego piksela
             * zmodyfikowałem kod aby ręcznie ustalać wartość jakie są podawane do wzoru
             */

            Bitmap pomoc = new Bitmap(obraz.Width, obraz.Height);
            Color punkt;
            for (int i = 0; i < obraz.Width; i++)
                for (int j = 0; j < obraz.Height; j++)
                {
                    punkt = obraz.GetPixel(i, j);
                    //w = 0.3 * r + 0.59 * g + 0.11 * b;
                    //pomoc.SetPixel(i, j, Color.FromArgb((int)(punkt.R*0.3), (int)(punkt.G * 0.59), (int)(punkt.B * 0.11)));
                    pomoc.SetPixel(i, j, Color.FromArgb((int)(punkt.R * (czerwony.Value / 100)), (int)(punkt.G * (zielony.Value / 100)), (int)(punkt.B * (niebieski.Value / 100))));
                }

            wynik.Image = pomoc;
        }

        private void szary2_Click(object sender, EventArgs e)
        {
            /* Zmiana koloru metoda druga:
             * Wyliczany jest średnia wartość wszystkich składowych piksela z wzoru w = (r + g + b) / 3;
             * następnie uśredniona wartośc jest ustawiana jako wartości poszczególnych subpikseli
             * efektem jest to że zamieniamy kolor danego piksela na poziom jasności w skali szarości
             */

            Bitmap pomoc = new Bitmap(obraz.Width, obraz.Height);
            Color punkt;
            for (int i = 0; i < obraz.Width; i++)
                for (int j = 0; j < obraz.Height; j++)
                {
                    punkt = obraz.GetPixel(i, j);
                    //w = (r + g + b) / 3;
                    int szary = (punkt.R + punkt.G + punkt.B) / 3;
                    pomoc.SetPixel(i, j, Color.FromArgb(szary, szary, szary));
                }

            wynik.Image = pomoc;
        }
    }
}
