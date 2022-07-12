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
using SystemLibrary.TeacherAccountModels;
using SystemUI.CommonUI;

namespace SystemUI.TeacherUI {

    /// <summary>
    /// Logika interakcji dla klasy TeacherMenuPage.xaml
    /// </summary>
    public partial class TeacherMenuPage : Page {

        /// <summary>
        /// Represents teacher which is logged in.
        /// </summary>
        public TeacherModelTA Teacher { get; set; }

        /// <summary>
        /// Initializes a new instance of the TeacherMenuPage class, sets Teacher
        /// property to logged teacher and change MenuOptions to TeacherCoursesPage.
        /// </summary>
        /// <param name="teacher">Teacher which is logged in.</param>
        public TeacherMenuPage(TeacherModelTA teacher) {
            InitializeComponent();
            Teacher = teacher;
            MenuOptions.NavigationService.Navigate(new TeacherCoursesPage(Teacher));
        }

        /// <summary>
        /// Change MenuOptions to TeacherCoursesPage.
        /// </summary>
        private void CoursesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new TeacherCoursesPage(Teacher));
        }

        /// <summary>
        /// Change MenuOptions to ReceivedMessagesPage.
        /// </summary>
        private void ReceivedMessagesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new ReceivedMessagesPage(Teacher));
        }

        /// <summary>
        /// Change MenuOptions to SentMessagesPage.
        /// </summary>
        private void SentMessagesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new SentMessagesPage(Teacher));
        }

        /// <summary>
        /// Change MenuOptions to NewMessagePage.
        /// </summary>
        private void NewMessageButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new NewMessagePage(Teacher));
        }
    }
}
