using System;

namespace LibraryManagement.Exceptions
{
    public class BookAlreadyIssuedException : Exception
    {
        public BookAlreadyIssuedException(string message) : base(message) { }
    }
}