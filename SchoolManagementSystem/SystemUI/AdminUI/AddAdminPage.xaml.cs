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
using SystemLibrary;
using SystemLibrary.AdminAccountModels;
using SystemLibrary.DataAccess;

namespace SystemUI.AdminUI {

    /// <summary>
    /// Logika interakcji dla klasy AddAdminPage.xaml
    /// </summary>
    public partial class AddAdminPage : Page {

        /// <summary>
        /// Initializes a new instance of the AddAdminPage class.
        /// </summary>
        public AddAdminPage() {
            InitializeComponent();
        }

        /// <summary>
        /// Saves admin account to database.
        /// </summary>
        private void AddAdminButton_Click(object sender, RoutedEventArgs e) {
            if (ValidPage()) {

                AdminModel admin = new AdminModel(FirstNameTextBox.Text,
                    LastNameTextBox.Text,
                    EmailAddressTextBox.Text,
                    PasswordTextBox.Password.PasswordHashing());

                IDataConnector dataConnector = new MySqlConnector();
                dataConnector.AddAdmin(admin);
            }
        }

        /// <summary>
        /// Checks wheter the text boxes from page are valid.
        /// </summary>
        /// <returns>True if the text boxes form page are valid, false if not.</returns>
        private bool ValidPage() {

            bool output = true;

            if (FirstNameTextBox.Text.Length == 0) {
                output = false;
            }

            if (LastNameTextBox.Text.Length == 0) {
                output = false;
            }

            if (EmailAddressTextBox.Text.Length == 0) {
                output = false;
            }

            int indexOfAt = EmailAddressTextBox.Text.IndexOf('@');
            int indexOfDot = EmailAddressTextBox.Text.IndexOf('.');

            if (indexOfAt < 0 || indexOfDot < 0) {
                output = false;
            }

            if (indexOfAt > indexOfDot) {
                output = false;
            }

            if (indexOfDot > EmailAddressTextBox.Text.Length - 4) {
                output = false;
            }

            if (PasswordTextBox.Password.Length == 0) {
                output = false;
            }

            return output;
        }
    }
}
