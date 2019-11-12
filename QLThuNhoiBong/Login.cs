using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuNhoiBong
{
    class Login
    {
        private string user;
        private string password;
        public Login()
        {
            user = null;
            password = null;

        }
        public Login(string _user,string _password)
        {
            user = _user;
            password = _password;

        }
      public  string getUser { get => user; set => user = value; }
      public  string getPassword { get => password; set => password = value; }

    }
}
