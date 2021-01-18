using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema16
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 16.");
            Console.WriteLine("Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri) ");

        }

        public static void Swap(ref float x, ref float y)
        {
            float aux;
            aux = x;
            x = y;
            y = aux;

        }


        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            float a = Helper.ReadFloat("a");
            float b = Helper.ReadFloat("b");
            float c = Helper.ReadFloat("c");
            float d = Helper.ReadFloat("d");
            float e = Helper.ReadFloat("e");

            if (a > b)
                Swap(ref a, ref b);
            if (a > c)
                Swap(ref a, ref c);
            if (a > d)
                Swap(ref a, ref d);
            if (a > e)
                Swap(ref a, ref e);

            if (b > c)
                Swap(ref b, ref c);
            if (b > d)
                Swap(ref b, ref d);
            if (b > e)
                Swap(ref b, ref e);

            if (c > d)
                Swap(ref c, ref d);
            if (c > e)
                Swap(ref c, ref e);

            if (d > e)
                Swap(ref d, ref e);




            Console.Write($"Numerele introduse asezate in ordine crescatoare sunt: {a}, {b}, {c}, {d}, {e}.");


        }
    }
}
