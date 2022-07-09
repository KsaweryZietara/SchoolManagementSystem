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

namespace SystemUI.UsersUI {
    /// <summary>
    /// Logika interakcji dla klasy MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page {
        public MenuPage() {
            InitializeComponent();
            MenuOptions.NavigationService.Navigate(new StudentCoursesPage());
        }

        private void CoursesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new StudentCoursesPage());
        }

        private void ReceivedMessagesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new ReceivedMessagesPage());
        }

        private void SentMessagesButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new SentMessagesPage());
        }

        private void NewMessageButton_Click(object sender, RoutedEventArgs e) {
            MenuOptions.NavigationService.Navigate(new NewMessagePage());
        }
    }
}
