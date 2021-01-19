using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema1
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 1.");
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");

        }

        public static void Rezolvare()
        {
            int n,x,nr=0;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
           
           for (int i = 1; i <= n; i++)
                {
                    x = Helper.ReadInt("x");
                    if (x % 2 == 0)
                        nr++;

                }
                Console.WriteLine($"Numarul de numere pare din secventa de numere citite este: {nr}");
           
        }

    }
}
