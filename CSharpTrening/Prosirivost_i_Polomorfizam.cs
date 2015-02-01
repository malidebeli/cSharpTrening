using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrening
{
    class Prosirivost_i_Polomorfizam
    {
    }

    class Vatrogasac
    {
        public string Ime { get; set; }

        public void GasitiVatru()
        {
            Console.WriteLine("{0} gasi vatru", Ime);
        }

        public void Voziti(VatrogasnoVozilo vozilo, Tocka koordinate)
        {
            if (vozilo.vozac != this)
            {
                Console.WriteLine("Gospon niste vozači nemrerete voziti vatrogasnog avtobusa :D!");
                return;
            }
            
            vozilo.Voziti(koordinate);
        }    
    
    }


    class VatrogasnoVozilo
    {
        public Vatrogasac vozac {get; set;}
        public void Voziti(Tocka koordinate)
        {   
            if (vozac == null)
	            {
                    Console.WriteLine("Gospon niste vozači nemrerete voziti vatrogasnog avtobusa :D!");
		            return;
	            }
            Console.WriteLine("Vozimo prema {0}, {1} točci", koordinate.OsX,koordinate.OsY);
        }
    }

    class Tocka
	{
        public int OsX{get;set;}
        public int OsY{get;set;}
		
	}


}
