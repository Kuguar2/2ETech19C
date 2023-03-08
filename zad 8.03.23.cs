using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Komputer
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        public virtual void wyswietl()
        {
            Console.WriteLine("Marka:" + Marka + "Model: " + Model);
        }
    }
    class Osoby {
        public string imie { get => imie; set => imie = value; }
    }
    class PC : Komputer {
        public string rodzajobudowy { get; set; }
        public override void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine("Rodzaj obudowy: " + rodzajobudowy);
        }
    }
    class Laptop : Komputer
    {
        public double dlugprzekatnej { get; set; }
        public string kolorobudowy;
        public String getKolor() { return kolorobudowy; }
        public void setKolor(String kolorobudowy) { this.kolorobudowy = kolorobudowy; }
        public override void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine("Długość przekątnej: " + dlugprzekatnej + "Kolor: " + kolorobudowy);
        }
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
            // Prosty sposób

            /*
            Laptop l1 = new Laptop();
            l1.Marka = Console.ReadLine();
            l1.Model = Console.ReadLine();
            l1.dlugprzekatnej = double.Parse(Console.ReadLine());
            l1.setKolor(Console.ReadLine());
            Console.WriteLine(l1.Marka + " " + l1.Model + " " + l1.dlugprzekatnej + " " + l1.getKolor());
            */

            // trudniejszy i kreatywniejszy sposób

            Console.WriteLine("Co masz do naprawy?");
            Console.WriteLine("1 - Komp; 2 - lap: ");
            int wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    {
                        PC pc = new PC();
                        pc.Marka = Console.ReadLine();
                        pc.Model = Console.ReadLine();
                        pc.rodzajobudowy = Console.ReadLine();
                        pc.wyswietl();

                        break;
                    }
                case 2:
                    {
                        Laptop l1 = new Laptop();
                        l1.Marka = Console.ReadLine();
                        l1.Model = Console.ReadLine();
                        l1.dlugprzekatnej = double.Parse(Console.ReadLine());
                        l1.setKolor(Console.ReadLine());
                        l1.wyswietl();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("miałeś podać 1 lub 2");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
