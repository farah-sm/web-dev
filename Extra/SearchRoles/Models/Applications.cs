using SearchRoles.Models;
using System.Collections.Generic;

// Represents applications submitted by users for specific job postings.

namespace SearchRoles.Models
{
    public class Application
    {
        public int Id { get; set; }
        // Composite key
        public int UserID { get; set; }
        public int JobID { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Job Job { get; set; }
    }
}
