using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema6
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 6.");
            Console.WriteLine("Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");

        }

        public static void Rezolvare()
        {
            int n, x, ok=1,y;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine();

            if (n == 0)
                Console.WriteLine("Secventa nu contine niciun numar.");
            else if(n==1)
                Console.WriteLine("Secventa contine un singur numar. Nu ii putem determina monotonia decat daca sunt minim doua numere in secventa.");
            else
            {
                x = Helper.ReadInt("x");
                y = x;
                for (int i = 1; i < n; i++)
                {
                    x = Helper.ReadInt("x");
                    if (x < y)
                        ok = 0;
                    y = x;
                }
                if(ok==0)
                Console.WriteLine($"Secventa de numere nu este crescatoare.");
                else
                Console.WriteLine($"Secventa de numere este crescatoare.");
            }

           


        }
    }
}
