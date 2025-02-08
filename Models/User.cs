using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace prjFinanceTime.Models
{
    public class User
    {
        public int UserID {  get; set; }

        [StringLength(50)]

        [Display(Name = "Name")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "email")]
        [EmailAddress]
        public string UserEmail { get; set; }

        [StringLength(50)]
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }

        [StringLength(50 , MinimumLength = 5)]
        [Required]
        public DateTime CreatedAt  { get; set; }
        public virtual Image Image { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
