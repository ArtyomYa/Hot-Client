using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hot
{
    class LoginID
    {
        static int login_num;
        public static void setLoginNum(int n)
        {
            login_num = n;
        }
        public static int getLoginNum()
        {
            return login_num;
        }
    }
}
