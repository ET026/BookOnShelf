using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookOnShelf.Data.Models
{
    [Table("Fines")]
    public class Fines
    {
        [Key]
        [Required]
        public int FineId { get; set; }

        [Required]
        [ForeignKey("FkBorrowId")]
        public BorrowedBooks Borrow { get; set; }

        [Required]
        public double Amount { get; set; }

        [Display(Name = "IsPayed")]
        public DateTime? IsPayed { get; set; } = null;
    }
}
