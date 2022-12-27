using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace hmw
{
    internal class User
    {
        private string _username;
        private string _password;
        public User(string UserName, string Password)
        {
            UserName = _username;
            Password = _password;
        }
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                    _username = value;
            }
        }
            
        public string Password
        {
            get 
            {
            return _password;
            }
            set 
            {
                if(value.Length>=8 && value.Length<=25)
                    _password = value;
            }
        }
        public string GetInfo()
        {
            return $"UserName: {_username} - Password: {_password}";
        }
        public bool HasUpper(string _password)
        {


            for (int i = 1; i < _password.Length; i++)
            {
                if (!Char.IsUpper(_password[i]))
                    return false;
            }

            return true;
        }
            public bool HasLower(string _password)
            {
                for (int i = 1; i < _password.Length; i++)
                {
                    if (!Char.IsLower(_password[i]))
                        return false;
                }
                return true;
            }
        public bool HasDigit(string _password)
        {
            for (int i = 0; i < _password.Length; i++)
            {
                if (IsDigit(_password[i]))
                {
                    return true;
                }
            }

            return false;
        }


    }




    }
}
