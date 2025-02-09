using prjFinanceTime.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace prjFinanceTime.Data

{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Image>()
                .HasOne(i => i.User)  // Une Image a un User
                .WithMany(u => u.Images)  // Un User a plusieurs Images
                .HasForeignKey(i => i.UserID)  // Clé étrangère
                .OnDelete(DeleteBehavior.Cascade); // Si l'utilisateur est supprimé, les images le sont aussi
        }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Tache> Tasks { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


    }
}
