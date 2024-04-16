using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BookOnShelf.Data;

namespace BookOnShelf.Data.Models
{
    [Table("BorrowedBooks")]
    //[Index(nameof(Book), nameof(User), IsUnique = true)]
    public class BorrowedBooks
    {
        [Key]
        [Required]
        public int BorrowedBookId { get; set; }

        [Required]
        [ForeignKey("FkBookId")]
        public Books Book { get; set; }

        [Required]
        [ForeignKey("FkUserId")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }
    }
}
