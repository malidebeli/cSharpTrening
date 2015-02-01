using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpTrening
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatrogasac v1 = new Vatrogasac { Ime = "Josip" };
            Vatrogasac v2 = new Vatrogasac {Ime = "Mirko"};

            VatrogasnoVozilo vzv1 = new VatrogasnoVozilo { vozac = v1 };
            VatrogasnoVozilo vzv2 = new VatrogasnoVozilo {vozac = new Vatrogasac{Ime="Ana"}};

            Tocka t = new Tocka ();
            t.OsX = 100;
            t.OsY = 200;



            v2.Voziti(vzv1, t);
            v1.Voziti(vzv1, t);


            Console.ReadLine();
        }
    }
}
