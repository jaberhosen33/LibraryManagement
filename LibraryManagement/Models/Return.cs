using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Return
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReturnID { get; set; }

        [ForeignKey("Loan")]
        public int LoanID { get; set; }
        public Loan Loan { get; set; } // Navigation property

        [Required]
        public DateTime ReturnDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Condition { get; set; }
    }
}
