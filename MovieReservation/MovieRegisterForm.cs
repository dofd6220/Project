﻿using System;
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
            userList = users;

            InitializeComponent();
            UpdateData();
            Registerbtn.Click += Register_Btn;
        }
        private void UpdateData()
        {
            int count = userList.Count;
            for (int i = 0; i < count; i++)
            {
                if(userList != null)
                {
                IDtxt.Text = userList[i].UserId;
                PASStxt.Text = userList[i].UserPass;
                PASSextxt.Text = userList[i].UserPass;
                Nametxt.Text = userList[i].UserName;
                }
            }
        }
        private void Register_Btn(object sender, EventArgs e)
        {
            String UserId = IDtxt.Text;
            String UserPass = PASStxt.Text;
            String UserPassex = PASSextxt.Text;
            String UserName = Nametxt.Text;

            int result = RegisterCheck(UserId, UserPass, UserPassex);

            if (result == 1)
            {
                MessageBox.Show("회원가입 성공");
                userList.Add(new UserCredentials(UserId, UserPass, UserName));
                this.Visible = false;
                MovieLoginForm frm = new MovieLoginForm(userList);
                frm.ShowDialog();
            }

            else if (result == 0)
            {
                MessageBox.Show("비밀번호가 틀립니다.");
            }
            else if(result == -1)
            {
                MessageBox.Show("빈칸을 입력해주세요.");
            }
        }

        private int RegisterCheck(string userId, string userPass, string userPassEx)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(userPass) || string.IsNullOrEmpty(userPassEx))
            {
                return -1;
            }
            else
            {
                return userPass.Equals(userPassEx) ? 1 : 0;
            }
        }
    }
}
