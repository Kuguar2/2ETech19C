using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    /*
    interface IOdprawa
    {
        void odprawSie();
    }
    abstract class Osoba
    {
        public string Imie { get; set; }
    class Pracownik : Osoba
    {

    }
    class Kierownik : Osoba, IOdprawa
    {
        public void odprawSie()
        {
            Console.WriteLine("Kierownik odprawiony");
        }
    }
    */
    /*

    interface IZdalny
    {
        void zdalnie();
    }
    interface IBezklucz
    {
        void wejdz();
    }
    abstract class Auto
    {
        public abstract string Model { get; set; }
        public void jedz()
        {
            Console.WriteLine("jadę");
        }
    }
    class Mercedes : Auto, IBezklucz
    {
        public void wejdz()
        {
            Console.WriteLine("wchodzę bez klucza");
        }
        public override string Model { get; set; }
    }
    class Audi : Auto, IZdalny, IBezklucz
    {
        
        public void zdalnie()
        {
            Console.WriteLine("dostęp zdalny");
        }

        public void wejdz()
        {
            Console.WriteLine("wchodzę bez klucza");
        }

        public override string Model { get; set; }
    }
    class BMW : Auto, IZdalny
    {
        public void zdalnie()
        {
            Console.WriteLine("dostęp zdalny");
        }
        public override string Model { get; set; }
    }
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Mercedes m = new Mercedes();
            m.wejdz();
            m.jedz();
            m.Model = "a6";
            Console.WriteLine(m.Model);
            Audi a = new Audi();
            a.wejdz();
            a.zdalnie();
            a.jedz();
            a.Model = "a3";
            Console.WriteLine(a.Model);
            BMW b = new BMW();
            b.zdalnie();
            b.jedz();
            b.Model = "f4";
            Console.WriteLine(b.Model);
            */



            Console.ReadKey();
        }
    }
}
