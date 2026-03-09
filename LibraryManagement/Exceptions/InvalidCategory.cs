using System;

namespace LibraryManagement.Exceptions
{
    public class InvalidCategoryException : Exception
    {
        public InvalidCategoryException(string message) : base(message) { }
    }
}