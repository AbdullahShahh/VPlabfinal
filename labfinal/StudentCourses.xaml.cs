using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace YourNamespace
{
    public partial class StudentCourses : Window
    {
        private readonly YourDbContext _context;

        public StudentCourses()
        {
            InitializeComponent();
            _context = new YourDbContext(); // Initialize your DbContext
            LoadStudentCourses();
        }

        private void LoadStudentCourses()
        {
            var studentCourses = _context.StudentCourses
                .Select(sc => new
                {
                    StudentName = sc.Student.StudentName,
                    CourseName = sc.Course.CourseName
                }).ToList();

            StudentCoursesDataGrid.ItemsSource = studentCourses;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = SearchTextBox.Text.ToLower();

            var filteredStudentCourses = _context.StudentCourses
                .Where(sc => sc.Student.StudentName.ToLower().Contains(searchTerm) ||
                             sc.Course.CourseName.ToLower().Contains(searchTerm))
                .Select(sc => new
                {
                    StudentName = sc.Student.StudentName,
                    CourseName = sc.Course.CourseName
                }).ToList();

            StudentCoursesDataGrid.ItemsSource = filteredStudentCourses;
        }
    }
}
