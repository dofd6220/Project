using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDataClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieReservation
{
    public partial class MovieRegisterForm : Form
    {
        private List<UserCredentials> userList;
        public MovieRegisterForm(List<UserCredentials> users)
        {
            InitializeComponent();
            userList = users;
            Registerbtn.Click += Register_Btn;
        }
        private void Register_Btn(object sender, EventArgs e)
        {
            String UserId = IDtxt.Text;
            String UserPass = PASStxt.Text;
            String UserName = Nametxt.Text;
            userList.Add(new UserCredentials(UserId, UserPass, UserName));

            this.Visible = false;
            MovieLoginForm frm = new MovieLoginForm(userList);
            frm.ShowDialog();
        }
    }
}
