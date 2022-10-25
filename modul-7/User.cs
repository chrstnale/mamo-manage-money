using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_7
{
    class User
    {
        private int _userID;
        private string _loginName;
        private string _password;
        private int _securityLevel;

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int SecurityLevel
        {
            get { return _securityLevel; }
        }

        public User() { }

        public User(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;


        }
        public bool Login()
        {
            if (LoginName == "Ale" & Password == "hehe")
            {
                UserID = 1;
                return true;
            }
            else if (LoginName == "Hapsari" & Password == "haha")
            {
                UserID = 2;
                return true;
            }
            else if (LoginName == "Farras" & Password == "hihi")
            {
                UserID = 3;
                return true;
            }
            else
            {
                return false;
            }
        }


        public Boolean Login(string loginName, string password)
        {
            if (LoginName == "Ale" & Password == "hehe")
            {
                _userID = 1;
                _securityLevel = 2;
                return true;
            }
            else if (LoginName == "Hapsari" & Password == "haha")
            {
                _userID = 2;
                _securityLevel = 4;
                return true;
            }
            else if (LoginName == "Farras" & Password == "hihi")
            {
                _userID = 3;
                _securityLevel = 4;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
