using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Data
{
    public class SchoolDbContext : IdentityDbContext <Student>
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options) 
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
