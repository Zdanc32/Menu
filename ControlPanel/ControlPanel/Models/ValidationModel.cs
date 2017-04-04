using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ControlPanel.Models
{
    class ValidationModel
    {
        //sprawdzenie poprawnosci loginu
        public bool checkLogin(string login)
        {
            if(string.IsNullOrWhiteSpace(login))
            {
                throw new Exception("Podaj swój login");
            }
            else if (login.Length <= 3)
            {
                throw new Exception("Twój login jest zbyt krótki");
            }
            return true;
        }
        //sprawdzenie poprawnosci hasła
        public bool checkPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Podaj swoje hasło");
            }
            else if (password.Length < 4)
            {
                throw new Exception("Twoje hasło jest zbyt krótkie");
            }
            return true;
        }
        //sprawdzenie poprawnosci e-mail'a
        public bool checkEmail(string email)
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Podaj swój e-mail");
            }
            else if (!reg.IsMatch(email))
            {
                throw new Exception("Twój email nie posaida poprawnej formy zapisuje, sprawdz go jeszcze raz");
            }       
            return true;
        }
        //sprawdzenie poparawnosci numeru telefonu
        public bool checkPhoneNumber(string number)
        {
            Regex reg = new Regex(@"[0-9][0-9][0-9]+");
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new Exception("Podaj numer telefonu");
            }
            else if (!reg.IsMatch(number))
            {
                throw new Exception("Twój numer telefonu nie posiada poprawnej formy. Powinien zawierać tylko cyfry");
            }
            return true;
        }
        //sprawdzenie poprawnosci imienia
        public bool checkName(string name)
        {
            Regex reg = new Regex(@"[A-Z][a-z]+");
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Podaj swoje imię");
            }
            else if (name.Length <= 2)
            {
                throw new Exception("Twoje imie jest za krótkie");
            }
            else if (!reg.IsMatch(name))
            {
                throw new Exception("Twoje imie nie posiada poprawnej formy. Powinno zaczynac się z dużej litery, a także posiadać jedynie litery");
            }
            return true;
        }
        //sprawdzenie poprawnosci nazwiska
        public bool checkSurname(string surname)
        {
            Regex reg = new Regex(@"[A-Z][a-z]+");
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new Exception("Podaj swoje nazwisko");
            }
            else if (surname.Length <= 3)
            {
                throw new Exception("Twoje nazwisko jest za krótkie");
            }
            else if (!reg.IsMatch(surname))
            {
                throw new Exception("Twoje nazwisko nei posiada poprawnej formy. Powinno zaczynac się z dużej litery, a także posiadać jedynie litery");
            }
            return true;
        }
    }
}
