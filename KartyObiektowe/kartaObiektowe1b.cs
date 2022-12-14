using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Koszyk
    {
        private int id;
        private Produkt produkt;
        private Uzytkownik uzytkownik;
        public int getId()
        {
            return id;
        }
        public void operation()
        {
            Console.WriteLine("operation");
        }
        public Koszyk(Produkt aprodukt)
        {
            this.produkt = aprodukt;
        }
        public void setUzytkownik(Uzytkownik auzytkownik)
        {
            this.uzytkownik = auzytkownik;
        }
    }
    class Produkt
    {
        private string nazwa;
        private double cena;
        private string opis;
        public string getNazwa()
        {
            return nazwa;
        }
        public void setNazwa(string anazwa)
        {
            this.nazwa = anazwa;
        }
        public double getCena()
        {
            return cena;
        }
        public string getOpis()
        {
            return opis;
        }
        public Produkt(string anazwa, double acena, string aopis)
        {
            this.nazwa = anazwa;
            this.cena = acena;
            this.opis = aopis;
        }
    }
    class Uzytkownik
    {
        private string login;
        private string haslo;
        private Profil profil;
        public void loguj()
        {
            Console.WriteLine("zalogowano");
        }
        public Uzytkownik(Profil aprofil)
        {
            this.profil = aprofil;
        }
    }
    class Profil
    {
        private string imie;
        private string drugieImie;
        private string nazwisko;
        public string getImie()
        {
            return imie;
        }
        public string getNazwisko()
        {
            return nazwisko;
        }
        public void setNazwisko(string anazwisko)
        {
            this.nazwisko = anazwisko;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profil prof1 = new Profil();
            
            Uzytkownik u1 = new Uzytkownik(prof1);
            
            u1.loguj();
            prof1.setNazwisko("Kiełducki");
            Console.WriteLine($"{prof1.getNazwisko()}");
            
            Produkt prod1 = new Produkt("milka",22,"lody");
            Koszyk k1 = new Koszyk(prod1);
            
            Console.WriteLine($"{prod1.getNazwa()}");
            prod1.setNazwa("kaktusy");
            Console.WriteLine($"{prod1.getNazwa()}");
            k1.operation();
            Console.ReadKey();
        }
    }
}
