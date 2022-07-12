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
using SystemLibrary.CommonModels;
using SystemLibrary.DataAccess;
using SystemLibrary.TeacherAccountModels;

namespace SystemUI.TeacherUI {

    /// <summary>
    /// Logika interakcji dla klasy TeacherCoursesPage.xaml
    /// </summary>
    public partial class TeacherCoursesPage : Page {

        /// <summary>
        /// Represents teacher which is logged in.
        /// </summary>
        public TeacherModelTA Teacher { get; set; }

        /// <summary>
        /// Initializes a new instance of the TeacherCoursesPage class, sets Teacher property
        /// and populizes list box.
        /// </summary>
        /// <param name="teacher">Student which logged in.</param>
        public TeacherCoursesPage(TeacherModelTA teacher) {
            InitializeComponent();
            Teacher = teacher;

            IDataConnector dataConnector = new MySqlConnector();
            Teacher.Courses = dataConnector.GetTeacherCourses(Teacher.EmailAddress);

            CoursesListBox.ItemsSource = Teacher.Courses.Select(x => $"{x.Name}\t{x.StartDate}\t{x.EndDate}");
        }

        /// <summary>
        /// Populizes list view with students which attend to selected course.
        /// </summary>
        private void CoursesListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e) {

            StudentsListView.Items.Clear();

            var gridView = new GridView();
            StudentsListView.View = gridView;
            gridView.Columns.Add(new GridViewColumn {
                Header = "FirstName",
                DisplayMemberBinding = new Binding("FirstName")
            });
            gridView.Columns.Add(new GridViewColumn {
                Header = "LastName",
                DisplayMemberBinding = new Binding("LastName")
            });
            gridView.Columns.Add(new GridViewColumn {
                Header = "Grades",
                DisplayMemberBinding = new Binding("gradeString")
            });

            foreach (StudentModelTA student in Teacher.Courses[CoursesListBox.SelectedIndex].Students) {

                string gradeString = "";

                foreach (GradeModel grade in student.Grades) {
                    gradeString += Convert.ToInt32(grade.Value);
                    gradeString += ", ";
                }

                StudentsListView.Items.Add(new { student.FirstName, student.LastName, gradeString});
            }
        }

        /// <summary>
        /// Saves grade model to database and refreshes list view.
        /// </summary>
        private void AddGradeButton_Click(object sender, RoutedEventArgs e) {

            if (ValidPage()) {

                GradeModel grade = new GradeModel(NameTextBox.Text, Convert.ToInt32(ValueTextBox.Text));

                IDataConnector dataConnector = new MySqlConnector();
                dataConnector.CreateGrade(grade,
                    Teacher.Courses[CoursesListBox.SelectedIndex].Name,
                    Teacher.Courses[CoursesListBox.SelectedIndex].Students[StudentsListView.SelectedIndex].EmailAddress);

                Teacher.Courses[CoursesListBox.SelectedIndex].Students[StudentsListView.SelectedIndex].Grades.Add(grade);

                Refresh();
            }
            else {
                MessageBox.Show("Invalid grade", "Error");
            }

        }

        /// <summary>
        /// Fills list view with updated data.
        /// </summary>
        private void Refresh() {

            StudentsListView.ItemsSource = null;
            StudentsListView.Items.Clear();

            foreach (StudentModelTA student in Teacher.Courses[CoursesListBox.SelectedIndex].Students) {

                string gradeString = "";

                foreach (GradeModel grade in student.Grades) {
                    gradeString += Convert.ToInt32(grade.Value);
                    gradeString += ", ";
                }

                StudentsListView.Items.Add(new { student.FirstName, student.LastName, gradeString });
            }
        }

        /// <summary>
        /// Checks wheter the text boxes from page are valid.
        /// </summary>
        /// <returns>True if the text boxes form page are valid, false if not.</returns>
        private bool ValidPage() {

            if (StudentsListView.SelectedItem == null) {
                return false;
            }

            if (NameTextBox.Text.Length == 0) {
                return false;
            }

            if (ValueTextBox.Text.Length == 0) {
                return false;
            }

            int number;
            bool success = int.TryParse(ValueTextBox.Text, out number);

            if (!success) {
                return false;
            }

            if (number < 1) {
                return false;
            }

            if (number > 6) {
                return false;
            }

            return true;
        }
    }
}
