using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema11
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 11.");
            Console.WriteLine("Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).");
        }

        public static bool Prim(int n)
        {
            int d;
            bool prim = true;
            if (n == 2)
                prim = true;
            else if (n < 2 || (n % 2 == 0 && n != 2))
                prim = false;
            else
            {
                for (d = 3; d * d <= n; d = d + 2)
                {
                    if (n % d == 0)
                    {
                        prim = false;
                    }

                }
            }
            return prim;
        }

        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n, aux;
            n = Helper.ReadPositiveInt("n");
            
            for (int i = 2; i <= n; i++)
            {
                if (Prim(i))
                    Console.Write(i + " ");

            }

        }
    }
}
