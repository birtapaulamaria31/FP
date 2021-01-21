using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema5
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 5.");
            Console.WriteLine("Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n, s = 0, e,k,aux,ok=0;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v;
            v=new int[n+3];
            for (int i = 0; i < n; i++)
            {
                v[i] = Helper.ReadInt($"v[{i}]");
            }
            e = Helper.ReadPositiveInt("e");
            k = Helper.ReadInt("k");
            for (int i = n; i > k; i--)
            {
               v[i] = v[i-1];
                
                
            }
            v[k] = e;
            for(int i=0; i<=n; i++)
                Console.Write($"{v[i]} ");

        }
    }
}
