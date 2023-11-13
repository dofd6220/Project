using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserDataClassLibrary
{
    public class Class1
    {
    }
    public class UserCredentials
    {
        public string UserId { get; set; }
        public string UserPass { get; set; }
        public string UserName { get; set; }

        public UserCredentials(string userId, string userPass, String userName)
        {
            UserId = userId;
            UserPass = userPass;
            UserName = userName;
        }
    }
}
