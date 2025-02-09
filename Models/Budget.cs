using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prjFinanceTime.Models
{
    public class Budget
    {
        [Key]
        public int BudgetID { get; set; }

        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
        [Required]
        public int CategoryID { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal MonthlyLimit { get; set; }

        public virtual User User { get; set; }

    }
}
