using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartaPracy2
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
            const int limit = 20;
            if (waga < limit)
            {
                Console.WriteLine("tak");
            }
            else
            {
                Console.WriteLine("nie");
            }
            */

            /* zad 5. Napisz program, który sprawdzi, czy trzecia z podanych licz mieści się między pierwszą a drugą. Weź pod
                uwagę, że kolejność wpisywania dwóch pierwszych liczb może nie być zachowana.
                Przykłady:
                3 6 5 – TAK
                4 8 9 – NIE
                3 8 3 – NIE
                6 3 5 – TAK
                Wejście: a, b, c
                Wyjście: TAK / NIE

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (c < b && c > a || c > b && c < a)
            {
                Console.WriteLine("tak");
            }
            else
            {
                Console.WriteLine("nie");
            }
            */
            /* zad 6. Napisz program, który sprawdzi, czy liczba pierwsza p spełnia Małe Twierdzenie Fermata. Stosujemy
                wersję MTF w formie: ”Jeśli p jest pierwsza to dla każdego a liczba a
                p − a jest podzielna przez p”.
                Wejście: a, p
                Wyjście: TAK / NIE
            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            if ((Math.Pow(a, p) - a) % p == 0)
            {
                Console.WriteLine("tak, spełnia");
            }
            else
            {
                Console.WriteLine("nie, nie spełnia");
            }
            */

            /* zad 7. Bajtożabka osiowa oddaje tylko równe skoki o długości s wzdłuż osi. Napisz algorytm, który sprawdzi, czy
                żabka pokona zadany dystans w trzech skokach. Jako punkt startu przyjmujemy wartość p, a jako punkt
                końcowy punkt k, gdzie p, k, s >= 0
                Przykłady:
                0 100 40 – TAK
                0 60 20 – TAK
                10 50 15 – TAK
                30 100 20 – NIE
                Wejście: p, k, s
                Wyjście: TAK / NIE
                Dodatkowe dla chętnych: Podaj dodatkowo istotne Twoim zdaniem parametry rozwiązania w stylu ile
                żabce zabrakło do pokonania dystansu, o ile przekroczyła, ile skoków by wystarczyło, ile skoków zabrakło
                do celu, kolor żaby itp..

            int p = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            if ((p + 3*s) >= k)
            {
                Console.WriteLine("tak, żaba da rade");
            }
            else
            {
                Console.WriteLine("nie, żaba nie da rady");
            }
            */

            Console.ReadKey();
        }
    }
}

