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
using SystemLibrary.AdminAccountModels;

namespace SystemUI.AdminUI {

    /// <summary>
    /// Logika interakcji dla klasy AdminMenuPage.xaml
    /// </summary>
    public partial class AdminMenuPage : Page {

        /// <summary>
        /// Represents admin which is logged in.
        /// </summary>
        public AdminModel Admin { get; set; }

        /// <summary>
        /// Initializes a new instance of the AdminMenuPage class, sets Admin
        /// property to logged admin and change AdminMenuOptions to AddStudentPage.
        /// </summary>
        /// <param name="admin">Admin which loged in.</param>
        public AdminMenuPage(AdminModel admin) {
            InitializeComponent();
            Admin = admin;
            AdminMenuOptions.Navigate(new AddStudentPage());
        }

        /// <summary>
        /// Change AdminMenuOptions to AddStudentPage.
        /// </summary>>
        private void AddStudentButton_Click(object sender, RoutedEventArgs e) {
            AdminMenuOptions.Navigate(new AddStudentPage());
        }

        /// <summary>
        /// Change AdminMenuOptions to AddTeacherPage.
        /// </summary>
        private void AddTeacherButton_Click(object sender, RoutedEventArgs e) {
            AdminMenuOptions.Navigate(new AddTeacherPage());
        }

        /// <summary>
        /// Change AdminMenuOptions to AddAdminPage.
        /// </summary>
        private void AddAdminButton_Click(object sender, RoutedEventArgs e) {
            AdminMenuOptions.Navigate(new AddAdminPage());
        }

        /// <summary>
        /// Change AdminMenuOptions to AddCoursePage.
        /// </summary>
        private void NewCourseButton_Click(object sender, RoutedEventArgs e) {
            AdminMenuOptions.Navigate(new AddCoursePage());
        }
    }
}
