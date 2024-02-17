// Represents categories for jobs

using System.ComponentModel.DataAnnotations;

namespace JobSearch.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
