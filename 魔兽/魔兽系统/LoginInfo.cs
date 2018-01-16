using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 魔兽系统
{
    public class LoginInfo
    {
        //email
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //id
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //用户名
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //密码
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}
