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
        private List<Uczen> listaUczniow = new List<Uczen>();
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
        public void setListaUczniow(List<Uczen> alistaUczniow)
        {
            this.listaUczniow = alistaUczniow;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Szkola s1 = new Szkola();
            Uczen u1 = new Uczen();
            u1.setSzkola(s1);
            u1.feedback();
            s1.setWezwanie("wzywam");

            Nauczyciel n1 = new Nauczyciel("Bartosz");
            n1.setSzkola(s1);

            Klasa k1 = new Klasa(s1, n1);

            k1.setNauczyciel(n1);
        }
    }
}
