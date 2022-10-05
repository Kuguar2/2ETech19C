using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* zad 1.  Napisz program, który sprawdzi, czy wpisana liczba jest podzialna przez 3.
                Wejście: a
                Wyjście: TAK / NIE

            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("jest podzielna");
            }
            else
            {
                Console.WriteLine("nie jest podzielna");
            }
            */

            /* zad 2.Napisz program, który sprawdzi, czy wpisana liczba jest trzycyfrowa i podzielna przez 17.
                Wejście: a
                Wyjście: TAK / NIE

            int a = int.Parse(Console.ReadLine());
            if (a >= 100 && a < 1000 && a % 17 == 0)
            {
                Console.WriteLine("tak");
            }
            else
            {
                Console.WriteLine("nie");
            }
            */

            /* zad 3.  Napisz program, który sprawdzi, czy użytkownik jest osobą pełnoletnią.
                Wejście: wiek
                Wyjście: TAK / NIE
            int wiek = int.Parse(Console.ReadLine());
            if(wiek < 18)
            {
                Console.WriteLine("Nie");
            }
            else
            {
                Console.WriteLine("tak");
            }
            */

            /* zad 4. Napisz program, który sprawdzi, czy ciężarówka może wjechać bezpiecznie na most. Max obciążenie mostu
                przyjmij na sztywno na 20 ton. Utwórz stałą o nazwie limit.
                Wejście: waga
                Wyjście: TAK / NIE

            int waga = int.Parse(Console.ReadLine());
            int limit = 20;
            if (waga < limit)
            {
                Console.WriteLine("tak");
            }
            else
            {
                Console.WriteLine("nie");
            }
            */



            Console.ReadKey();
        }
    }
}
