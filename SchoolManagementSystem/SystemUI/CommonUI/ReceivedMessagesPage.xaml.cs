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
    /// Logika interakcji dla klasy ReceivedMessagesPage.xaml
    /// </summary>
    public partial class ReceivedMessagesPage : Page {

        public UserModel User { get; set; }
        public ReceivedMessagesPage(UserModel user) {
            InitializeComponent();
            User = user;

            IDataConnector dataConnector = new MySqlConnector();
            
            User.Messages = dataConnector.GetReceivedMessages(user.EmailAddress);

            EmailsListBox.ItemsSource = User.Messages.Select(x => $"{x.SenderEmailAddress} {x.Title} {x.Date}");

            EmailText.Text = "From:\nTitle:";
        }

        private void EmailsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            EmailText.Text = $"From: {User.Messages[EmailsListBox.SelectedIndex].SenderEmailAddress}\nTitle: {User.Messages[EmailsListBox.SelectedIndex].Title}";
            EmailBox.Text = User.Messages[EmailsListBox.SelectedIndex].Content;
        }
    }
}
