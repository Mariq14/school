using Microsoft.AspNetCore.Identity;

namespace SchoolSystem.Data
{
    public class Student : IdentityUser
    {
        //public int ID {get; set;}
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
