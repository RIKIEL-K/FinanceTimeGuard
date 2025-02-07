using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prjFinanceTime.Models
{
    public class Image
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Path { get; set; }

        [NotMapped] //pas stocker dans la DB
        [Display(Name  = "Image")]
        //represente le fichier stocké sur la DBA
        public IFormFile file { get; set; }
        public virtual User user { get; set; }

        public int FruitId { get; set; }
    }
}
