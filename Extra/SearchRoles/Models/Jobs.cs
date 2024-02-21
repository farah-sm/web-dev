using System.ComponentModel.DataAnnotations;

namespace SearchRoles.Models
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public decimal Salary { get; set; }
    }
}
