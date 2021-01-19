using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema13
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 13");
            Console.WriteLine("O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita.");

        }

        public static void Rezolvare()
        {
            int n, x,  y, first, nrSecvDesc = 0, last = 1000000;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine();
            if (n > 0)
            {

                x = Helper.ReadInt("x");
                y = x;
                first = x;
                for (int i = 1; i < n; i++)
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
                if (first >= last && nrSecvDesc < 2)
                    Console.WriteLine("Secventa de numere este crescatoare rotita");
                else
                    Console.WriteLine("Secventa de numere NU E crescatoare rotita");

            }
            else Console.WriteLine("Secventa ta nu are niciun numar");

        }
    }
}
