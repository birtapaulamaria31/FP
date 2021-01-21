using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema18
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 8.");
            Console.WriteLine(".Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n, aux;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];
            v = Helper.ReadIntArray(n);
            aux = v[0];
            for (int i = 0; i < n - 1; i++)
            {
                v[i] = v[i + 1];

            }
            v[n - 1] = aux;
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
