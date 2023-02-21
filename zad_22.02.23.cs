using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Egzemplarz
    {
        private int ilosc;
    }
    class Stan
    {
        public string stanKsiazki;
    }
    class Pulka
    {
        private int pojemnosc;
        public int dlugosc;
        private int id;
        public int nrPulki;
        public string litera;
        private Ksiazka ksiazka;
        public Pulka(int aid,int anrPulki)
        {
            this.id = aid;
            this.nrPulki = anrPulki;
        }
        public void SetKsiazka(Ksiazka aksiazka)
        {
            this.ksiazka = aksiazka;
        }
    }
    class Wydawnictwo
    {
        public string nazwa;
        private string lokalizacja;
        private Ksiazka ksiazka;
        public void sprzedajKsiazke()
        {
            Console.WriteLine("Sprzedaje");
        }
        private void drukujKsiazke()
        {
            
        }
        public Wydawnictwo(Ksiazka aksiazka)
        {
            this.ksiazka = aksiazka;
        }
        public Wydawnictwo(string anazwa,string alokalizacja)
        {
            this.nazwa = anazwa;
            this.lokalizacja = alokalizacja;
        }
    }
    class Bibliotekarz
    {
        private string imie;
        private string nazwisko;
        private int id;
        private int pensja;
        private void znajdzPolke()
        {

        }
        private void znajdzKsiazke()
        {

        }
        private void odlozKsiazke()
        {

        }
        private void sprawdzStan()
        {

        }
        private void sprawdzIlosc()
        {

        }
        private void odbierzKsiazke()
        {

        }
    }
    class Ksiazka
    {
        public string tytul;
        public string autor;
        public int rokWydania;
        public int ilosc;
        private int id;
        public string gatunek;
        private Egzemplarz egzemplarz;
        private Stan stan;
        public Ksiazka(Egzemplarz aegzemplarz,Stan astan)
        {
            this.egzemplarz = aegzemplarz;
            this.stan = astan;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Egzemplarz e = new Egzemplarz();
            Stan s = new Stan();
            Pulka p = new Pulka(1,4);
            Ksiazka k = new Ksiazka(e,s);
            Wydawnictwo w = new Wydawnictwo(k);
            w.sprzedajKsiazke();
            Bibliotekarz b = new Bibliotekarz();
            Console.ReadKey();
        }
    }
}
