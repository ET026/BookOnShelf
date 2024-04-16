using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BookOnShelf.Data;
using Microsoft.EntityFrameworkCore;

namespace BookOnShelf.Data.Models
{
    [Table("UsersExtended")]
    //[Index(nameof(ApplicationUser.UserName), IsUnique = true)]
    public class UsersExtended
    {
        [Key]
        public int UsersExtendedId { get; set; }

        [Required]
        [ForeignKey("FkUserId")]
        public ApplicationUser User { get; set; } 

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? UserMiddleName{ get; set; } = null;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string UserSurname { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        [ForeignKey("FkAddressId")]
        public Addresses Address { get; set; }

    }
}
