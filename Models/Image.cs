using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prjFinanceTime.Models
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Path { get; set; }

        [NotMapped] //pas stocker dans la DB
        [Display(Name  = "Image")]
        //represente le fichier stocké sur la DBA
        public IFormFile file { get; set; }
        public virtual User User { get; set; }

        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
    }
}
