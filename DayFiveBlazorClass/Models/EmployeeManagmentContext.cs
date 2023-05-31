using Microsoft.EntityFrameworkCore;

namespace DayFiveBlazorClass.Models
{
    public class EmployeeManagmentContext:DbContext
    {
        public EmployeeManagmentContext(DbContextOptions<EmployeeManagmentContext> opts):base(opts) 
        {
            
        }
        public DbSet<Company> Companies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company()
                {
                    Id = 1,
                    Name = "Default Company",
                    City = "Addis Ababa",
                    Country = "Ethiopia"
                });
        }
    }
}
