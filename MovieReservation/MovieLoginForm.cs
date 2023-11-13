using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDataClassLibrary;

namespace MovieReservation
{
    public partial class MovieLoginForm : Form
    {
        private List<UserCredentials> users;
        public MovieLoginForm(List<UserCredentials> userList)
        {
            InitializeComponent();
            users = userList;
            LoginBtn.Click += LoginBtn_Click;
            RegisterBtn.Click += RegisterBtn_Click;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String ID = IDtxt.Text;
            String PASS = PASStxt.Text;

            UserCredentials user = users.FirstOrDefault(u => u.UserId == ID);
            if (user != null && user.UserPass == PASS)
            {
                this.Visible = false;
                MovieTicketingForm ticketingForm = new MovieTicketingForm(users);
                ticketingForm.Show();
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호가 일치하지않습니다");
            }
        }
        private void RegisterBtn_Click(Object sender, EventArgs e)
        {
            this.Visible = false;
            MovieRegisterForm registerForm = new MovieRegisterForm(users);
            registerForm.Show();
        }
    }
}
