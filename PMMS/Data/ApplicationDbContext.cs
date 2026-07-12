using Microsoft.EntityFrameworkCore;
using PMMS.Models;

namespace PMMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        // This constructor passes configuration (like your connection string) to the base DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // These DbSets represent your actual SQL tables
        public DbSet<MediaItem> MediaItems { get; set; }
        public DbSet<WatchLog> WatchLogs { get; set; }
    }
}