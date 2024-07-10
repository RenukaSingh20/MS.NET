using Microsoft.EntityFrameworkCore;
using StudentDetailsApp.Entities;
namespace StudentDetailsApp.Repositories
{ 
    public class Studentcontext:DbContext
    {
       public DbSet<Student> dbcontext {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"server=localhost;port=3306;user=root;password=Champion007;database=mydata";
            optionsBuilder.UseMySQL(conString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.Student_Id);
                entity.Property(s => s.Mobile_Number).IsRequired();
                entity.HasIndex(s => s.Student_EmailId).IsUnique();
            });
            modelBuilder.Entity<Student>().ToTable("student");
        }
    }
}
