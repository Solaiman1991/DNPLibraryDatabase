using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace Library.Models
{
    public class Book
    {
        public Genre Genre { get; set; }
        public Author Author { get; set; }
        
        [Key] 
        public int ISBN { get; set; }
        public string Title { get; set; }
        public int TotalPage { get; set; }
        public DateTime PublishDate { get; set; }
    }
}