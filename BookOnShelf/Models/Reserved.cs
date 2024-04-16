using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BookOnShelf.Data;
using Microsoft.EntityFrameworkCore;

namespace BookOnShelf.Data.Models
{
    [Table("Reserved")]
    //[Index(nameof(Book), nameof(User), IsUnique = true)]
    public class Reserved
    {
        [Key]
        [Required]
        public int ReservedId { get; set; }

        
        [ForeignKey("BookId")]
        public Books Book {get; set; }

   

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime ReservedDate { get; set; }

        public DateTime? IsCanceled { get; set; } = null;
    }
}
