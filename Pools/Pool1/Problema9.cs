using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema9
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 9.");
            Console.WriteLine("Afisati toti divizorii numarului n.  ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int n = Helper.ReadPositiveInt("n");
            int d;
            for(d=1; d*d<=n; d++)
            {
                if (n % d == 0 && d*d!=n)
                    Console.Write($"{d} {n/d} ");
                else if(n%d==0 && d*d==n)
                    Console.Write($"{d} ");

            }


        }
    }
}
