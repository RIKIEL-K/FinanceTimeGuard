using System.Data.Entity;
using prjFinanceTime.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace prjFinanceTime.Data

{
    public class AppDbContext : DbContext
    {
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Tache> Tasks { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
