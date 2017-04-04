using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPanel.appData;
using ControlPanel.appData.Table;

namespace ControlPanel.Models
{
    class RegisterModel
    {
        UsersDataBase db = new UsersDataBase();

        //sprawdzenie czy dany email istnieje
        public bool emailExist(string email)
        {
            var user = db.User.Where(u => u.email == email);
            if (user.Any())
            {
                throw new Exception("podany adres e-mail jest juz zajęty!");
            }
            else
            {
                return false;
            }
        }

        //sprawdzenie czy dany login istnieje.
        public bool loginExist(string login)
        {
            var user = db.User.Where(u => u.login == login);
            if (user.Any())
            {
                throw new Exception("podany login jest juz zajęty!");
            }
            else
            {
                return false;
            }
        }
    }
}
