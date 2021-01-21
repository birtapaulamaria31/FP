using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema10
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 10.");
            Console.WriteLine("Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1.");


        }

        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n, poz=-1,ok=0;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];
            v = Helper.ReadIntArray(n);
            int k = Helper.ReadInt("k");
            int i = 0, j = n-1,m;
            while(i<=j)
            {
                m = (i + j) / 2;
                if (v[m] == k)
                {
                    ok = 1;
                    poz = m;
                    break;

                }
                else if (k < v[m])
                    j = m - 1;
                else 
                    i = m + 1;

            }
           if(ok==0)
                Console.Write(-1);
           else
                Console.Write(poz);
        }
    }
}
