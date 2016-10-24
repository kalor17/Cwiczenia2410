using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia2410
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba lukasz = new Osoba("Lukasz", "Zakrzewski", 1994);
            Osoba osoba1 = new Osoba();
            Student student = new Student("Krzysiu","Wi",1997,3,5,134444);
            student.WypiszInfo();
            osoba1.WypiszInfo();
            lukasz.WypiszInfo();
            Console.ReadKey();

        }
    }
}
