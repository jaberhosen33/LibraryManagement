using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Loan
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanID { get; set; }

        [ForeignKey("Book")]
        public int BookID { get; set; }
        public Book Book { get; set; } // Navigation property

        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public Member Member { get; set; } // Navigation property

        [Required]
        public DateTime LoanDate { get; set; }

        [Required]
        public DateTime CommitedReturnDate { get; set; }

        public Return Return { get; set; } // Navigation property

    }
}
