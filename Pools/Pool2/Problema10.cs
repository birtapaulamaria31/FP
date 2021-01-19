using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema10
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 10");
            Console.WriteLine("Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. ");

        }

        public static void Rezolvare()
        {
            int n, x, nr = 1, y, nrmax =0;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine();
            if (n == 1)
                Console.WriteLine(1);
            else
            {
                x = Helper.ReadPositiveInt("x");
                y = x;
                for (int i = 1; i < n; i++)
                {
                    x = Helper.ReadPositiveInt("x");
                    if (y == x)
                        nr++;
                    else
                    {
                       if (nr > nrmax)
                            nrmax = nr;
                        nr = 1;
                    }

                    
                    y = x;

                }
                if (nr > nrmax)
                    nrmax = nr;
                Console.WriteLine("Numarul maxim de numere consecutive egale din secventa este " + nrmax);

            }

        }
    }
}
