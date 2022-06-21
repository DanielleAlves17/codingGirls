using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07
{
    public class Login
    {
        private string _username;
        private string _password;

        public Login(string _username, string _password)
        {
            Username = _username;
            Password = _password;
        }

        public string Username
            { get { return _username; } set { _username = value; } }    
        public string Password 
            { get { return _password; } set { _password = value; } }
            

    }
}
