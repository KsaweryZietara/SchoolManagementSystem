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

namespace SystemUI.CommonUI {

    /// <summary>
    /// Logika interakcji dla klasy NewMessagePage.xaml
    /// </summary>
    public partial class NewMessagePage : Page {

        /// <summary>
        /// Represents user which is logged in.
        /// </summary>
        public IUserModel User { get; set; }

        /// <summary>
        /// Initializes a new instance of the NewMessagePage class, sets User property
        /// and fills combo box with emails.
        /// </summary>
        /// <param name="user">User which logged in.</param>
        public NewMessagePage(IUserModel user) {
            InitializeComponent();
            User = user;
            IDataConnector dataConnector = new MySqlConnector();
            EmailsComboBox.ItemsSource = dataConnector.GetUsersEmails();
        }

        /// <summary>
        /// Saves message to database.
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e) {

            if (ValidPage()) {
                MessageModel message = new MessageModel(User.EmailAddress, EmailsComboBox.Text, TitleBox.Text, ContentBox.Text);

                IDataConnector dataConnector = new MySqlConnector();
                dataConnector.CreateMessage(message);
            }
            else {
                MessageBox.Show("Fill all fields", "Error");
            }
        }

        /// <summary>
        /// Checks wheter the text boxes from page are valid.
        /// </summary>
        /// <returns>True if the text boxes form page are valid, false if not.</returns>
        private bool ValidPage() {
            bool output = true;

            if (EmailsComboBox.SelectedItem == null) {
                output = false;
            }

            if (TitleBox.Text.Length == 0) {
                output = false;
            }

            if (ContentBox.Text.Length == 0) {
                output = false;
            }

            return output;
        }
    }
}
