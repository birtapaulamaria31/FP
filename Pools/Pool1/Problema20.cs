using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema20
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 20.");
            Console.WriteLine("Afisati fractia m/ n in format zecimal, cu perioada intre paranteze(daca e cazul).Exemplu: 13 / 30 = 0.4(3).");
            Console.WriteLine("     O fractie este neperiodica daca numitorul este de forma 2 ^ m * 5 ^ n unde m si n sunt mai mari sau egale decat 0.");
            Console.WriteLine("     O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5.");
            Console.WriteLine("     O fractie este periodica mixta daca se divide cu 2 si / sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5.");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();

            int m = Helper.ReadPositiveInt("m");
            int n = Helper.ReadPositiveInt("n");
            Console.WriteLine((float)m / (float)n);
        }
        }
}
