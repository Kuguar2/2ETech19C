using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class User
    {
        public int id;
        private string Name;
        public void Verify()
        {
            Console.WriteLine("metoda verify z klasy User");
        }
        public void Checkaccount()
        {
            Console.WriteLine("metoda check account z klasy User");
        }
        public void GetBookInfo()
        {
            Console.WriteLine("metoda get book info z klasy User");
        }
    }
    class Book
    {
        public string Title;
        public string Author;
        private int ISBN;
        public int Publication;
        public Librarian librarian;
        public Library_Managment_System management;
        public void Show_duedt()
        {
            Console.WriteLine("Metoda show duedt z klasy book");
        }
        private void Reservation_status()
        {
            Console.WriteLine("Metoda reservation status z klasy book");
        }
        private void Feedback()
        {
            Console.WriteLine("Metoda feedback z klasy book");
        }
        public void Book_request()
        {
            Console.WriteLine("Metoda Book request z klasy book");
        }
        public void Renw_info()
        {
            Console.WriteLine("Metoda renw info z klasy book");
        }
    }
    class Librarian
    {
        public string Name;
        private string ID;
        public int Password;
        public int SearchString;
        public library_database library;
        public Library_Managment_System System;
        private void Verify_librarian()
        {
            Console.WriteLine("Metoda verify librarian z klasy librarian");
        }
        public void Search()
        {
            Console.WriteLine("Metoda Search z klasy librarian");
        }
    }
    class library_database
    {
        public string List_of_books;
        public void Add()
        {
            Console.WriteLine("Metoda add z klasy library database");
        }
        private void Delete()
        {
            Console.WriteLine("Metoda delete z klasy library database");
        }
        public void Update()
        {
            Console.WriteLine("Metoda update z klasy library database");
        }
        private void Display()
        {
            Console.WriteLine("Metoda display z klasy library database");
        }
        public void Search()
        {
            Console.WriteLine("Metoda search z klasy library database");
        }
    }
    class Library_Managment_System
    {
        public int UserType;
        public string UserName;
        private int Password;
        public void login()
        {
            Console.WriteLine("Metoda login z klasy library managment system");
        }
        private void Register()
        {
            Console.WriteLine("Metoda register z klasy library managment system");
        }
        public void Logout()
        {
            Console.WriteLine("Metoda logout z klasy library managment system");
        }
    }
    
    class Account
    {
        public string no_borrowed_books;
        private string no_lost_books;
        public string no_returned_books;
        public void Calculate_fine()
        {
            Console.WriteLine("metoda calculate fine z klasy User");
        }
    }
    class Staff
    {
        public string dept;
    }
    class Student
    {
        public string Class;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "To";
            book.Author = "Stephen King";
            book.Book_request();
            book.Renw_info();


            book.librarian = new Librarian();
            book.librarian.Name = "Jerzy";
            book.librarian.Password = 1;
            book.librarian.Search();

            Librarian librarian = new Librarian();

            librarian.library = new library_database();

            librarian.library.List_of_books = "yes";
            librarian.library.Add();
            librarian.library.Update();
            librarian.library.Search();


            book.management = new Library_Managment_System();
            book.management.login();
            book.management.Logout();

            librarian.System = new Library_Managment_System();
            librarian.System.login();
            librarian.System.Logout();

            Console.ReadKey();
        }
    }
}

