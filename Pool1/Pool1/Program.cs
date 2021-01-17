using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Program
    {

        public static void AfiseazaIndicatiiProbleme()
        {
            Console.Clear();
            Console.WriteLine("********************************POOL 1********************************");
            Console.WriteLine("1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0.");
            Console.WriteLine("2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0");
            Console.WriteLine("3.Determinati daca n se divide cu k.");
            Console.WriteLine("4.Determinati daca un an y este an bisect.");
            Console.WriteLine("5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar.  ");
            Console.WriteLine("6.Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
            Console.WriteLine("7.Swap intre doua variabile numerice a si b .");
            Console.WriteLine("8.Swap restrictionat intre doua variabile numerice a si b. ");
            Console.WriteLine("9.Divizorii numarului n. ");
            Console.WriteLine("10.Determinati daca un numar n este prim.");
            Console.WriteLine("11.Afisati in ordine inversa cifrele unui numar n. ");
            Console.WriteLine("12.Determinati cate numere integi divizibile cu n se afla in intervalul[a, b].");
            Console.WriteLine("13.Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.WriteLine("14.Determianti daca un numar n este palindrom. ");
            Console.WriteLine("15.Se dau 3 numere.Sa se afiseze in ordine crescatoare. ");
            Console.WriteLine("16.Se dau 5 numere.Sa se afiseze in ordine crescatoare. ");
            Console.WriteLine("17.Determinati CMMDC si CMMMC a doua numere. ");
            Console.WriteLine("18.Afisati descompunerea in factori primi ai unui numar n. ");
            Console.WriteLine("19.Determinati daca un numar e format doar cu 2 cifre care se pot repeta.");
            Console.WriteLine("20.Afisati fractia m/ n in format zecimal, cu perioada intre paranteze(daca e cazul).Exemplu: 13 / 30 = 0.4(3).");
           // Console.WriteLine("     O fractie este neperiodica daca numitorul este de forma 2 ^ m * 5 ^ n unde m si n sunt mai mari sau egale decat 0.");
           // Console.WriteLine("     O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5.");
            //Console.WriteLine("     O fractie este periodica mixta daca se divide cu 2 si / sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5.");
            Console.WriteLine("21.Ghiciti un numar intre 1 si 1024 . ");
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
                Problema15.Rezolvare();
            }
            if (nrProblema == 16)
            {
                Problema16.Rezolvare();
            }
            if (nrProblema == 17)
            {
                Problema17.Rezolvare();
            }
            if (nrProblema == 18)
            {
                Problema18.Rezolvare();
            }
            if (nrProblema == 19)
            {
                Problema19.Rezolvare();
            }
            if (nrProblema == 20)
            {
                Problema20.Rezolvare();
            }
            if (nrProblema == 21)
            {
                Problema21.Rezolvare();
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
