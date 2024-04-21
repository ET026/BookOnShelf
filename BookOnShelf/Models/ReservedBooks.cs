using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BookOnShelf.Data;
using BookOnShelf.Data.Models;

namespace BookOnShelf.Models
{
    public class ReservedBooks
    {
        [Key]
        [Required]
        public int ReservedId { get; set; }

        [Required]
        [ForeignKey("FkBookId")]
        public Books Book { get; set; }

        [Required]
        [ForeignKey("FkUserId")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime ReservedDate { get; set; }

        public DateTime? ReservedUntil { get; set; }
    }
}
