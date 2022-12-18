using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Szkola
    {
        private string adres;
        private string wezwanie;
        private int rokPowstania;
        public string getAdres()
        {
            return adres;
        }
        public void setAdres(string aAdres)
        {
            this.adres = aAdres;
        }
        public string getWezwanie()
        {
            return wezwanie;
        }
        public void setWezwanie(string awezwanie)
        {
            this.wezwanie = awezwanie;
        }
    }
    class Uczen
    {
        private string pesel;
        private string login;
        private Szkola szkola;
        public void uczeSie()
        {
            Console.WriteLine("Uczę się");
        }
        public int feedback()
        {
            return 1;
        }
        public void setSzkola(Szkola aszkola)
        {
            this.szkola = aszkola;
        }
    }
    class Nauczyciel
    {
        private int id;
        private string imie;
        private Szkola szkola;
        public Nauczyciel(string aimie)
        {
            this.imie = aimie;
        }
        public void setSzkola(Szkola aszkola)
        {
            this.szkola = aszkola;
        }
    }
    class Klasa
    {
        private int poziom;
        private string nazwa;
        private Szkola szkola;
        private Nauczyciel wychowawca;
        private ArrayList listaUczniow = new ArrayList();
        private Nauczyciel wychowawcaDrugi;
        public Klasa(Szkola aszkola,Nauczyciel awychowawca)
        {
            this.szkola = aszkola;
            this.wychowawca = awychowawca;
        }
        public void setNauczyciel(Nauczyciel awychowawcadrugi)
        {
            this.wychowawcaDrugi = awychowawcadrugi;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Szkola s1 = new Szkola();
            Uczen u1 = new Uczen();
            u1.setSzkola(s1);
        }
    }
}
