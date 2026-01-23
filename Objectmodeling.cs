using System;
using System.Collections.Generic;

namespace Objectmodeling
{
    class Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }

    class Library
    {
        public string Name;
        public List<Book> Books = new List<Book>();

        public Library(string name)
        {
            Name = name;
        }
    }

    class Program
    {
        static void Main()
        {
            Book b1 = new Book("Harry Potter", "J.K. Rowling");
            Book b2 = new Book("5 AM Club", "Robin Sharma");

            Library l1 = new Library("Central Library");
            Library l2 = new Library("College Library");

            l1.Books.Add(b1);
            l2.Books.Add(b2);

            Console.WriteLine($"{l1.Name} books are : ");
            foreach (Book b in l1.Books){
                b.Display();
            }
            Console.WriteLine($"{l2.Name} books are : ");
            foreach (Book b in l2.Books){
                b.Display();
            }
        }
    }
}
