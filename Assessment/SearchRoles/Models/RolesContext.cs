using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SearchRoles.Models
{
    public class RolesContext : IdentityDbContext<IdentityUser>
    {
        public RolesContext(DbContextOptions<RolesContext> options) : base(options)
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
            // This is crucial for the IdentityEntityFrameworkCore to update the DB
            base.OnModelCreating(modelBuilder);
            // Configure relationships between entities if needed
            modelBuilder.Entity<Application>()
                .HasKey(a => new { a.UserID, a.JobID }); // Composite key for Application entity

        }
    }
}
