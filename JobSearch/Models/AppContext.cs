using Microsoft.EntityFrameworkCore;

namespace JobSearch.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        // DbSet properties represent database tables
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships between entities if needed
            modelBuilder.Entity<Application>()
                .HasKey(a => new { a.UserID, a.JobID }); // Composite key for Application entity
        }
    }
}
