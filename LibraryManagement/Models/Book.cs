using LibraryManagement.Attributes;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [BookCategory]
        public string Category { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Book(int id, string title, string author, string category)
        {
            BookId = id;
            Title = title;
            Author = author;
            Category = category;
        }

        public static bool operator ==(Book a, Book b)
        {
            return a.BookId == b.BookId;
        }

        public static bool operator !=(Book a, Book b)
        {
            return a.BookId != b.BookId;
        }

        public override bool Equals(object obj)
        {
            if (obj is Book other)
                return BookId == other.BookId;
            return false;
        }
        
    }
}