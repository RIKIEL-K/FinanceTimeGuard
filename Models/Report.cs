using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prjFinanceTime.Models
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }

        [ForeignKey(nameof(User))]
        [Required]
        public int UserID { get; set; }
        public string Title { get; set; }
        public DateTime GeneratedAt { get; set; } = DateTime.Now;

        public virtual User User { get; set; }
    }
}
