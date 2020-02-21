using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletedCourses.Model
{
    public static class DataLayer
    {
        static List<Course> CompletedCourse = new List<Course>();
        public static List<Course> GetCourses()
        {
            if (CompletedCourse.Count == 0)
            {
                CompletedCourse.Add(new Course { StudentID = "300111222", CourseCode = "COMP100", Title = "Programming I", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300111222", CourseCode = "COMP120", Title = "Programming II", Grade = GradeScheme.APlus, credit = 4, CompleteTime = "2019Winter" });
                CompletedCourse.Add(new Course { StudentID = "300222333", CourseCode = "COMP100", Title = "Programming I", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300222333", CourseCode = "COMP218", Title = "Java Programming", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300222333", CourseCode = "COMP214", Title = "Advanced Database", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300222333", CourseCode = "COMP229", Title = "Web Application", Grade = GradeScheme.CPlus, credit = 4, CompleteTime = "2019Summer" });

                CompletedCourse.Add(new Course { StudentID = "300333444", CourseCode = "COMP100", Title = "Programming I", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300333444", CourseCode = "COMP218", Title = "Java Programming", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300333444", CourseCode = "COMP214", Title = "Advanced Database", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300333444", CourseCode = "COMP212", Title = "Programming III", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Summer" });

                CompletedCourse.Add(new Course { StudentID = "300444555", CourseCode = "COMP100", Title = "Programming I", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300444555", CourseCode = "COMP218", Title = "Java Programming", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300444555", CourseCode = "COMP214", Title = "Advanced Database", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300444555", CourseCode = "COMP311", Title = "Testing", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Fall" });

                CompletedCourse.Add(new Course { StudentID = "300555666", CourseCode = "COMP100", Title = "Programming I", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300555666", CourseCode = "COMP218", Title = "Java Programming", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300555666", CourseCode = "COMP214", Title = "Advanced Database", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300555666", CourseCode = "COMP306", Title = "API programming", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Fall" });

                CompletedCourse.Add(new Course { StudentID = "300666777", CourseCode = "COMP100", Title = "Programming I", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300666777", CourseCode = "COMP218", Title = "Java Programming", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300666777", CourseCode = "COMP214", Title = "Advanced Database", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300666777", CourseCode = "COMP246", Title = "System Analysis", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Fall" });

                CompletedCourse.Add(new Course { StudentID = "300777888", CourseCode = "COMP100", Title = "Programming I", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300777888", CourseCode = "COMP218", Title = "Java Programming", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300777888", CourseCode = "COMP214", Title = "Advanced Database", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300777888", CourseCode = "COMP213", Title = "Web Interface Design", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Fall" });

                CompletedCourse.Add(new Course { StudentID = "300888999", CourseCode = "COMP100", Title = "Programming I", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300888999", CourseCode = "COMP218", Title = "Java Programming", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300888999", CourseCode = "COMP214", Title = "Advanced Database", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300888999", CourseCode = "COMP304", Title = "Mobile Application Development", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Fall" });

                CompletedCourse.Add(new Course { StudentID = "300999000", CourseCode = "COMP100", Title = "Programming I", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300999000", CourseCode = "COMP218", Title = "Java Programming", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300999000", CourseCode = "COMP214", Title = "Advanced Database", Grade = GradeScheme.A, credit = 4, CompleteTime = "2019Summer" });
                CompletedCourse.Add(new Course { StudentID = "300999000", CourseCode = "COMP254", Title = "Data Structure & Algorithms", Grade = GradeScheme.BPlus, credit = 4, CompleteTime = "2019Fall" });
            }

            return CompletedCourse;
        }

        public static ObservableCollection<Student> GetStudents()
        {

            ObservableCollection<Student> studentList = new ObservableCollection<Student>();
            studentList.Add(new Student { ID = "300111222", FirstName = "Lois", LastName = "Cortez", Email = "lcortez@my.centennialcollege.ca" });
            studentList.Add(new Student { ID = "300222333", FirstName = "Daria", LastName = "Rice", Email = "drice@my.centennialcollege.ca" });
            studentList.Add(new Student { ID = "300333444", FirstName = "Acton", LastName = "Keller", Email = "akeller@my.centennialcollege.ca" });
            studentList.Add(new Student { ID = "300444555", FirstName = "Galena", LastName = "Collier", Email = "gcollier@my.centennialcollege.ca" });
            studentList.Add(new Student { ID = "300555666", FirstName = "Nissim", LastName = "Mercer", Email = "nmercer@my.centennialcollege.ca" });
            studentList.Add(new Student { ID = "300666777", FirstName = "Edward", LastName = "Hayden", Email = "ehayden@my.centennialcollege.ca" });
            studentList.Add(new Student { ID = "300777888", FirstName = "Hop", LastName = "Carrillo", Email = "hcarrillo@my.centennialcollege.ca" });
            studentList.Add(new Student { ID = "300888999", FirstName = "Lisandra", LastName = "Clayton", Email = "lclayton@my.centennialcollege.ca" });
            studentList.Add(new Student { ID = "300999000", FirstName = "Nerea", LastName = "Fox", Email = "nfox@my.centennialcollege.ca" });

            return studentList;
        }
    }

}
