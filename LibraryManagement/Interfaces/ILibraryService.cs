using LibraryManagement.Models;
using LibraryManagement.Models;

namespace LibraryManagementSystem.Core.Interfaces
{
    public interface ILibraryService
    {
        void AddBook(Book book);
        void RemoveBook(int bookId);
        void IssueBook(int bookId);
        void ReturnBook(int bookId);
        void DisplayBooks();
    }
}