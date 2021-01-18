using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema21
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 21.");
            Console.WriteLine("Iti ghicesc un numar intre 1 si 1024 prin intrebari de forma NUMARUL ESTE MAI MARE SAU EGAL DECAT X?");
            Console.WriteLine("Gandeste-te la un numar intre 1 si 1024.");

        }

        public static void CautareBinara(int stanga, int dreapta)
        {
            int mij,nrGhicit;
            mij = (stanga + dreapta) / 2;
            nrGhicit = mij;
            Console.WriteLine($"Numarul la care te gandeai a fost {nrGhicit}?");
            Console.WriteLine($"        Daca da apasa TASTA 1,  ");
            Console.WriteLine($"        daca numarul este mai mic decat numarul afisat apasa TASTA 2,");
            Console.WriteLine($"        iar daca numarul este mai mare apasa TASTA 3.");

            int raspuns=Helper.ReadPositiveInt("raspuns");
            if(raspuns==1)
            {
                Console.WriteLine(" HEHE, AM GHICIT NUMARUL LA CARE TE-AI GANDIT!");
            }
            else if(raspuns==2)
            {
                dreapta = mij - 1;
                CautareBinara(stanga, dreapta);
            }
            else if(raspuns==3)
            {
                stanga = mij + 1;
                CautareBinara(stanga, dreapta);
            }
        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            CautareBinara(1,1024);

        }
    }
}
