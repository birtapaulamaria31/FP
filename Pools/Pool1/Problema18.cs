using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema18
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 18.");
            Console.WriteLine("Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. ");

        }

       public static void FactoriPrimi(int n)
        {
            int d=2,p = 0;
            while(n!=1)
            {
                p = 0;
                while(n%d==0)
                {
                    n = n / d;
                    p++;
                }
                if (p != 0)
                {
                    if(n==1)
                    Console.Write($"{d}^{p}.");
                    else
                    Console.Write($"{d}^{p} x ");
                }
                    
                d++;
            }

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int n = Helper.ReadPositiveInt("n");
            if(Helper.ok != 0)
              FactoriPrimi(n);
            

        }
    }
}
