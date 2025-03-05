using Microsoft.EntityFrameworkCore;
using Syria_Job_Platform.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace Syria_Job_Platform
{
    public class ApplicationDbContext : IdentityDbContext<User,IdentityRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Define DbSet properties for each table in your database
        //public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        // Add more tables here as needed

        public DbSet<JobApplication> JobApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ensure Identity is configured correctly
            base.OnModelCreating(modelBuilder); // **This is important!**

            // Define relationships
            modelBuilder.Entity<JobApplication>()
                .HasOne(j => j.User)
                .WithMany(u => u.JobApplications)
                .HasForeignKey(j => j.UserId)
                .OnDelete(DeleteBehavior.NoAction); // or DeleteBehavior.SetNull

            modelBuilder.Entity<JobApplication>()
                .HasOne(j => j.Job)
                .WithMany(j => j.Applications)
                .HasForeignKey(j => j.JobId)
            .OnDelete(DeleteBehavior.NoAction);  // Keep cascade delete for Jobs

            modelBuilder.Entity<Job>()
            .Property(j => j.Salary)
            .HasColumnType("decimal(18,2)"); // Y
            }
    }
}


