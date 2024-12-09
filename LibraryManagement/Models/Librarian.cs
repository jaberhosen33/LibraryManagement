using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class Librarian
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibrarianID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
        public string Picture { get; set; }
        public IFormFile PictureFile { get; set; }

        [Required]
        public DateTime HireDate { get; set; }
    }
}
