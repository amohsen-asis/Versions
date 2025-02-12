using Microsoft.EntityFrameworkCore;

namespace MyWebApiProject.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasColumnType("decimal(18,2)"); // Specify precision and scale
        }

        public static void SeedData(ApplicationDbContext context)
        {
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee { Name = "John Doe", Position = "Software Engineer", Salary = 60000 },
                    new Employee { Name = "Jane Smith", Position = "Project Manager", Salary = 80000 },
                    new Employee { Name = "Mike Johnson", Position = "Data Analyst", Salary = 55000 }
                );
                context.SaveChanges();
            }
        }
    }
}
