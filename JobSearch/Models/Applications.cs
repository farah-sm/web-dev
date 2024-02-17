// Represents applications submitted by users for specific job postings.

namespace JobSearch.Models
{
    public class Application
    {
        // Composite key
        public int UserID { get; set; }
        public int JobID { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Job Job { get; set; }
    }
}
