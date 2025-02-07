using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace prjFinanceTime.Models
{
    public class User
    {
        public int UserId {  get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Name")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "email")]
        [EmailAddress]
        public string UserEmail { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "password")]
        [PasswordPropertyText]
        public string Password { get; set; }

        [StringLength(50 , MinimumLength = 5)]
        [Required]
        [Display(Name = "createdAt")]
        public DateTime createdAt  { get; set; }
        public virtual Image Image { get; set; }
    }
}
