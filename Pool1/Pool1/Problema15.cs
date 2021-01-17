using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema15
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 15.");
            Console.WriteLine("Se dau 3 numere. Sa se afiseze in ordine crescatoare. ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            float a = Helper.ReadFloat("a");
            float b = Helper.ReadFloat("b");
            float c = Helper.ReadFloat("c");
            float min, mij, max;
            mij = 0.0f;
            if (a <= b && a <= c)
                min = a;
            else if (b <= a && b <= c)
                min = b;
            else min = c;

            if (a >= b && a >= c)
                max = a;
            else if (b >= a && b >= c)
                max = b;
            else max = c;
            if(min==a)
            {
                if (max == b)
                    mij = c;
                if (max == c)
                    mij = b;
            }
            if(min==b)
            {
                if (max == a)
                    mij = c;
                if (max == c)
                    mij = a;
            }
            if (min == c)
            {
                if (max == a)
                    mij = b;
                if (max == b)
                    mij = c;
            }

            Console.WriteLine($"Numerele in ordine crescatoare sunt {min}, {mij}, {max}.");



        }
    }
}
