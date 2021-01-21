using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema16
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 16.");
            Console.WriteLine("Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
        }
        public static int Cmmdc(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n,cmmdc;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];
            v = Helper.ReadIntArray(n);
            cmmdc = v[0];
            for (int i = 1; i < n ; i++)
            {
                cmmdc = Cmmdc(v[i], cmmdc);

            }
            
                Console.Write($"{cmmdc} este cmmdc-ul pentru cele {n} numere");
        }
    }
}
