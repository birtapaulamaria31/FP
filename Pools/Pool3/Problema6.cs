using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema6
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 6.");
            Console.WriteLine("Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n,k;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];

            v = Helper.ReadIntArray(n);
            k = Helper.ReadPositiveInt("k");
            for (int i = 0; i < n-1; i++)
            {
                if (i >= k)
                    v[i] = v[i + 1];
                
            }
            for (int i = 0; i < n - 1; i++)
                Console.Write($"{v[i]} ");
            
        }
    }
}
