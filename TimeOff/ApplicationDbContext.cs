using Microsoft.EntityFrameworkCore;
using TimeOff.Models;
namespace TimeOff;

public class ApplicationDbContext : DbContext
{
    public DbSet<TimeOffRequest> TimeOffRequests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the SQL Server connection string
       // optionsBuilder.UseSqlServer("your_connection_string_here");
    }
}
