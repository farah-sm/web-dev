using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SearchRoles.Models
{
    public class SearchJContext : DbContext
    {
        public SearchJContext(DbContextOptions<SearchJContext> options) : base(options)
        {
        }

        // DbSet properties represent database tables
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }


    }
}
