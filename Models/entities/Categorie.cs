using System.ComponentModel.DataAnnotations;

namespace prjFinanceTime.Models.entities
{
    public enum Type
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
        Others
    }
    public class Categorie
    {
        [Required]
        public int UserID { get; set; }

        [Key]
        public int CategorieID { get; set; }

        public Type? Type { get; set; }

    }
}
