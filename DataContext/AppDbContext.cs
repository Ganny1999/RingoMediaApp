using Microsoft.EntityFrameworkCore;
using RingoMediaProject.DomainModel.Models;

namespace RingoMediaProject.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
    }
}
