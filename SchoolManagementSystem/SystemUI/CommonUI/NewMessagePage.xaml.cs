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
        public UserModel User { get; set; }

        public NewMessagePage(UserModel user) {
            InitializeComponent();
            User = user;
            IDataConnector dataConnector = new MySqlConnector();
            EmailsComboBox.ItemsSource = dataConnector.GetUsersEmails();
        }

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
