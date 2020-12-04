using Microsoft.EntityFrameworkCore;
using EdCentral.Domain;

namespace EdCentral.Infrastructure
{
    public class EdCentralContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=edCentral.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasOne(course => course.Company)
                .WithMany(company => company.Courses)
                .HasForeignKey(course => course.CompanyId);
        }
    }
}
