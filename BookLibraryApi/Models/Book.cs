using System;
using System.Collections.Generic;

namespace BookLibraryApi.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Year { get; set; }

    }
}
