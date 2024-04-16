using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookOnShelf.Data.Models
{
    [Table("BooksWriters")]
    //[Index(nameof(Book), nameof(Author), IsUnique = true)]
    public class BooksWriters
    {
        [Key]
        [Required]
        public int BookWriterId { get; set; }

        [ForeignKey("FkBookId")]
        public Books Book { get; set; }

        [ForeignKey("FkAuthorId")]
        public Authors Author { get; set; }
    }
}
