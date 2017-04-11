using System.Linq;
using ControlPanel.appData;
using ControlPanel.appData.Table;
using System.Security.Cryptography;

namespace ControlPanel.Models
{
    class LoginModel
    {
        
        UsersDataBase db = new UsersDataBase();

        //sprawdzenie czy dany login istnieje.
        public bool loginExist(string login)
        {
            var user = db.User.Where(u => u.Login == login);
            if (user.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkPassword(string password)
        {
            var user = db.User.Where(u => u.Password == password);
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
            return db.User.Where(u => u.Login == login).FirstOrDefault().Id;
        }

        //pobranie wybranego po ID użytkownika z bazy
        public User getUser(int id)
        {
            return db.User.Find(id);
        }

    }
}
