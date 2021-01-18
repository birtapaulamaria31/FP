using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema8
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 8.");
            Console.WriteLine("(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int a = Helper.ReadPositiveInt("a");
            int b = Helper.ReadPositiveInt("b");

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Dupa interschimbare, numerele sunt a={a} si b={b}.");


        }
    }
}
