using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema12
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 12");
            Console.WriteLine("Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.");

        }

        public static void Rezolvare()
        {
            int n, x, nr = 0, y;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine();
            if(n>0)
            { 
                x=Helper.ReadInt("x1");

            y = x;
            for (int i =2; i <=n; i++)
            {
                x = Helper.ReadInt($"x{i}");
                if (x ==0)
                {
                    if(y!=0)
                        nr++;
                }
                y = x;
                   

            }
            if (y != 0)
                nr++;
            }
            Console.WriteLine($"Numarul de astfel de cuvinte este {nr}.");


        }
    }
}
