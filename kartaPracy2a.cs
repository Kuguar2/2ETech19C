using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartaPracy2a
{
    class Program
    {
       
        static void Main(string[] args)
        {
            /* zad 1
             * (easy) Sprawdź czy suma dwóch wpisanych przez użytkownika jest liczbą parzystą.
                Wejście: a, b
                Wyjście: TAK / NIE

            Console.Write("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());
            int suma = a + b;
            if (suma % 2 == 0)
            {
                Console.WriteLine("liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("liczba jest nieparzysta");
            }

            */

            /* zad 2
             * (easy) Sprawdź, czy średnia arytmetyczna dwóch wpisanych liczb jest wieksza od jej średniej geometrycznej.
                Wejście: a,g
                Wyjście: TAK / NIE
                
            Console.Write("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());
            float ar = (a + b) / 2;
            float g = ((float)Math.Sqrt(a * b));
            if (ar > g)
            {
                Console.WriteLine($"średnia arytmetyczna jest większa i jest równa {ar}");
            }
            else if ( ar < g){
                Console.WriteLine($"średnia geometryczna jest większa i jest równa {g}");
            }
            else
            {
                Console.WriteLine($"są sobie równe");
            }
            */
            /* zad 3
             *  (easy) Użytkownik podaje 3 liczby całkowite. Sprawdź czy dokładnie dwie z nich są sobie równe.
                Wejście: k,l,m
                Wyjście: TAK / NIE (wraz z podaniem tych dwóch równych o ile są takowe)

            Console.Write("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę: ");
            int c = int.Parse(Console.ReadLine());
            if (a == b && a != c && b != c)
            {
                Console.WriteLine($"pierwsza i druga liczba są równe {a}");
            }
            else if(a == c && a != b && c != b)
            {
                Console.WriteLine($"pierwsza i trzecia liczba są równe {a}");
            }
            else if(b == c && b != a && c != a)
            {
                Console.WriteLine($"druga i trzecia liczba są równe {b}");
            }
            else
            {
                Console.WriteLine("nie ma dokładnie dwóch liczb, które są sobie równe");
            }
            */

            /* zad 4
             *  (medium) Niech użytkownik wprowadzi 4 różne liczby całkowite. Napisz program, który sprawdzi, która
                z tych liczb jest najmniejsza.
                Wejście: a,b,c,d
                Wyjście: najmniejsza z nich

            Console.Write("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Podaj czwartą liczbę: ");
            int d = int.Parse(Console.ReadLine());
            if (a == b || a == c || a == d || b == c || c == d || b == d)
            {
                Console.WriteLine("podano błędne wartości ");
            }
            else
            {
                if (a < b && a < c && a < d)
                {
                    Console.WriteLine($"{a} jest najmniejsza ");
                }
                else if (a > b && a < c && a < d)
                {
                    Console.WriteLine($"{b} jest najmniejsza ");
                }
                else if (a < b && a > c && a < d)
                {
                    Console.WriteLine($"{c} jest najmniejsza ");
                }
                else if (d < a && d < b && d < c)
                {
                    Console.WriteLine($"{d} jest najmniejsza ");
                }
            }
            */
            /*  zad 5
             *  (medium) Sprawdź czy trzy wprowadzone przez użytkownika liczby spełniają nierówność trójkąta.
                Wejście: a, b, c
                Wyjście: TAK / NIE

            Console.Write("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę: ");
            int c = int.Parse(Console.ReadLine());
            if (a == b || a == c || b == c)
            {
                Console.WriteLine("nie spełniają nierówności trójkąta");
            }
            else
            {
                Console.WriteLine("spełniają nierówności trójkąta");
            }
            */
            /* zad 6
             *  (medium) Niech z trzech wprowadzonych przez użytkwnika liczbach da się zbudować trójąt. Sprawdź czy
                ten trójką jest ostrokątny, prostokątny czy rozwartokątny.
                Wejście: a, b, c
                Wyjście: ostro-, prosto-, rozwarto-kątny
                
            Console.Write("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę: ");
            int c = int.Parse(Console.ReadLine());
            if (a * a + b * b > c * c)
            {
                Console.WriteLine("trójkąt jest ostrokątny");
            }
            else if (a * a + b * b == c * c)
            {
                Console.WriteLine("trójkąt jest prostokątny");
            }
            else
            {
                Console.WriteLine("trójkąt jest rozwartokątny");
            }
            */
        }
    }
}
