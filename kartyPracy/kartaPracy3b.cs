using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            /* zad 1.
            int i = 1;
            while ( i <= 30){
                Console.WriteLine($"{i}");
                i++;
            }
            */

            /* zad 2.
            int  i = 1;
            while (i < 100)
            {
                int wynik = i * i;
                Console.WriteLine($"{i}^2 = {wynik}");
                i = i + 2;
            }
            */
            /* zad 3.
            int i = 1000;
            while (i < 10000)
            {
                if(i % 379 == 0)
                {
                    Console.WriteLine($"{i}");
                }
                i++;
            }
            */

            /* zad 4.
            int i = 100;
            while (i < 1000)
            {
                if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
                {
                    Console.WriteLine($"{i}");
                }
                i++;
            }
            */

            /* zad 5.
            Console.WriteLine("napisz ile chcesz liczb: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int wynik = 0;
            while (i <= n)
            {
                Console.WriteLine($"Podaj liczbę {i}: ");
                int a = int.Parse(Console.ReadLine());
                wynik = wynik + a;
                i++;
            }
            Console.WriteLine($"{wynik}");
            */

            /* zad 6.
            Console.WriteLine("Ile liczb parzystych chcesz zsumować: ");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            int suma = 0;
            while (i <= n)
            {
                suma += i;
                i += 2;
            }
            Console.WriteLine($"suma = {suma}");
            */

            /* zad 7.
            Console.WriteLine("Ile liczb dwucyfrowych nieparzystych chcesz zsumować: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int j = 11;
            int suma = 0;
            while (i <= n)
            {
                if (i < 100){
                    suma += j;
                    i++;
                    j += 2;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"suma = {suma}");
            */

            /* zad 8.
            Console.WriteLine("Podaj długość inwestycji: ");
            float l = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj kwotę wejściową: ");
            float w = float.Parse(Console.ReadLine());
            float wynik = w;
            float czas = l * 12;
            int i = 0;
            while (i < czas)
            {
                float profit = ((float)0.5 * w)/100;
                w += profit;
                i++;
            }
            Console.WriteLine($"{w}");
            */

            /* zad 9.
            Console.WriteLine("Podaj ile chcesz liczb kończących się 21: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int suma = 0;
            int liczba = 21;
            while (i <= n)
            {
                suma = suma + liczba;
                liczba += 100;
                i++;
            }
            Console.WriteLine($"suma = {suma}");
            }
            */

            /* zad 10.
            int i = 1;
            while (i <= 1000)
            {
                if(i % 10 == Math.Sqrt(i))
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            */
        }
    }
}
