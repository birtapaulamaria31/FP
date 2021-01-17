using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema5
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 5.");
            Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int n = Helper.ReadPositiveInt("n");
            int k = Helper.ReadPositiveInt("k");
            int nrCifra = 1,m;
            m = n;
            while(n!=0)
            {
                if (nrCifra == k)
                {
                    Console.WriteLine($"A {k}-a cifra de la dreapta spre stanga a numarului {m} este {n % 10}.");
                    break;
                }
                else
                {
                    nrCifra++;
                    n = n / 10;
                }
            }


        }
    }
}
