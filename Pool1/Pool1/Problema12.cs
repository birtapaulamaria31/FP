using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema12
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 12.");
            Console.WriteLine("Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int n = Helper.ReadInt("n");
            float a = Helper.ReadFloat("a");
            int aux;
            float b = Helper.ReadFloat("b");
            aux = (int)Math.Round(a);
            
            int nr = 0;
            for(int i=aux; i<=b; i++)
            {
                if (i % n == 0)
                    nr++;
            }
            Console.WriteLine($"In intervalul [{a}, {b}] sunt {nr} numere intregi divizibile cu {n}");
        }
    }
}
