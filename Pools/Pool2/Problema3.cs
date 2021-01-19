using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema3
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 3.");
            Console.WriteLine("Calculati suma si produsul numerelor de la 1 la n.");

        }

        public static void Rezolvare()
        {
            int n, x,s=0,p=1;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");

            for (int i = 1; i <= n; i++)
            {
                
                s = s + i;
                p = p * i;
            }
            Console.WriteLine($"Numerele de la 1 la {n} au suma {s} si produsul {p}.");

        }
    }
}
