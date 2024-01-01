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

namespace labfinal
{
    public partial class labfinal : Window
    {
        private readonly YourDbContext _context;

        public labfinal()
        {
            InitializeComponent();
            _context = new YourDbContext(); // Initialize your DbContext
            LoadCourses();
        }

        private void LoadCourses()
        {
            courseDataGrid.ItemsSource = _context.Courses.ToList();
        }

        private void AddCourse_Click(object sender, RoutedEventArgs e)
        {
            string courseName = courseNameTextBox.Text;
            int credits = int.Parse(creditsTextBox.Text); // Assuming credits are integers

            Course newCourse = new Course { CourseName = courseName, Credits = credits };

            _context.Courses.Add(newCourse);
            _context.SaveChanges();

            LoadCourses();
        }
    }

}
