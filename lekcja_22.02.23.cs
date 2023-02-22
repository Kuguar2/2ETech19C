using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp6
{
    class Student1
    {
        public int numer;
        public string imie;
    }
    class Student2
    {
        private int numer;
        private string imie; 
        public int GetNumer()
        {
            return numer;
        }

        public void SetNumer(int aNumer)
        {
            this.numer = aNumer;
        }

        public string GetImie()
        {
            return imie;
        }

        public void SetImie(string aImie)
        {
            this.imie = aImie;
        }

    }
    class Student3
    {
        int numer;
        string imie;

        public int Numer
        {
            get
            {
                return numer;
            }
            set
            {
                numer = value;
            }
        }

        public string Imie { get => imie; set => imie = value; }

        // Student 2 robi to samo ale jest dłuższy dłuższe
    }
    class Student4
    {
        public int Numer { get; set; }
        public string Imie { get; set; }
        // to robi to samo co student 3 i 2
    }
    class Animal
    {
        // ustawiamy 2 właściwości Name i Domestic
        public string Name { get; set; }
        public bool Domestic { get; set; }
        
        public virtual void Introduce()
        {
            Console.WriteLine("hau");
        }
    }
    class Pies : Animal
    {
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine(Name + " - hau od Psa");
        }
        
    }
    class Wilk : Animal
    {
        public override void Introduce()
        {
            Console.WriteLine(Name + " - hau od Wilka");
        }
    }

    //Base Class: Firma (pole nip z geterem: "NIP - to nip firmy") i metoda WystawFakture()
    // derived Class: Polska, Niemiecka
    // Klasy mają mieć konstruktor
    // Klasy Derived mają dodawać przed nip przedrostek PL/DE (w geterze)
    class Firma
    {
        protected string nip;
        public virtual string NIP
        {
            get
            {
                return nip + "- to nip firmy";
            }
        }
        public Firma(string nip)
        {
            this.nip = nip;
        }
        public void WystawFakture()
        {

        }
    }
    class Polska : Firma
    {
        public override string NIP
        {
            get
            {
                return "PL" + base.NIP;
            }
        }
        public Polska(string nip) :base(nip)
        {
            this.nip =nip + " ads ";
        }
    }
    class Niemiecka : Firma
    {
        public override string NIP
        {
            get
            {
                return "DE" + base.NIP;
            }
        }
        public Niemiecka(string nip) : base(nip)
        {
            this.nip = nip;
        }
     }
    class MyProgram
    {
        public static int Wieksza(int a,int b)
        {
            if (a > b) return a;
            else return b;
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Czesc");
            Console.WriteLine(Wieksza(4, 5));
            Student1 s1 = new Student1();
            s1.numer = 4;
            s1.imie = "Bartek";
            Console.WriteLine(s1.numer + " " + s1.imie);

            Student2 s2 = new Student2();
            s2.SetNumer(5);
            s2.SetImie("Maciej");
            Console.WriteLine(s2.GetNumer() + " " + s2.GetImie());

            Student3 s3 = new Student3();
            s3.Numer = 23;
            s3.Imie = "Adrian";
            Console.WriteLine(s3.Numer + " " + s3.Imie);

            Student4 s4 = new Student4();
            s4.Numer = 10;
            s4.Imie = "Mateusz";
            Console.WriteLine(s4.Numer + " " + s4.Imie);

            Pies p = new Pies();
            p.Name = "Hubert";
            p.Introduce();
            Wilk w = new Wilk();
            w.Name = "Piotrek";
            w.Introduce();
            */

            Polska p = new Polska("123-123-12-12");
            Console.WriteLine(p.NIP);

            Niemiecka n = new Niemiecka("12-12-123-123 ");
            Console.WriteLine(n.NIP);
            Console.ReadKey();
        }
    }
}
