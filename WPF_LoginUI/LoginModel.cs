using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginUI
{
    public class LoginModel
    {
        private string username;
        private string password;

        //Property Binding
        public string Username
        {
            set
            {
                username = value;
            }
            get { return username; }
        }
        public string Password
        {
            set
            {
                password = value;
            }
            get { return password; }
        }
    }
}
