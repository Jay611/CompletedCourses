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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CompletedCourses.Model;
namespace CompletedCourses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Course> CompletedCourses;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource studentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            studentViewSource.Source = DataLayer.GetStudents();
            CompletedCourses = DataLayer.GetCourses();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Student student = studentDataGrid.SelectedItem as Student; 
            CompletedCoursesWindow window = new CompletedCoursesWindow(student, CompletedCourses);
            window.Show();
        }


    }
}
