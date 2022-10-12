using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /*
         * public static int Zad2(int n)
        {
            int suma = 0;
            int cyfra;
            while (n > 0)
            {
                cyfra = n % 10;
                suma += cyfra;
                n = n / 10;
            }
            return suma;
        }
        */
        /* forma rekurencyjna:
         * public static int Zad3(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Zad3(n - 1);
        }
        */
        /* forma iteracyjna:
         * public static int Zad3(int n)
        {
            int silnia = 1;
            for (int i = 1; i <= n; i++)
            {
                silnia = silnia * i;
            }
            return silnia;
        }
        */
        public static int Zad4(int n)
        {
            if ( n == 0){
                return 0;
            }
            if ( n == 1)
            {
                return 1;
            }
            return Zad4(n - 1) + Zad4(n - 2);
        }
        static void Main(string[] args)
        {
            /* zad 2
             * int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad2(n));
            */

            /* zad 3 rekurencyjna
             * int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad3(n));
            */

            /* zad 3 iteracyjna
             * int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad3(n));
            */

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad4(n));
        }
    }
}
