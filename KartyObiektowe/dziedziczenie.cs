using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Osoba
    {
        private int id;
        private string imie;

        public void zbadajSie()
        {
            Console.WriteLine("Badam się per rectum");
        }
    }
    class Pracownik : Osoba
    {

        public void zarejestruj()
        {
            Console.WriteLine("Jestem w pracy");
        }
        /* dzięki base nie nadpisze się i wyswietli obie metody zbadajSie ale normalnie chcemy usuwać wszystko co jest takie samo w obu klasach
         * z klasy która dziedziczy od innej klasy
        public void zbadajSie()
        {
            base.zbadajSie();
            Console.WriteLine("Badam się normalnie");
        }
        */
        public void zbadajSie()
        {
            Console.WriteLine("Badam się normalnie");
        }
    }

    class Kierownik : Osoba
    {
        private int id;
        private string imie;

        public void sprawdzPracownika(int id)
        {
            Console.WriteLine("Sprawdzony");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik pr1 = new Pracownik();
            pr1.zarejestruj();
            pr1.zbadajSie();

            Osoba os1 = new Osoba();
            os1.zbadajSie();

            Osoba os2 = new Pracownik();
            os2.zbadajSie();

            /* tego sie nie da 
            Pracownik pr2 = new Osoba(); 
            */
            
            Console.ReadKey();
        }
    }
}
