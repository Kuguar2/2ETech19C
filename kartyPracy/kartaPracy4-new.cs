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
        /*public static int kp1z1(int a, int b)
        {
            return a * a + b * b;
        }
        */

        /*public static bool kp2z2(int a)
        {
            return a >= 100 && a < 1000 && a % 17 == 0 ? true : false;
        }
        */

        /*
         * public static bool kp2z6(int a, int p)
        {
            return (Math.Pow(a, p) - a) % p == 0 ? true : false;
        }
        */

        /*
         * public static void kp3z1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(i * i * i + 3 + " ");
            }
        }
        */

        /*
         * public static ArrayList kp3z3(int x)
        {
            ArrayList alist = new ArrayList();
            for (int i = 1; i < x+1; i++)
            {
                if (x % i == 0)
                {
                    alist.Add(i);
                }
            }
            return alist;
        }
        */
        static void Main(string[] args)
        {
            /* 1.
             * int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(kp1z1(a, b));*/

            /* 2.
             * int a = int.Parse(Console.ReadLine());
             if (kp2z2(a)){
                Console.WriteLine("TAK");
            }
            else{
                Console.WriteLine("NIE");
            }
            */

            /* 3.
            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if (kp2z6(a, p))
            {
                Console.WriteLine("TAK, spełnia MTF");
            }
            else
            {
                Console.WriteLine("NIE, nie spełnia MTF");
            }
            */

            /* 4.
             * int n = int.Parse(Console.ReadLine());
            kp3z1(n);
            */
            /* 5.
             * ArrayList dzielniki = new ArrayList();
            int n = int.Parse(Console.ReadLine());
            dzielniki = kp3z3(n);
            foreach (int a in dzielniki ){
                Console.Write(a + " ");
            }
            */
            Console.ReadKey();

        }
    }
}
