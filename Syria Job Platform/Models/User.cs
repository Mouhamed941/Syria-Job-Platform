using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Syria_Job_Platform.Models
{
    public class User : IdentityUser
    {
        //[Key]  // Primary Key
        //public int Id { get; set; }

        //[Required]
        //[MaxLength(100)]
        //public string Username { get; set; }

        //[Required]
        //[EmailAddress]
        //public string Email { get; set; }

        //[Required]
        //public string PasswordHash { get; set; }

        //public string? Role { get; set; } // Admin, Employer, JobSeeker, etc.

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property - One user can apply to many jobs
        public List<JobApplication>? JobApplications { get; set; }
    }
}
