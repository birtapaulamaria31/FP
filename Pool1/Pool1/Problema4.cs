using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema4
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 4.");
            Console.WriteLine("Detreminati daca un an y este an bisect.  ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int y = Helper.ReadPositiveInt("y");
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                Console.WriteLine($"{y} este an bisect.");
            else
                Console.WriteLine($"{y} NU este an bisect.");


        }
    }
}
