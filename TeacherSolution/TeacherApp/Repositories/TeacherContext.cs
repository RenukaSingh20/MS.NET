
using Microsoft.EntityFrameworkCore;
using TeacherApp.Entities;
namespace TeacherApp.Repositories
{
    public class TeacherContext:DbContext
    {
        public DbSet<Teacher> teachers {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"server =localhost;port=3306;user=root;password=Champion007;database=ecommerce";
            optionsBuilder.UseMySQL(conString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.email).IsRequired();
                entity.Property(e => e.phone).IsRequired();
            });
            modelBuilder.Entity<Teacher>().ToTable("teachers");


            
        }
    }
}
