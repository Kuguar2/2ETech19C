using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kartaPracy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 1.(Easy) Napisz program, który wypisze ciąg sześcianów liczb naturalnych powiększonych o 3 Wejście: Wyjście: 3,4,11... 
             */

            /*
            int x;
            Console.WriteLine("Proszę podać ilość liczb: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"{i+1} liczba jest równa {i*i*i+3}");
            }
            */

            /*  
             2.(Easy) Napisz program, który wypisze wszytkie liczby trzycyfrowe podzielne przez 15. Wejście: Wyjście: 105,120,135...
            */

            /*
            for (int i = 105;i < 1000; i=i+15)
            {
                Console.WriteLine($"{i}");
            }
            */

            /*
            for (int i = 105;i < 1000; i++)
            {
                if(i % 15 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            } 
             */
            /* 
              3.(Medium) Napisz program, który wypisze wszyskie dzielniki podanej liczby n. Wejście: p Wyjście: dzielniki
             */

            /*
            int n,p;
            Console.WriteLine("Proszę podać liczbę: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            */

            /* 
              4.(Medium) Napisz program, który obliczy sumę liczb dwucyfrowych. Wejście: Wyjście: 4905
            */

            /*
            int suma;
            suma = 0;
            for (int i = 10; i <100; i++)
            {
                suma = suma + i ;
            }
            Console.Write($"{suma}");
            */

            /*
             5.(Hard) Bajtuś postanowił zrobić dla swoich kolegów pewną zagadkę. Zagadka polega na tym, że koledzy najpierw podają liczbę naturalną n. 
            Następnie Bajtuś wybiera sobie liczbę x, taką, że 0 < x < n oraz wypisuje n−1 różnych, mniejszych on n liczb pomijając przy tym swoje tajemnicze x.
            Napisz program, który pozwoli sprawdzić, jaką liczbę x wybrał sobie Bajtuś.
            Przykłady:
            WE: 5 1 2 4 5 WY: 3
            WE: 6 6 5 3 2 1 WY: 4
            WE: 7 4 6 1 3 7 2 WY: 5

             */

            /*
            int n, suma;
            Console.WriteLine("Podaj liczbę naturalną: ");
            n = int.Parse(Console.ReadLine());
            suma = n * (n + 1) / 2;
            int liczba;
            for (int i = 0; i < n - 1; i++)
            {
                liczba = int.Parse(Console.ReadLine());
                suma = suma - liczba;
            }
            Console.WriteLine($"{suma}");
            Console.ReadKey();
            */
            /* 6. (Hard) Napisz program według wyjścia poniżej (ciąg Fibonacciego). Zastosuj do tego zadania pętle for.
                Wejście:
                Wyjście: 1, 2, 3, 5, 8, 13, 21, 34


            Console.WriteLine("Ile chcesz liczb fibonacciego? ");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 2;
            int temp;
            Console.Write(a);
            for(int i = 1; i <= n; i++)
            {
                Console.Write($", {b}");
                temp = b;
                b = a + b;
                a = temp;
            }
            Console.WriteLine(" ");
            Console.ReadKey();
            */

        }
    }
}
