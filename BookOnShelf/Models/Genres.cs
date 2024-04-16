using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BookOnShelf.Data.Models
{
    [Table("Genres")]
    [Index(nameof(GenreName), IsUnique = true)]
    public class Genres
    {
        [Key]
        [Required]
        public int GenreId { get; set; }

        [Required]
        public string GenreName { get; set; }
    }
}
