using System;

namespace kartaPracy2a
{
    class Program
    {
       public static int kp2az1(int a,int b)
        {
            return a + b;
        }
        public static bool kp2az2(int a, int b)
        {
            float ar = (a + b) / 2;
            float g = ((float)Math.Sqrt(a * b));
            return ar > g ? true : false;
        }
        public static int kp2az3(int a, int b,int c)
        {
             if (a == c)
            {
                return a;
            }
            else if (b == c)
            {
                return c;
            }
            else if (a == b)
            {
                return b;
            }
            else {
                return 0;
            }

        }
        public static int kp2az4(int a,int b,int c, int d)
        {
            if (a == b || a == c || a == d || b == c || c == d || b == d)
            {
                return 0;
            }
            else
            {
                if (a < b && a < c && a < d)
                {
                    return a;
                }
                else if (a > b && a < c && a < d)
                {
                    return b;
                }
                else if (a < b && a > c && a < d)
                {
                    return c;
                }
                else if (d < a && d < b && d < c)
                {
                    return d;
                }
                else
                {
                    return 0;
                }
            }
        }
        public static bool kp2az5(int a, int b, int c)
        {
            if(a == b || a == c || b == c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string kp2az6(int a, int b, int c)
        {
            if (a * a + b * b > c * c)
            {
                return "ostrokątny";
            }
            else if (a * a + b * b == c * c)
            {
                return "prostokątny";
            }
            else
            {
                return "rozwartokątny";
            }
        }
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
            int suma = kp2az1(a,b);
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
            if (kp2az2(a,b))
            {
                Console.WriteLine($"średnia arytmetyczna jest większa i jest równa {ar}");
            }
            else{
                Console.WriteLine($"średnia geometryczna jest większa i jest równa {g}");
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
            Console.WriteLine($"te dwie liczby są równe {kp2az3(a,b,c)}");
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
            Console.WriteLine($"najmniejsza jest {kp2az4(a,b,c,d)}");
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
            if (kp2az5(a,b,c))
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
            Console.WriteLine($"trójkąt jest {kp2az6(a,b,c)}");
            */
        }
    }
}
