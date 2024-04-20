using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using BookOnShelf.Models;

namespace BookOnShelf.Data.Models
{
    
    [Table("Authors")]
    public class Authors
    {
        [Key]
        [Required]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Enter the authors first name")]
        [Column(TypeName = "nvarchar(50)")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Enter the authors date of birth")]
        [Column(TypeName = "date")]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        [ForeignKey("FkNationalityId")]
        public Nationality nationalityId { get; set; }
    }
}
