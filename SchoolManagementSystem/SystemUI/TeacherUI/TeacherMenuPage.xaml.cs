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

        public TeacherModelTA Teacher { get; set; }

        public TeacherMenuPage(TeacherModelTA teacher) {
            InitializeComponent();
            Teacher = teacher;
            MenuOptions.NavigationService.Navigate(new TeacherCoursesPage());
        }

        private void CoursesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new TeacherCoursesPage());
        }

        private void ReceivedMessagesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new ReceivedMessagesPage(Teacher));
        }

        private void SentMessagesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new SentMessagesPage(Teacher));
        }

        private void NewMessageButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new NewMessagePage(Teacher));
        }
    }
}
