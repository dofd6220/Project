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
    public partial class SeatSelection : Form
    {
        private List<UserCredentials> users;
        private List<string> seats = new List<string>();
        public SeatSelection(List<UserCredentials> userList)
        {
            users = userList;
            InitializeComponent();
            A1btn.Click += A1btn_Click;
            A2btn.Click += A2btn_Click;
        }
        private void UpdateSeatNumText()
        {
            seats.Sort();
            SeatNumtxt.Text = string.Join(" ", seats);
        }
        
        


        private void A1btn_Click(object sender, EventArgs e)
        {
            if(A1btn.BackColor != Color.Red)
            {
                A1btn.BackColor = Color.Red;
                A1btn.ForeColor = Color.White;
                seats.Add("A1");
            }
            else    
            {
                A1btn.BackColor = default;
                A1btn.ForeColor = default;
                seats.Remove("A1");
            }
            UpdateSeatNumText();
        }
        private void A2btn_Click(object sender, EventArgs e)
        {
            if (A2btn.BackColor != Color.Red)
            {
                A2btn.BackColor = Color.Red;
                A2btn.ForeColor = Color.White;
                seats.Add("A2");
            }
            else 
            {
                A2btn.BackColor = default;
                A2btn.ForeColor = default;
                seats.Remove("A2");
            }
            UpdateSeatNumText();
        }
    }
}
