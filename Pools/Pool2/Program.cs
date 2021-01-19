using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Program
    {

        public static void AfiseazaIndicatiiProbleme()
        {

            Console.Clear();
            Console.WriteLine("********************************POOL 2********************************");
            Console.WriteLine("1.Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
            Console.WriteLine("2.Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.");
            Console.WriteLine("3.Calculati suma si produsul numerelor de la 1 la n. ");
            Console.WriteLine("4.Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. ");
            Console.WriteLine("5.Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. ");
            Console.WriteLine("6.Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
            Console.WriteLine("7.Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.");
            Console.WriteLine("8.Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ... ");
            Console.WriteLine("9.Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");
            Console.WriteLine("10.Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. ");
            Console.WriteLine("11.Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.  ");
            Console.WriteLine("12.Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. ");
            Console.WriteLine("13.O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita.");
            Console.WriteLine("14.O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            Console.WriteLine("15.O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica.");
            Console.WriteLine("16.O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. ");
            Console.WriteLine("17.Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.");

        }

        public static void Intro()
        {
            AfiseazaIndicatiiProbleme();
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("Introdu numarul problemei pe care vrei sa o rezolvi: ");
            int nrProblema = int.Parse(Console.ReadLine());
            if (nrProblema == 1)
            {
                Problema1.Rezolvare();
            }
            if (nrProblema == 2)
            {
                Problema2.Rezolvare();
            }
            if (nrProblema == 3)
            {
               Problema3.Rezolvare();
            }
            if (nrProblema == 4)
            {
                Problema4.Rezolvare();
            }
            if (nrProblema == 5)
            {
                Problema5.Rezolvare();
            }
            if (nrProblema == 6)
            {
                Problema6.Rezolvare();
            }
            if (nrProblema == 7)
            {
                Problema7.Rezolvare();
            }
            if (nrProblema == 8)
            {
                Problema8.Rezolvare();
            }
            if (nrProblema == 9)
            {
                Problema9.Rezolvare();
            }
            if (nrProblema == 10)
            {
               Problema10.Rezolvare();
            }
            if (nrProblema == 11)
            {
            Problema11.Rezolvare();
            }
            if (nrProblema == 12)
            {
                Problema12.Rezolvare();
            }
            if (nrProblema == 13)
            {
                Problema13.Rezolvare();
            }
            if (nrProblema == 14)
            {
                Problema14.Rezolvare();
            }
            if (nrProblema == 15)
            {
            //    Problema15.Rezolvare();
            }
            if (nrProblema == 16)
            {
             //   Problema16.Rezolvare();
            }
            if (nrProblema == 17)
            {
           //     Problema17.Rezolvare();
            }
           
            Console.WriteLine();
            Console.WriteLine("Apasa orice tasta ca sa te intorci la meniul cu toate problemele.");
            Console.ReadKey();
            Intro();

        }

        static void Main(string[] args)
        {
            Intro();
            Console.ReadKey();
        }
    }
}
