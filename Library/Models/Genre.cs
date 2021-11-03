
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Genre
    {
        [Key,MaxLength(7)]
        public int GenreId { get; set; }
        public string GenreName { get; set; }

    }
}
