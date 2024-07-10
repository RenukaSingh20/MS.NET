using Microsoft.EntityFrameworkCore;
using ProductApp.Entities;
namespace ProductApp.Repositories
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"server=localhost;port=3306;user=root;password=Champion007;database=ecommerce";
            optionsBuilder.UseMySQL(conString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.title).IsRequired();
                entity.Property(e => e.description).IsRequired();
                entity.Property(e => e.unitprice).IsRequired();
        });
            modelBuilder.Entity<Product>().ToTable("products");
        }
    }
}
