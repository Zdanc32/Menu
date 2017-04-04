using System;
using System.Linq;
using System.Text;
using ControlPanel.appData;
using System.Security.Cryptography;

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

        public string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

    }
}
