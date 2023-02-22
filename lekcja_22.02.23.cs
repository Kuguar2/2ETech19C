using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
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
    class MyProgram
    {
        public static int Wieksza(int a,int b)
        {
            if (a > b) return a;
            else return b;
        }
        static void Main(string[] args)
        {
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

            Console.ReadKey();
        }
    }
}
