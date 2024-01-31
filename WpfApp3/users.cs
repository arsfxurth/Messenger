using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    internal class users
    {
        public string Name { get; set; }
        public List<string> Messages { get; set; }
        public string Password;
        public string Login;
        public users(string name, string login, string password)
        {
            Name = name;
            Password = password;
            Login = login;
            Messages = new List<string>();
        }
    }
}
