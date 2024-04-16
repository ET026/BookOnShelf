using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BookOnShelf.Data.Models
{
    [Table("Languages")]
    [Index(nameof(LanguageName), IsUnique = true)]
    public class Languages
    {
        [Key]
        [Required]
        public int LanguageId { get; set; }

        [Required]
        public string LanguageName { get; set; }
    }
}