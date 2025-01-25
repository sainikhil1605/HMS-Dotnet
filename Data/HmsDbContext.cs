
using HMS_Dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace HMS_Dotnet.Data
{
    public class HmsDbContext : DbContext
    {
        public HmsDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }

    }
}