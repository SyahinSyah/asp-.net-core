using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace MVCProject.Models.SchoolViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors{ get; set; }
        public IEnumerable<Course> Courses{ get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
