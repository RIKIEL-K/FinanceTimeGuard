using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace prjFinanceTime.Models.entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

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


        [Required]
        public DateTime CreatedAt { get; set; }


        public virtual ICollection<Transaction> Transactions { get; set; }
        public ICollection<Budget> Budgets { get; set; } = new List<Budget>();
        public ICollection<Alert> Alerts { get; set; } = new List<Alert>();
        public ICollection<Tache> Tasks { get; set; } = new List<Tache>();
        public ICollection<Report> Reports { get; set; } = new List<Report>();
        public virtual ICollection<Image> Images { get; set; } = new List<Image>();
    }
}
