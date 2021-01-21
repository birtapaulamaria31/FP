using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Program
    {
        public static void AfiseazaIndicatiiProbleme()
        {
            Console.Clear();
            Console.WriteLine("********************************POOL 3********************************");
            Console.WriteLine("1.Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
            Console.WriteLine("2.Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. ");
            Console.WriteLine("3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).");
            Console.WriteLine("4.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.");
            Console.WriteLine("5.Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.");
            Console.WriteLine("6.Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.");
            Console.WriteLine("7.Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
            Console.WriteLine("8.Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.");
            Console.WriteLine("9.Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. ");
            Console.WriteLine("10.Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1.");
            Console.WriteLine("11.Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). ");
            Console.WriteLine("12.Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.");
            Console.WriteLine("13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.");
            Console.WriteLine("14.Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). ");
            Console.WriteLine("15.Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. ");
            Console.WriteLine("16.Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului. ");
            Console.WriteLine("17.Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b. ");
            /* Console.WriteLine("18.Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. ");
             Console.WriteLine("19.Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).");
             Console.WriteLine("20.Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. ");
             Console.WriteLine("21.Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). ");
             Console.WriteLine("22.Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.  ");
             Console.WriteLine("23.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare.  ");
             Console.WriteLine("24.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar). ");
             Console.WriteLine("25.(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate.  ");
             Console.WriteLine("26.Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.  ");
             Console.WriteLine("27. Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.  ");
           */
            Console.WriteLine("28.Quicksort. Sortati un vector folosind metoda QuickSort.  ");
            Console.WriteLine("29.MergeSort. Sortati un vector folosind metoda MergeSort. ");
         /*   Console.WriteLine("30.Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima.  ");
            Console.WriteLine("31.(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). ");
       */ }

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
           /* if (nrProblema == 18)
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
            }*/
            if (nrProblema == 28)
            {
                Problema28.Rezolvare();
            }
            if (nrProblema == 29)
            {
                Problema29.Rezolvare();
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
