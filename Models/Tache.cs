using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prjFinanceTime.Models
{
    public class Tache
    {
        [Key]
        public int TaskID { get; set; }

        [ForeignKey(nameof(User))]
        [Required]
        public int UserID { get; set; }
        public string Title { get; set; }

        public virtual User User { get; set; }
    }
}
