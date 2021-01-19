using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema8
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 8.");
            Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");

        }

        public static void Rezolvare()
        {
            int n, x, nr = 0,y,z;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine();
            if (n == 0)
                Console.WriteLine("Trebuie sa introduci un numar mai mare decat 0.");
            else if (n == 1)
                Console.WriteLine(0);
            else if (n == 2 || n == 3)
                Console.WriteLine(1);
            else
            {
                x = 1;
                y = 1;
                for (int i = 4; i <= n; i++)
                {
                    z = x + y;
                    x = y;
                    y = z;

                }
                Console.WriteLine(y);
            }
         
        }
    }
}
