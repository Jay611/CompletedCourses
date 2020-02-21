using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CompletedCourses.Model;
namespace CompletedCourses
{
    /// <summary>
    /// Interaction logic for CompletedCoursesWindow.xaml
    /// </summary>
    public partial class CompletedCoursesWindow : Window
    {
        private Student student;
        System.Windows.Data.CollectionViewSource courseViewSource;
        List<Course> CompletedCourses;
        List<Course> CompletedCourse;
        public CompletedCoursesWindow(Student student, List<Course> CompletedCourses)
        {
            InitializeComponent();
            this.student = student;
            studentInfoGrid.DataContext = student;
            this.CompletedCourses = CompletedCourses;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            courseViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("courseViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            CompletedCourse = DataLayer.GetCourses().Where(c => c.StudentID == student.ID).ToList();
            courseViewSource.Source = CompletedCourse;
            gradeComboBox.ItemsSource = Enum.GetValues(typeof(GradeScheme)).Cast<GradeScheme>();
        }

        private void Back2Main_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddCourse_Click(object sender, RoutedEventArgs e)
        {
            Course newCourse = new Course {
                StudentID = student.ID,
                CourseCode = courseCodeTextBox.Text,
                Title = titleTextBox.Text,
                credit = float.Parse(creditTextBox.Text),
                Grade = (GradeScheme) Enum.Parse(typeof(GradeScheme), gradeComboBox.SelectedItem.ToString()),
                CompleteTime = completeTimeTextBox.Text,
            };
            CompletedCourses.Add(newCourse);
            courseDataGrid.Items.Refresh();
            CompletedCourse = DataLayer.GetCourses().Where(c => c.StudentID == student.ID).ToList();
            courseViewSource.Source = CompletedCourse;
        }
    }
}
