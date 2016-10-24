using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia2410
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int rokUr;
        private string miejsceZamieszkania;

        // konstruktor domyslny
        public Osoba()
        {
            imie = "Jan";
            nazwisko = "Kowalski";
            rokUr = 1996;
        }

        protected internal Osoba(string imie, string nazwisko, int rokUr)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUr = rokUr;
        }

        protected internal void WypiszInfo()
        {
            Console.WriteLine("Imie i nazwisko: {0} {1}",imie, nazwisko);
            Console.WriteLine(rokUr);
        }

        protected internal void ObliczWiek()
        {
            Console.WriteLine("Wiek: {0}", DateTime.Now.Year - rokUr);
        }
        
        //metoda ustawiajaca miejsce zamieszkania
        protected internal void UstawMiejsceZamieszkania(string miejsceZamieszkania)
        {
            this.miejsceZamieszkania=miejsceZamieszkania;
        }
        
    }
}
