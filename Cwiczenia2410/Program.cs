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
            lukasz.WypiszInfo();
            Console.ReadKey();
        }
    }
}
