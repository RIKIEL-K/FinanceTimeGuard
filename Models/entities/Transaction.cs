﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace prjFinanceTime.Models.entities
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
        public virtual User User { get; set; }


        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,4)")]
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public int CategorieID { get; set; }
        public virtual Categorie Categorie { get; set; }

        public DateTime date { get; set; }

        public string? Description { get; set; }


    }
}
