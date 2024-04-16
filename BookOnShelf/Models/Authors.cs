using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BookOnShelf.Data.Models
{
    
    [Table("Authors")]
    [Index(nameof(FirstName), nameof(LastName), IsUnique = true)]
    public class Authors
    {
        [Key]

        public int AuthorId { get; set; }

        [Required (ErrorMessage = "Enter the authors first name")]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? MiddleName { get; set; } = null;

        [Required(ErrorMessage = "Enter the authors last name")]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter the authors date of birth")]
        [Column (TypeName = "date")]
        public DateOnly DateOfBirth { get; set; }

        [Required(ErrorMessage = "Enter the authors nationality")]
        [Column(TypeName = "nvarchar(50)")]
        public string Nationality { get; set; }
    }
}
