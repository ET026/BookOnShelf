using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BookOnShelf.Data.Models
{
    [Table("Books")]
    [Index(nameof(ISBNNumber), IsUnique = true)]
    public class Books
    {
        [Key]
        [Required]
        [Display(Name = "BookId")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please Enter a title!")]
        [Column(TypeName = "nvarchar(25)")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter ISBN number!")]
        [Column(TypeName = "nvarchar(13)")]
        public string ISBNNumber { get; set; }

        [Required(ErrorMessage = "Please enter the amount of page's!")]
        [Range(1, 10000, ErrorMessage = "Please enter a number between 1 and 10000")]
        public int BookPages { get; set; }

        [Required(ErrorMessage = "Please enter the the Quantity of the book!")]
        [Range(1, 1000, ErrorMessage = "Please enter a number between 1 and 1000")]
        public int BookQuantity { get; set; }

        [Required(ErrorMessage = "Please enter a description!")]
        [Column(TypeName = "nvarchar(300)")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the file for the front cover!")]
        [Column(TypeName = "nvarchar(255)")]
        public string FrontCover { get; set; }

        [Required(ErrorMessage = "Please choose a genre")]
        [ForeignKey("FkGenreId")]
        public Genres Genre{ get; set; }

        [Required(ErrorMessage = "Please choose a language")]
        [ForeignKey("FkLanguageId")]
        public Languages Language { get; set; }

    }
}
