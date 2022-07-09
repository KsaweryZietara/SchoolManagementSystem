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

namespace SystemUI.AdminUI {
    /// <summary>
    /// Logika interakcji dla klasy AdminMenuPage.xaml
    /// </summary>
    public partial class AdminMenuPage : Page {
        public AdminMenuPage() {
            InitializeComponent();
            AdminMenuOptions.Navigate(new AddStudentPage());
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e) {
            AdminMenuOptions.Navigate(new AddStudentPage());
        }

        private void AddTeacherButton_Click(object sender, RoutedEventArgs e) {
            AdminMenuOptions.Navigate(new AddTeacherPage());
        }

        private void AddAdminButton_Click(object sender, RoutedEventArgs e) {
            AdminMenuOptions.Navigate(new AddAdminPage());
        }

        private void NewCourseButton_Click(object sender, RoutedEventArgs e) {
            AdminMenuOptions.Navigate(new AddCoursePage());
        }
    }
}
