using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BookOnShelf.Data.Models
{

    [Table("Addresses")]
    [Index(nameof(PostalCode), IsUnique = true)]
    public class Addresses
    {
        [Key]
        [Required]
        public int AddressId { get; set; }

        [Required(ErrorMessage = "Please enter the city you live in!")]
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter your street name")]
        [Column(TypeName = "nvarchar(50)")]
        public string Street { get; set; }

        [Required (ErrorMessage = "Enter your house number!")]
        public int Number { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string? NumberAddition { get; set; } = null;

        [Required (ErrorMessage = "Enter a postal code!")]
        [Column(TypeName = "nvarchar(10)")]
        public string PostalCode { get; set; }

    }
}
