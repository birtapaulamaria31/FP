using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema7
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 7.");
            Console.WriteLine("Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n,aux;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];
            v = Helper.ReadIntArray(n);

            for (int i = 0; i < n/2; i++)
            {
                aux = v[i];
                v[i] = v[n - i - 1];
                v[n - i - 1] = aux;
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
