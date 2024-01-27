using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegistrationApp
{
    public class FieldValidator
    {
        private  Regex _loginRegex;
        private Regex _passwordRegex;
        private Regex _emailRegex;
        private Regex _nameRegex;
        private Regex _phoneRegex;
        public FieldValidator()
        {
            _loginRegex = new Regex("[\\w\\d-_.]{4,24}$");
            _passwordRegex = new Regex("(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[-_])[a-zA-Z0-9_-]{8,64}$");
            _emailRegex = new Regex("^[\\w\\d\\.\\-\\+]{1,24}\\@[a-z]{1,10}\\.[a-z]{2,8}$");
            _phoneRegex = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
            _nameRegex = new Regex("^[A-ZА-Я][a-zа-я]{1,31}$");
        }
        public bool IsValidLogin(string login) =>_loginRegex.IsMatch(login);
        public bool IsValidPassword(string password)=>_passwordRegex.IsMatch(password);
        public bool IsValidPhoneNumber(string phoneNumber) =>_phoneRegex.IsMatch(phoneNumber);
        public bool IsValidEmail(string email) => _emailRegex.IsMatch(email);
        public bool IsValidName(string name)=>_nameRegex.IsMatch(name);
    }
}
