using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium4
{
    public partial class okno : Form
    {
        /* -= UWAGA =-
         * Kod korzystający z spójności nie jest wystarczająco zoptymalizowany
         * niezbędne było powiękrzenie rozmiaru stosu więc w nowo skompilowanej aplikacji może nie działać 
         * w \bin\Debug znajduje się skompilowany plik "Laboratorium 4 Powiekrzony stos.exe"
         * Komendy do poszerzenia stasu:
         * EDITBIN.EXE /STACK:<nowy_rozmiar> "<nasz_plik>.exe"
         * plik editbin.exe powinien byc tu: C:\Program Files (x86)\Microsoft Visual Studio\2017\BuildTools\VC\Tools\MSVC\14.16.27023\bin\Hostx64\x64
         */

        Graphics rysuj;
        Bitmap przechwytywanie;
        Boolean czyFigura = false;
        Poligon figura = new Poligon(); //przygotowalem osobną klasę

        //przygotowanie niezbęnych składników
        //niezbędne przy Dispose()
        public void przygotuj()
        {
            przechwytywanie = new Bitmap(picture.Width, picture.Height);
            rysuj = Graphics.FromImage(przechwytywanie);
        }

        //renderowanie jest wykonywane na bitmapie a następnie bitmapa jest wykorzystywana
        public void wyswietl() { //przekazanie bitmapy do pictureboxa
            picture.Image = przechwytywanie;
        }

        public okno()
        {
            InitializeComponent();
        }

        private void okno_Load(object sender, EventArgs e)//dodatkowa inicjalizacja
        {
            figura.read();
            figura.calcs();
            przygotuj();
        }

        private void drawFigure_Click(object sender, EventArgs e) // wywłanie rysowania figury (generowanie i krawedzie)
        {
            czyFigura = true;

            figura.read();
            figura.calcs();

            przygotuj();

            rysuj.Clear(Color.White);

            figura.draw(rysuj);

            rysuj.Dispose();

            wyswietl();
        }

        private void clear_Click(object sender, EventArgs e) //czyszczenie
        {
            przygotuj();

            rysuj.Clear(Color.White);

            rysuj.Dispose();

            wyswietl();
        }

        private void drawSymbol_Click(object sender, EventArgs e) //rysowanie tekstu
        {
            czyFigura = false;

            przygotuj();

            rysuj.Clear(Color.White);

            if (symbol.Text == "")
                symbol.Text = "?";

            Font font = new Font("Arial", 192);
            SolidBrush solidBrush = new SolidBrush(System.Drawing.Color.Black);
            rysuj.DrawString(symbol.Text, font, solidBrush, 10, 10, new StringFormat());

            rysuj.Dispose();

            wyswietl();
        }

        private void fillOdd_Click(object sender, EventArgs e) //wywołanie wypelnienia aktualnej figury
        {

            if (czyFigura)
            {
                przygotuj();

                rysuj.Clear(Color.White);

                figura.display(rysuj);

                rysuj.Dispose();

                wyswietl();
            }
        }
        void functionFill4(int x, int y, Color newColor, Color oldColor) // funkcja wykorzystująca siatkę czterospójną
        {
            przechwytywanie.SetPixel(x, y, newColor);
            //sąsiednie
            if (x > 0 &&                            przechwytywanie.GetPixel(x - 1, y) == oldColor) { functionFill4(x - 1, y, newColor, oldColor); }
            if (x < przechwytywanie.Width - 1 &&    przechwytywanie.GetPixel(x + 1, y) == oldColor) { functionFill4(x + 1, y, newColor, oldColor); }
            if (y > 0 &&                            przechwytywanie.GetPixel(x, y - 1) == oldColor) { functionFill4(x, y - 1, newColor, oldColor); }
            if (y < przechwytywanie.Height - 1 &&   przechwytywanie.GetPixel(x, y + 1) == oldColor) { functionFill4(x, y + 1, newColor, oldColor); }
        }

        private void fill4_Click(object sender, EventArgs e)// wywołanie funkcji siatki czterospójnej
        {
            if (!czyFigura)
            {
                functionFill4((int)posx.Value, (int)posy.Value , Color.FromArgb(255, 0, 0), Color.FromArgb(0, 0, 0));
                wyswietl();
            }
        }

        void functionFill8(int x, int y, Color newColor, Color oldColor) // funkcja wykorzystująca siatkę ośmiospójną
        {
            przechwytywanie.SetPixel(x, y, newColor);
            //sąsiednie
            if (x > 0 &&                            przechwytywanie.GetPixel(x - 1, y) == oldColor) { functionFill8(x - 1, y, newColor, oldColor); }
            if (x < przechwytywanie.Width - 1 &&    przechwytywanie.GetPixel(x + 1, y) == oldColor) { functionFill8(x + 1, y, newColor, oldColor); }
            if (y > 0 &&                            przechwytywanie.GetPixel(x, y - 1) == oldColor) { functionFill8(x, y - 1, newColor, oldColor); }
            if (y < przechwytywanie.Height - 1 &&   przechwytywanie.GetPixel(x, y + 1) == oldColor) { functionFill8(x, y + 1, newColor, oldColor); }
            //po przekątnej
            if (x > 0 &&                            y < przechwytywanie.Height - 1 &&   przechwytywanie.GetPixel(x - 1, y + 1) == oldColor) { functionFill8(x - 1, y + 1, newColor, oldColor); }
            if (x < przechwytywanie.Width - 1 &&    y < przechwytywanie.Height - 1 &&   przechwytywanie.GetPixel(x + 1, y + 1) == oldColor) { functionFill8(x + 1, y + 1, newColor, oldColor); }
            if (x > 0 &&                            y > 0 &&                            przechwytywanie.GetPixel(x - 1, y - 1) == oldColor) { functionFill8(x - 1, y - 1, newColor, oldColor); }
            if (x < przechwytywanie.Width - 1 &&    y > 0 &&                            przechwytywanie.GetPixel(x + 1, y - 1) == oldColor) { functionFill8(x + 1, y - 1, newColor, oldColor); }
        }
        private void fill8_Click(object sender, EventArgs e)// wywołanie funkcji siatki ośmiospójnej
        {
            if (!czyFigura)
            {
                functionFill8((int)posx.Value, (int)posy.Value, Color.FromArgb(255, 0, 0), Color.FromArgb(0, 0, 0));
                wyswietl();
            }
        }
    }
}
