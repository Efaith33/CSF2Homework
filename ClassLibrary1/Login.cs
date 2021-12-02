using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Login
    {
        //frugal / fields
        private string _userName;
        private string _passWord;

        //people / properties
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }

        //collect / constructors
        public Login() { }
        public Login(string userName, string passWord)
        {
            UserName = userName;
            PassWord = passWord;
        }

        //money / methods
        public override string ToString()
        {
            return string.Format("{0}\n" + "{1}");
        }
    }
}






