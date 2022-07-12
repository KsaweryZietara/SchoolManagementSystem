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
using SystemLibrary.StudentAccountModels;
using SystemUI.CommonUI;

namespace SystemUI.StudentUI {

    /// <summary>
    /// Logika interakcji dla klasy MenuPage.xaml
    /// </summary>
    public partial class StudentMenuPage : Page {

        /// <summary>
        /// Represents student which is logged in.
        /// </summary>
        public StudentModelSA Student { get; set; }

        /// <summary>
        /// Initializes a new instance of the StudentMenuPage class, sets Student
        /// property to logged student and change MenuOptions to StudentCoursesPage.
        /// </summary>
        /// <param name="student">Student which is logged in.</param>
        public StudentMenuPage(StudentModelSA student) {
            InitializeComponent();
            Student = student;
            MenuOptions.NavigationService.Navigate(new StudentCoursesPage(Student));
        }

        /// <summary>
        /// Change MenuOptions to StudentCoursesPage.
        /// </summary>
        private void CoursesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new StudentCoursesPage(Student));
        }

        /// <summary>
        /// Change MenuOptions to ReceivedMessagesPage.
        /// </summary>
        private void ReceivedMessagesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new ReceivedMessagesPage(Student));
        }

        /// <summary>
        /// Change MenuOptions to SentMessagesPage.
        /// </summary>
        private void SentMessagesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new SentMessagesPage(Student));
        }

        /// <summary>
        /// Change MenuOptions to NewMessagePage.
        /// </summary>
        private void NewMessageButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new NewMessagePage(Student));
        }
    }
}
