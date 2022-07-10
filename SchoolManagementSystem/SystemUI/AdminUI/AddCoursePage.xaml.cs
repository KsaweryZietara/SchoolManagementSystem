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
using SystemLibrary.DataAccess;
using SystemLibrary.StudentAccountModels;
using SystemLibrary.TeacherAccountModels;

namespace SystemUI.AdminUI {
    /// <summary>
    /// Logika interakcji dla klasy AddCoursePage.xaml
    /// </summary>
    public partial class AddCoursePage : Page {

        public List<TeacherModelSA> Teachers { get; set; } = new List<TeacherModelSA>();

        public List<StudentModelTA> Students { get; set; } = new List<StudentModelTA>();

        public List<String> StudentsStringsComboBox { get; set; } = new List<string>();

        public List<String> StudentsStringsListBox { get; set; } = new List<string>();

        public AddCoursePage() {

            InitializeComponent();

            IDataConnector dataConnector = new MySqlConnector();

            Teachers = dataConnector.GetTeachers();
            LeadingTeacherComboBox.ItemsSource = Teachers.Select(x => $"{x.FirstName} {x.LastName} {x.EmailAddress}");

            Students = dataConnector.GetStudents();
            StudentsStringsComboBox = Students.Select(x => $"{x.FirstName} {x.LastName} {x.EmailAddress}").ToList();
            StudentsComboBox.ItemsSource = StudentsStringsComboBox;
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e) {

            if (StudentsStringsComboBox.Count > 0 && StudentsComboBox.SelectedItem != null) {
                StudentsStringsListBox.Add(StudentsComboBox.SelectedItem.ToString());
                StudentsStringsComboBox.Remove(StudentsComboBox.SelectedItem.ToString());
                Refresh();
            }
            else {
                MessageBox.Show("There are no students", "Error");
            }
        }

        private void Refresh() {

            StudentsComboBox.ItemsSource = null;
            StudentsListBox.ItemsSource = null;

            StudentsComboBox.ItemsSource = StudentsStringsComboBox;
            StudentsListBox.ItemsSource = StudentsStringsListBox;
        }

        private void RemoveStudentButton_Click(object sender, RoutedEventArgs e) {

            if (StudentsStringsListBox.Count > 0) {
                StudentsStringsComboBox.Add(StudentsListBox.SelectedItem.ToString());
                StudentsStringsListBox.Remove(StudentsListBox.SelectedItem.ToString());
                Refresh();
            }
            else {
                MessageBox.Show("There are no students", "Error");
            }
        }

        private void AddCourseButton_Click(object sender, RoutedEventArgs e) {
            if (ValidPage()) {

                List<StudentModelTA> students = new List<StudentModelTA>();

                foreach (string s in StudentsStringsListBox) {
                    StudentModelTA student = new StudentModelTA();
                    student.EmailAddress = s.Split(' ')[2];
                    students.Add(student);
                }

                CourseModelTA course = new CourseModelTA(NameOfTheCourseBox.Text, 
                    StartDatePicker.SelectedDate.Value.Date, 
                    EndDatePicker.SelectedDate.Value.Date,
                    students);

                IDataConnector dataConnector = new MySqlConnector();
                dataConnector.AddCourse(course, LeadingTeacherComboBox.Text.Split(' ')[2]);
            }
        }

        private bool ValidPage() {

            if (NameOfTheCourseBox.Text.Length == 0) {
                return false;
            }

            if (StartDatePicker.SelectedDate == null) {
                return false;
            }

            if (EndDatePicker.SelectedDate == null) {
                return false;
            }

            if (StartDatePicker.SelectedDate.Value.Date > EndDatePicker.SelectedDate.Value.Date) {
                return false;
            }

            if (LeadingTeacherComboBox.SelectedItem == null) {
                return false;
            }

            if (StudentsStringsListBox.Count == 0) {
                return false;
            }

            return true;
        }

    }
}
