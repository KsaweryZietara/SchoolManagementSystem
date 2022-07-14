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
using SystemLibrary.DataAccess;
using SystemLibrary.StudentAccountModels;
using SystemLibrary.TeacherAccountModels;
using SystemUI.AdminUI;
using SystemUI.StudentUI;
using SystemUI.TeacherUI;


namespace SystemUI {

    /// <summary>
    /// Logika interakcji dla klasy LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page {

        /// <summary>
        /// Initializes a new instance of the LoginPage class.
        /// </summary>
        public LoginPage() {
            InitializeComponent();
        }

        /// <summary>
        /// Logs in student, teacher or admin according to selected radio button.
        /// </summary>
        private void LoginButton_Click(object sender, RoutedEventArgs e) {

            if (ValidPage()) {

                if (StudentButton.IsChecked == true) {

                    IDataConnector dataConnector = new MySqlConnector();

                    StudentModelSA student = dataConnector.ValidStudentPassword(LoginBox.Text, PasswordBox.Password);

                    if (student != null) {

                        var mw = Application.Current.Windows
                                .Cast<Window>()
                                .FirstOrDefault(window => window is MainWindow) as MainWindow;

                        mw.emailtextblock.Text = student.EmailAddress;

                        this.NavigationService.Navigate(new StudentMenuPage(student));
                    }
                    else {
                        MessageBox.Show("Invalid login or password", "Error");
                    }
                }

                if (TeacherButton.IsChecked == true) {
                    
                    IDataConnector dataConnector = new MySqlConnector();

                    TeacherModelTA teacher = dataConnector.ValidTeacherPassword(LoginBox.Text, PasswordBox.Password);

                    if (teacher != null) {

                        var mw = Application.Current.Windows
                               .Cast<Window>()
                               .FirstOrDefault(window => window is MainWindow) as MainWindow;

                        mw.emailtextblock.Text = teacher.EmailAddress;

                        this.NavigationService.Navigate(new TeacherMenuPage(teacher));
                    }
                    else {
                        MessageBox.Show("Invalid login or password", "Error");
                    }
                }

                if (AdminButton.IsChecked == true) {

                    IDataConnector dataConnector = new MySqlConnector();

                    AdminModel admin = dataConnector.ValidAdminPassword(LoginBox.Text, PasswordBox.Password);

                    if (admin != null) {

                        var mw = Application.Current.Windows
                               .Cast<Window>()
                               .FirstOrDefault(window => window is MainWindow) as MainWindow;

                        mw.emailtextblock.Text = admin.EmailAddress;

                        this.NavigationService.Navigate(new AdminMenuPage(admin));
                    }
                    else {
                        MessageBox.Show("Invalid login or password", "Error");
                    }
                }
            }
        }

        /// <summary>
        /// Checks wheter the text boxes from page are valid.
        /// </summary>
        /// <returns>True if the text boxes form page are valid, false if not.</returns>
        private bool ValidPage() {
            bool output = true;

            if (LoginBox.Text.Length == 0) {
                output = false;
            }

            if (PasswordBox.Password.Length == 0) {
                output = false;
            }

            return output;
        }
    }
}
