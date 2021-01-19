using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema4
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 4.");
            Console.WriteLine("Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.");

        }

        public static void Rezolvare()
        {
            int n, x,a,poz=-1;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            a = Helper.ReadInt("numarCautat");
            Console.WriteLine();

            for (int i = 0; i <n; i++)
            {
                x = Helper.ReadInt("x");
                if (x == a)
                    poz = i;

            }
            if(poz!=-1)
            Console.WriteLine($"Numarul {a} se afla in secventa pe pozitia {poz}");
            else
            Console.WriteLine( poz);

        }
    }
}
