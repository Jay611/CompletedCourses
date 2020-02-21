using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using CompletedCourses.Model;
namespace CompletedCourses
{
    class PlusToSymbolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string grade = (string) Enum.GetName(typeof(GradeScheme), value);
            if (grade.Substring(1).ToString().ToLower() == "plus")
                return grade[0] + "+";
            return grade;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
