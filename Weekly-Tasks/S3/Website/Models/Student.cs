using System;

namespace Website.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string? StudentName { get; set; } // Mark as nullable
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public Grade? Grade { get; set; } // Mark as nullable
    }
}
