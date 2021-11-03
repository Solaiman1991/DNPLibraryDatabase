using System;
using Library.Models;
using Library.Persistence;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddBookGenreAuthor();

        }

        private static void AddBookGenreAuthor()
        {
            Genre g = new Genre
            {
                GenreName = "High Fantasy"
            };
            Author a = new Author
            {
                FirstName = "Brandon",
                LastName = "Sanderson",
                Bio = "I write good stuff"
            };
            Book b = new Book
            {
                Author = a,
                Genre = g,
                Title = "The Way of Kings",
                ISBN = 0765326353,
                PublishDate = new DateTime(2010, 7, 31),
                TotalPage = 1007
            };
            using (LibraryContext lb = new LibraryContext())
            {
                lb.Books.Add(b);
                lb.SaveChanges();
            }

        }

    }
}