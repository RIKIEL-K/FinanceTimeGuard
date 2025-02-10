using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prjFinanceTime.Models.entities
{
    public enum ExpenseCategory
    {
        Housing,
        Food,
        Transport,
        Entertainment,
        Health,
        Education,
        Clothing,
        Taxes,
        Insurance,
        Services,
        Communication,
        Gifts,
        Savings,
        Miscellaneous
    }
    public enum AlertStatus
    {
        Active,
        Resolved,
        Dismissed
    }
    public class Alert
    {
        [Key]
        public int AlertID { get; set; }

        [ForeignKey(nameof(User))]
        [Required]
        public int UserID { get; set; }

        [Required]
        public int CategoryID { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public AlertStatus? Status { get; set; } = AlertStatus.Active;

        public virtual User User { get; set; }
        public ExpenseCategory? Category { get; set; }

    }
}
