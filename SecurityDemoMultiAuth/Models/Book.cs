using System;
using System.Collections.Generic;

#nullable disable

namespace SecurityDemoMultiAuth.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }
}
