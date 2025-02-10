using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace prjFinanceTime.Models
{
    public class AddUserViewModels
    {

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

    }
}
