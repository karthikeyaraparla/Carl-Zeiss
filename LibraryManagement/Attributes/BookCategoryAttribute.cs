using System;

namespace LibraryManagement.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BookCategoryAttribute : Attribute
    {
        public static readonly string[] AllowedCategories =
        {
            "Fiction",
            "Science",
            "Technology",
            "History",
            "Biography"
        };
    }
}