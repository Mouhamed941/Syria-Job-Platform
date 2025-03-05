using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Syria_Job_Platform.Models
{
    public class Job
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public string EmployerId { get; set; }  // Foreign Key

        [ForeignKey("EmployerId")]
        public User? Employer { get; set; } // Navigation Property

        public DateTime PostedAt { get; set; } = DateTime.UtcNow;

        // Navigation property - One job can have many applications
        public List<JobApplication>? Applications { get; set; }
    }
}
