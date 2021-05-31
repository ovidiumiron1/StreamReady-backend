
using Microsoft.EntityFrameworkCore;
using StreamReady_backend.Models;

namespace StreamReady_backend.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Song> Songs { get; set; }
    }
}