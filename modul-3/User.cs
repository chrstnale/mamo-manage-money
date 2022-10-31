using System;

namespace modul_3
{
    class User
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private float _balance;
        public int id { get { return _id; } }
        public string name 
        { 
            get { return _name; }
            set { _name = value; } 
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public float balance { get { return _balance; } }
        public void changeName(string name)
        {
            name = _name;
        }
    }
}
