using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserDataClassLibrary
{
    public class UserCredentials
    {
        public string UserId { get; set; }
        public string UserPass { get; set; }
        public string UserName { get; set; }

        public UserCredentials(string userId, string userPass, string userName)
        {
            UserId = userId;
            UserPass = userPass;
            UserName = userName;
        }
    }

    public class MovieCredentials
    {
        public string MovieTitle { get; set; }
        public string Theater { get; set; }
        public string Date { get; set; }
        public string Hourse { get; set; }

        public string MovieTime { get; set; }

        public string GroupText { get; set; }
        public MovieCredentials(string movieTitle, string theater, string date, string hourse, string movieTime, string groupText)
        {
            MovieTitle = movieTitle;
            Theater = theater;
            Date = date;
            Hourse = hourse;
            MovieTime = movieTime;            GroupText = groupText;

        }
    }
}

