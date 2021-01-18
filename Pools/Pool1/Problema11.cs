using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema11
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 11.");
            Console.WriteLine("Afisati in ordine inversa cifrele unui numar n. ");

        }



        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int n = Helper.ReadPositiveInt("n");
            int nrZerouri=0;
            while(n%10==0)
            {
                nrZerouri++; ;
                n = n / 10;
            }
            int og=0;
            og = Helper.Oglindit(n);
            Console.Write($"Cifrele lui {n} scrise in ordine inversa sunt ");
            if (nrZerouri != 0)
                for (int i = 1; i <= nrZerouri; i++)
                    Console.Write("0");
            Console.Write($"{og}.");


        }
    }
}
