using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletedCourses.Model
{
    public class Course
    {
        public string StudentID { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public string CompleteTime { get; set; }
        public float credit { get; set; }
        public GradeScheme Grade { get; set; }
    }
}
