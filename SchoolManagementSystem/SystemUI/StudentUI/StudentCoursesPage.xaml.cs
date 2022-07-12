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
using SystemLibrary.StudentAccountModels;

namespace SystemUI.StudentUI {

    /// <summary>
    /// Logika interakcji dla klasy StudentCoursesPage.xaml
    /// </summary>
    public partial class StudentCoursesPage : Page {

        /// <summary>
        /// Represents student which is logged in.
        /// </summary>
        public StudentModelSA Student { get; set; }

        /// <summary>
        /// Initializes a new instance of the StudentCoursesPage class, sets Student property
        /// and populizes list view.
        /// </summary>
        /// <param name="student">Student which logged in.</param>
        public StudentCoursesPage(StudentModelSA student) {
            
            InitializeComponent();
            Student = student;

            IDataConnector dataConnector = new MySqlConnector();
            Student.Courses = dataConnector.GetStudentCourses(Student.EmailAddress);

            CoursesListView.ItemsSource = null;
            CoursesListView.Items.Clear();

            var gridView = new GridView();
            CoursesListView.View = gridView;

            gridView.Columns.Add(new GridViewColumn {
                Header = "CourseName",
                DisplayMemberBinding = new Binding("Name")
            });
            gridView.Columns.Add(new GridViewColumn {
                Header = "Grades",
                DisplayMemberBinding = new Binding("gradeString")
            });

            foreach (CourseModelSA course in Student.Courses) {
                
                string gradeString = "";

                foreach (GradeModel grade in course.Grades) {
                    gradeString += Convert.ToInt32(grade.Value);
                    gradeString += ", ";
                }

                CoursesListView.Items.Add(new { course.Name,  gradeString });
            }
        }
    }
}
