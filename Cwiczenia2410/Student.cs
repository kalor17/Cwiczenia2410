using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia2410
{
    class Student : Osoba
    {
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        public Student(string imie, string nazwisko, int rokUr, int rok, int numerGrupy, int numerAlbumu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUr = rokUr;
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imie i nazwisko: {0} {1}", imie, nazwisko);
            Console.WriteLine(rokUr);
            Console.WriteLine(rok + "  " + numerGrupy + "  " + numerAlbumu);
        }
    }
}
