using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema14
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 14");
            Console.WriteLine("O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita.");

        }

        public static void Rezolvare()
        {
            int n, x, y, first, nrSecvDesc = 0, last = 1000000, nrSecvCresc = 0;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine();
            if (n > 1)
            {
                ///verificam monotonia dintre primele doua elemente 
                x = Helper.ReadInt("x");
                y = x;
                first = x;
                x = Helper.ReadInt("x");
                if(x<y)
                {
                    y = x;
                   
                    for (int i = 2; i < n; i++)
                    {
                        x = Helper.ReadInt("x");
                        if (x < y)
                        {
                            nrSecvDesc++;
                        }
                        if (i == n - 1)
                            last = x;
                        y = x;

                    }
                }
                else if(y>x)
                {
                    y = x;
                
                    for (int i = 2; i < n; i++)
                    {
                        x = Helper.ReadInt("x");
                        if (x > y)
                        {
                            nrSecvCresc++;
                        }
                        if (i == n - 1)
                            last = x;
                        y = x;

                    }
                }
                
                if (first >= last && nrSecvDesc < 2)
                    Console.WriteLine("Secventa de numere este crescatoare rotita");
                else if (first <= last && nrSecvCresc< 2)
                    Console.WriteLine("Secventa de numere NU E crescatoare rotita");

            }
            else Console.WriteLine("Secventa ta nu are niciun numar");

        }
    }
}
