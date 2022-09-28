using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Napisz program, który obliczy sumę kwadratów wpisanych liczb.
                Wejście: a, b
                Wyjście: suma kwadratów a^2 + b^2
            int a, b, wynik;
            Console.Write("Proszę podać pierwszą liczbę: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Proszę podać drugą liczbę: ");
            b = int.Parse(Console.ReadLine());
            wynik = (a * a) + (b * b);
            Console.WriteLine($"{a}^2 + {b}^2 = {wynik}");
            Console.ReadKey();
            */
            /* 3. Napisz program, który posortuje 3 wpisane liczby: x, y, z
                Wejście: x y z
                Wyjście: posortowane x y z
                Np:
                7 3 4
                3 4 7
            int x, y, z;
            Console.WriteLine("Proszę podać pierwszą liczbę: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać drugą liczbę: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać trzecią liczbę: ");
            z = int.Parse(Console.ReadLine());
            if (x > y && x > z)
            {
                if (y >= z)
                {
                    Console.WriteLine($"{x},{y},{z}");
                }
                else
                {
                    Console.WriteLine($"{x},{z},{y}");
                }
            }
            if (x >= y && x <= z)
            {
                Console.WriteLine($"{z},{x},{y}");
            }
            else if(x <= y && x <= z)
            {
                Console.WriteLine($"{z},{y},{z}");
            }
            else if (x <= y && x >= z)
            {
                Console.WriteLine($"{y},{x},{z}");
            }
            else if ( x <= y && x <= z)
            {
                Console.WriteLine($"{y},{z},{y}");
            }
            Console.ReadKey();
            */

            /* 4. Napisz program, który wylicza silnię liczby n
                Wejście: n
                Wyjście: wynik n! = 1 ∗ 2 ∗ 3 ∗ 4 ∗ ... ∗ n
                Np:
                6
                720
            int n = int.Parse(Console.ReadLine());
            int wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik = wynik * i;
            }
            Console.WriteLine($"{wynik}");
            Console.ReadKey();
            */

            /* 5. Napisz program, który wypisze w pętli ciąg siedmiu liczb całkowitych (−7, −3, 1, 5, 9, 13, 17)
                    Wejście: brak
                    Wyjście: −7, −3, 1, 5, 9, 13, 17
            int x;
            x = -7;
            for (int i = -7; i<=17; i=i+4){
                Console.WriteLine(i + " ");
            }
            int x = -7;
            int y = 1;
            while (y <= 7)
            {
                Console.WriteLine(x);
                y = y + 1;
                x = x + 4;
            }
            Console.ReadKey();
            */

            /*  6. Napisz program, który wypisze w pętli ciąg sześciu liczb całkowitych (2, 6, 18, 54, 162, 486)
                Wejście: brak
                Wyjście: 2, 6, 18, 54, 162, 486
            int x = 2;
            int y = 1;
            while (y <= 6)
            {
                Console.WriteLine(x);
                y = y + 1;
                x = x * 3;
            }
            Console.ReadLine();
            */

            /*  9.Napisz program, który podaje ilość cyfr w liczbie n
            Wejście: n
            Wyjście: ilość cyfr, z których składa się n
            Np:
            16234
            5
            Console.WriteLine("Podaj liczbę: ");
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            while (n >= 1)
            {
                n = n / 10;
                x = x + 1;
            }
            Console.WriteLine(x);
            Console.ReadKey();
            */

            /* 8. Napisz program, który sprawdzi, czy dana liczba n jest liczbą pierwszą
                Wejście: n
                Wyjście: TAK lub NIE
                Np:
                40
                NIE
                41
                TAK
            Console.WriteLine("proszę podać liczbę: ");
            int n = int.Parse(Console.ReadLine());
            bool flaga = true;
            for (int i = 2; i < n ; i++)
            {
                if (n % i == 0)
                {
                    flaga = false;
                    break;
                }
            }
            if (flaga) Console.WriteLine("Jest pierwsza");
            else Console.WriteLine("nie jest pierwsza");
            
            Console.ReadKey();
            */


        }
    }
}
