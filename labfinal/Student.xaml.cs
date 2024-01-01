using System.Collections.ObjectModel;
using System.Windows;

namespace YourNamespace
{
    public partial class Student : Window
    {
        private readonly DatabaseHandler _dbHandler;

        public Student()
        {
            InitializeComponent();
            _dbHandler = new DatabaseHandler(); // Initialize your DatabaseHandler
            LoadStudents();
        }

        private void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>(_dbHandler.GetStudents());
            studentsDataGrid.ItemsSource = students;
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            string studentName = studentNameTextBox.Text;
            _dbHandler.AddStudent(studentName);
            LoadStudents();
        }
    }
}
