using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Data
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        //DisplayFormat(NullDisplayText= "No grade")
        //
        public int CourseId { get; set; }
        public Course Courses { get; set; }

        public string StudentId { get; set; }      
        public Student Students { get; set; }

    }
}
