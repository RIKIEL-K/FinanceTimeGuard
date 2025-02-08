using System.ComponentModel.DataAnnotations;

namespace prjFinanceTime.Models
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
        public int UserID { get; set; }

        [Required]
        public int CategorieID { get; set; }

        public Type ? Type { get; set; }
       
    }
}
