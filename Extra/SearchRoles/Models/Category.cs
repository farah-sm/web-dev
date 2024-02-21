// Represents categories for jobs

using System.ComponentModel.DataAnnotations;

namespace SearchRoles.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
