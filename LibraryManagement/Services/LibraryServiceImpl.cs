using System.Collections.Generic;
using System.Linq;
using LibraryManagement.Models;
using LibraryManagement.Exceptions;

namespace LibraryManagement.Services
{
    public class LibraryServiceImpl
    {
        private static LibraryServiceImpl instance;
        public static LibraryServiceImpl Instance
        {
            get
            {
                if (instance == null)
                    instance = new LibraryServiceImpl();

                return instance;
            }
        }
        private List<Book> books = new List<Book>();

        private LibraryServiceImpl() { }
        public void AddBook(Book book)
        {
            if (books.Any(b => b.BookId == book.BookId))
                throw new System.Exception("Book already exists");

            books.Add(book);
        }
        public void IssueBook(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            

            if (book == null)
                throw new BookNotFoundException("Book not found");

            if (!book.IsAvailable)
                throw new BookAlreadyIssuedException("Book already issued");

            book.IsAvailable = false;
        }

        public void RemoveBook(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);

            if (book == null)
                throw new BookNotFoundException("Book not found");

            books.Remove(book);
        }
        
       
    }
}