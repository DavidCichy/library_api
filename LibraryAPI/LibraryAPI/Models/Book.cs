using System;

namespace LibraryAPI.Models
{
    public class Book
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public Author Author { set; get; }
        public DateTime ReleaseDate { set; get; }
    }
}