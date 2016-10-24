using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia2410
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rok;

        public Osoba(string imie, string nazwisko, int rok)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rok = rok;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(imie);
            Console.WriteLine(nazwisko);
            Console.WriteLine(rok);
        }
    }
}
