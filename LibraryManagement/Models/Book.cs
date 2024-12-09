using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        public Author Author { get; set; } // Navigation property

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; } // Navigation property

        [Required]
        public int PublishedYear { get; set; }

        [Required]
        public int AvailableCopies { get; set; }
        public string Picture { get; set; }
        public IFormFile PictureFile { get; set; }

        public ICollection<Loan> Loans { get; set; } // Navigation property
    }
}
