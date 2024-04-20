using BookOnShelf.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookOnShelf.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? MiddleName { get; set; } = null;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Surname { get; set; }


        [ForeignKey("FkAddressId")]
        public Addresses Address { get; set; }
    }

}
