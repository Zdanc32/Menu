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
using ControlPanel.appData;
using ControlPanel.appData.Table;
using ControlPanel.Models;
using System.Security.Cryptography;

namespace ControlPanel
{
    /// <summary>
    /// Interaction logic for registerWindow.xaml
    /// </summary>
    public partial class registerWindow : Window
    {
        UsersDataBase db = null;
        RegisterModel model = null;
        ValidationModel validModel = null;
        MD5 md5Hash = null;
        public registerWindow()
        {
            InitializeComponent();
            model = new RegisterModel();
            validModel = new ValidationModel();
            md5Hash = MD5.Create();
            db = new UsersDataBase();
        }

        private async void createButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (validModel.checkLogin(loginBox.Text) && validModel.checkEmail(emailBox.Text) && validModel.checkName(nameBox.Text) && validModel.checkSurname(surnameBox.Text) && validModel.checkPhoneNumber(phoneBox.Text) && validModel.checkPassword(passwordBox.Password.ToString()))
                {
                    if (!model.emailExist(emailBox.Text) && !model.loginExist(loginBox.Text))
                    {
                        MainWindow mainWin = new MainWindow();
                        mainWin.Show();
                        this.Close();
                        User user = new User()
                        {
                            login = loginBox.Text,
                            email = emailBox.Text,
                            name = nameBox.Text,
                            surname = surnameBox.Text,
                            phoneNumber = phoneBox.Text,
                            password = model.GetMd5Hash(md5Hash, passwordBox.Password.ToString())
                        };
                        db.User.Add(user);
                        await db.SaveChangesAsync();
                    }
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }

        }


        private void retrunButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Close();
        }
    }
}