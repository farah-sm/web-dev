using System.Collections.Generic;

namespace Website.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string? GradeName { get; set; } // Mark as nullable
        public string? Section { get; set; } // Mark as nullable
        public ICollection<Student>? Students { get; set; } // Mark as nullable
    }
}
