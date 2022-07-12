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

        /// <summary>
        /// Represents user which is logged in.
        /// </summary>
        public IUserModel User { get; set; }

        /// <summary>
        /// Initializes a new instance of the ReceivedMessagesPage class, sets User property
        /// and poplizes the list box.
        /// </summary>
        /// <param name="user">User which logged in.</param>
        public ReceivedMessagesPage(IUserModel user) {
            InitializeComponent();
            User = user;

            IDataConnector dataConnector = new MySqlConnector();
            
            User.Messages = dataConnector.GetReceivedMessages(user.EmailAddress);

            EmailsListBox.ItemsSource = User.Messages.Select(x => $"{x.SenderEmailAddress} {x.Title} {x.Date}");

            EmailText.Text = "From:\nTitle:";
        }

        /// <summary>
        /// Fills email text label and email text box.
        /// </summary>
        private void EmailsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            EmailText.Text = $"From: {User.Messages[EmailsListBox.SelectedIndex].SenderEmailAddress}\nTitle: " +
                $"{User.Messages[EmailsListBox.SelectedIndex].Title}";
            EmailBox.Text = User.Messages[EmailsListBox.SelectedIndex].Content;
        }
    }
}
