using System;
using System.Collections.Generic;
using System.Linq;
using LibraryManagement.Models;
using LibraryManagement.Services;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", "Fiction"),
            new Book(2, "A Brief History of Time", "Stephen Hawking", "Science"),
            new Book(3, "The Art of Computer Programming", "Donald Knuth", "Technology"),
            new Book(4, "Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "History"),
            new Book(5, "Steve Jobs", "Walter Isaacson", "Biography")
        };

        Console.WriteLine("All Books:");

        var sortedBooks = books.OrderBy(b => b.Title).ToList();

        Console.WriteLine("Sorted Books:");
        foreach (var book in sortedBooks)
        {
            Console.WriteLine($"ID:{book.BookId}, Title:{book.Title}, Author:{book.Author}, Category:{book.Category}, Available:{book.IsAvailable}");
        }
        
        var availableBooks = books.Where(b => b.IsAvailable).ToList();

        Console.WriteLine("Available Books:");
        foreach (var book in availableBooks)
        {
            Console.WriteLine($"ID:{book.BookId}, Title:{book.Title}, Author:{book.Author}");
        }

        var categoryBooks = books.GroupBy(b => b.Category);

        Console.WriteLine("Books by Category:");
        foreach (var group in categoryBooks)
        {
            Console.WriteLine($"Category: {group.Key}");
            foreach (var book in group)
            {
                Console.WriteLine($"{book.Title} - {book.Author}");
            }
        }

        var issuedCount = books.Count(b => !b.IsAvailable);
        Console.WriteLine($"Number of issued books: {issuedCount}");

        var topAuthors = books.GroupBy(b => b.Author)
                              .Select(g => new { Author = g.Key, Count = g.Count() })
                              .OrderByDescending(g => g.Count)
                              .Take(3)
                              .ToList();

        Console.WriteLine("Top 3 Authors with Most Books:");
        foreach (var author in topAuthors)
        {
            Console.WriteLine($"Author: {author.Author}, Books: {author.Count}");
        }

        // LibraryServiceImpl impl = new LibraryServiceImpl();
    }
}