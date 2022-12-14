using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* zad 1
            Console.WriteLine("Podaj 1-szą liczbę: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 2-gą liczbę: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 3-cią liczbę: ");
            float c = float.Parse(Console.ReadLine());
            if (a - b == b - c || b - a == c - b)
            {
                Console.WriteLine("Ciąg jest arytmetyczny");
            }
            else
            {
                Console.WriteLine("Ciąg nie jest arytmetyczny");
            }
            if (b / a == c / b || a / b == b / c)
            {
                Console.WriteLine("Ciąg jest geometryczny");
            }
            else
            {
                Console.WriteLine("Ciąg nie jest geometryczny");
            }
            if (a > b && b > c)
            {
                Console.WriteLine("Ciąg jest malejący");
            }
            else
            {
                Console.WriteLine("Ciąg nie jest malejący");
            }
            if(a < b && b < c)
            {
                Console.WriteLine("ciąg jest rosnący");
            }
            else
            {
                Console.WriteLine("Ciąg nie jest rosnący");
            }
            */

            /* zad 2
            int suma = 0;
            for(int i = 100; i < 1000; i++)
            {
                if(i % 8 == 0 && i % 16 != 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine($"suma = {suma}");
            */

            /* zad 3
            int a = 0;
            for (int i = 10; i < 100; i++)
            {
                if (i % 7 == 0)
                {
                    a = i;
                }
            }
            Console.WriteLine($"{a}");
            int ile = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i * a > 999 && i * a < 10000)
                {
                    ile += 1;
                }
            }
            Console.WriteLine($"{ile}");
            */

            /* zad 4
            int ile = 0;
            for(int i = 10; i < 100; i++)
            {
                if(i / 10 > i % 10 && i / 10 >= i % 10 * 2) {
                    ile += 1;
                }
            }
            Console.WriteLine($"{ile}");
            */

            /* zad 5
            int suma = 0, ile = 0;
            for(int i = 100; i < 1000; i++)
            {
                if(i / 100 > ((i / 10) % 10) + ((i % 100) % 10)){
                    ile += 1;
                    suma += i;
                }
            }

            Console.WriteLine($"ilość takich liczb to: {ile} a ich suma wynosi {suma}");
            */

            /* zad 6
            int suma = 0,max = 0;
            Console.WriteLine("Podaj ile liczb dwucyfrowych podzielnych przez 19 chcesz dodać: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 10; i < 100; i++)
            {
                if(i % 19 == 0 && max < n)
                {
                    suma += i;
                    Console.WriteLine(i);
                    max += 1;
                }
            }
            Console.WriteLine($"suma = {suma}");
            */

            /* zad 7
            int suma = 0, max = 0;
            Console.WriteLine("Podaj ile liczb dwucyfrowych podzielnych przez 37 chcesz dodać: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 100; i < 1000; i++)
            {
                if (i % 37 == 0 && max < n)
                {
                    suma += i;
                    Console.WriteLine(i);
                    max += 1;
                }
            }
            Console.WriteLine($"suma = {suma}");
            */

            /* zad 8
            int suma = 0;
            Console.WriteLine("Podaj długość ciągu skaczącego: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n * 3; i += 3)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
                if(i % 2 != 0)
                {
                    suma += -i;
                }
            }
            Console.Write($" suma = {suma}");
            */

            /* zad 9
            int iloczyn = 1, liczba = 1;
            Console.WriteLine("Podaj długość ciągu zakręconego: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                liczba *= -2;
                iloczyn *= liczba;
            }
            Console.Write($" iloczyn = {iloczyn}");
            */



            Console.ReadKey();
        }
    }
}
