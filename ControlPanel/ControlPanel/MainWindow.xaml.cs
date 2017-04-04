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
using ControlPanel.Models;

namespace ControlPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginModel model = null;
        ValidationModel validModel = null;
        public MainWindow()
        {
            InitializeComponent();
            this.model = new LoginModel();
            this.validModel = new ValidationModel();
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            registerWindow regwin = new registerWindow();
            regwin.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (validModel.checkLogin(loginBox.Text) && validModel.checkPassword(passwordBox.Password.ToString()))
                {
                    if (model.loginExist(loginBox.Text))
                    {
                        loggedWindow loggedWin = new loggedWindow(model.getID(loginBox.Text));
                        loggedWin.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email lub hasło są niepoprawne!");
                    }
                }
            }
            catch (Exception expect)
            {
                MessageBox.Show(expect.Message);
            }
        }
    }
}
