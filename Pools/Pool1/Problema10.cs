using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema10
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 10.");
            Console.WriteLine("Test de primalitate: determinati daca un numar n este prim. ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int n = Helper.ReadPositiveInt("n");
            int d;
            bool prim = true;
            if (n == 2)
                prim = true;
            else if (n < 2 || (n % 2 == 0 && n != 2))
                prim = false;
            else
            {
                for (d = 3; d * d <= n; d=d+2)
                {
                    if (n % d == 0)
                    {
                        prim = false;
                    }

                }
            }
            if (prim)
                Console.WriteLine($"Numarul {n} este numar prim.");
            else
                Console.WriteLine($"Numarul {n} NU este numar prim.");


        }
    }
}
