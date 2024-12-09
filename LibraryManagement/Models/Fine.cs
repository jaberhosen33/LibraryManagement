using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Fine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FineID { get; set; }

        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public Member Member { get; set; } // Navigation property

        [ForeignKey("Loan")]
        public int LoanID { get; set; }
        public Loan Loan { get; set; } // Navigation property

        [Required]
        [Range(0, double.MaxValue)]
        public decimal FineAmount { get; set; }

        [Required]
        [StringLength(100)]
        public string FineReason { get; set; }

        [Required]
        [StringLength(20)]
        public string PaidStatus { get; set; }
    }
}
