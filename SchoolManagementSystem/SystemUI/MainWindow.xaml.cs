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
using SystemLibrary.DataAccess;

namespace SystemUI {

    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        /// <summary>
        /// Initializes a new instance of the MainWindow class and
        /// change Main to LoginPage.
        /// </summary>
        public MainWindow() {
            InitializeComponent();
            Main.NavigationService.Navigate(new LoginPage());
        }
    }
}
