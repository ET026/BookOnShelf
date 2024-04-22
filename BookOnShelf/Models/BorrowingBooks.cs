using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BookOnShelf.Data;
using BookOnShelf.Data.Models;

namespace BookOnShelf.Models
{
    public class BorrowingBooks
    {
        [Key]
        [Required]
        public int BorrowingId { get; set; }

        [Required]
        [ForeignKey("FkUserId")]
        public ApplicationUser User { get; set; }

        [Required]
        [ForeignKey("FkBookId")]
        public Books books { get; set; }

        [Required]
        public DateTime LendStartDate { get; set; }

        [Required]
        public DateTime LendEndDate { get; set; }

    }
}
