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

            int ile = 0;
            for(int i = 10; i < 100; i++)
            {
                if(i / 10 > i % 10 && i / 10 >= i % 10 * 2) {
                    ile += 1;
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine($"{ile}");

            Console.ReadKey();
        }
    }
}
