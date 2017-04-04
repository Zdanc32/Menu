using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPanel.appData;
using ControlPanel.appData.Table;

namespace ControlPanel.Models
{
    class LoginModel
    {

        UsersDataBase db = new UsersDataBase();

        //sprawdzenie czy dany login istnieje.
        public bool loginExist(string login)
        {
            var user = db.User.Where(u => u.login == login);
            if (user.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //pobranie ID użytkownika z bazy danych wykorzystujac login
        public int getID(string login)
        {
            return db.User.Where(u => u.login == login).FirstOrDefault().id;
        }

        //pobranie wybranego po ID użytkownika z bazy
        public User getUser(int id)
        {
            return db.User.Find(id);
        }

    }
}
