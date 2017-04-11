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
using System.Windows.Shapes;
using ControlPanel.Models;
using ControlPanel.appData.Table;

namespace ControlPanel
{
    /// <summary>
    /// Interaction logic for loggedWindow.xaml
    /// </summary>
    public partial class loggedWindow : Window
    {
        private int id; 
        private User user = null;
        LoginModel model = null;
        public loggedWindow(int id)
        {

            InitializeComponent();
            this.model = new LoginModel();
            this.id = id;
            this.user = model.getUser(id);
            loginLabel.Content = "Witaj, " + user.Login;
            nameLabel.Content = "Imię: \t\t\t" + user.Name;
            surnameLabel.Content = "Nazwisko: \t\t" + user.Surname;
            phoneNumberLabel.Content = "Numer telefonu: \t\t" + user.PhoneNumber;
            emailLabel.Content = "E-mail: \t\t\t" + user.Email;
            
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.user = null;
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Close();
        }
    }
}
