using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDataClassLibrary;

namespace MovieReservation
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<UserCredentials> userList = new List<UserCredentials>();
            List<MovieCredentials> movieList = new List<MovieCredentials>();

            /*Application.Run(new MovieLoginForm(userList));*/
            Application.Run(new MovieTicketingForm(userList));
            // git 테스트
        }
    }

}
