using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        [Required]
        public DateTime MembershipDate { get; set; }
        public string Picture { get; set; }
        public IFormFile PictureFile { get; set; }

        public ICollection<Loan> Loans { get; set; } // Navigation property
        public ICollection<Fine> Fines { get; set; } // Navigation property
    }
}
