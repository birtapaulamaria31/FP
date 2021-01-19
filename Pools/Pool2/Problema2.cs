using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema2
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 2.");
            Console.WriteLine("Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.");

        }

        public static void Rezolvare()
        {
            int n, x, neg = 0,poz=0,zero=0;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
          
                for (int i = 1; i <= n; i++)
                {
                    x = Helper.ReadInt("x");
                    if (x == 0)
                        zero++;
                    else if (x > 0)
                        poz++;
                    else if (x < 0)
                        neg++;
                }
                Console.WriteLine($"In secventa de numere introduse sunt {poz} numere pozitive, {neg} numere negative si {zero} zerouri.");
         
        }
    }
}
