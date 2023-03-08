using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Komputer
    {
        public string Model { get; set; }
        public string Marka { get; set; }
    }
    class Osoby {
        public string imie { get => imie; set => imie = value; }
    }
    class PC : Komputer {
        public string rodzajobudowy { get; set; }
    }
    class Laptop : Komputer
    {
        public double dlugprzekatnej { get; set; }
        public string kolorobudowy;
        public String getKolor() { return kolorobudowy; }
        public void setKolor(String kolorobudowy) { this.kolorobudowy = kolorobudowy; }
    }
    class Opiekun : Osoby 
    {
        
    }
    class Klient : Osoby
    {

    }
    class Serwisant : Osoby
    {

    }
    class Zlecenie
    {
        private Opiekun opiekun;
        private Klient klient;
        private Komputer komputer;
        public Zlecenie(Komputer komputer,Opiekun opiekun,Klient klient)
        {
            this.komputer = komputer;
            this.opiekun = opiekun;
            this.klient = klient;
        }

        // tu gety i sety do pól
        public void zlec()
        {

        }
    }
    class Naprawa
    {
        public Serwisant serwisant { get; set; }
        public Zlecenie zlecenie { get; }
        public Naprawa(Zlecenie zlecenie)
        {
            this.zlecenie = zlecenie;
        }

        public void naprawiaj()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Komputer k1 = new Komputer();
            k1.Model = Console.ReadLine();
            Console.WriteLine(k1.Model);
            Console.ReadKey();
        }
    }
}
