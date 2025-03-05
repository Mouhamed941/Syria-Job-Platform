using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Syria_Job_Platform.Models
{
    public class JobApplication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }  // Foreign Key to User

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Required]
        public int JobId { get; set; }  // Foreign Key to Job

        [ForeignKey("JobId")]
        public Job? Job { get; set; }

        public string Status { get; set; } = "Pending"; // Pending, Accepted, Rejected

        public DateTime AppliedAt { get; set; } = DateTime.UtcNow;
    }
}
