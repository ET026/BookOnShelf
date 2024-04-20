using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BookOnShelf.Models
{
    public class Nationality
    {
        [Key]
        [Required]
        public int NationalityId { get; set; }

        [Required(ErrorMessage = "Enter the nationality")]
        [Column(TypeName = "nvarchar(50)")]
        public string NationalityName { get; set; }
    }
}
