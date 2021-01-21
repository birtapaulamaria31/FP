using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema2
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 2.");
            Console.WriteLine("Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n, s = 0, poz = -1;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];

            v = Helper.ReadIntArray(n);
            int k = Helper.ReadInt("k");
            for (int i = 0; i < n; i++)
            {
                if(v[i]==k)
                { poz = i;
                    break;
                }
            }
            if (poz == -1)
                Console.WriteLine(-1);
            else
            Console.WriteLine($"Numarul {k} apare prima data in vector pe pozitia {poz}");

        }
    }
}
