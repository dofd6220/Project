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
        private int maxSeats = 0;
        public SeatSelection(List<UserCredentials> userList)
        {
            users = userList;
            InitializeComponent();

            A1btn.Click += Button_Click;
            A2btn.Click += Button_Click;
            A3btn.Click += Button_Click;
            A4btn.Click += Button_Click;
            A5btn.Click += Button_Click;
            A6btn.Click += Button_Click;
            A7btn.Click += Button_Click;
            A8btn.Click += Button_Click;

            // B1 ~ B8 버튼
            B1btn.Click += Button_Click;
            B2btn.Click += Button_Click;
            B3btn.Click += Button_Click;
            B4btn.Click += Button_Click;
            B5btn.Click += Button_Click;
            B6btn.Click += Button_Click;
            B7btn.Click += Button_Click;
            B8btn.Click += Button_Click;

            // C1 ~ C8 버튼
            C1btn.Click += Button_Click;
            C2btn.Click += Button_Click;
            C3btn.Click += Button_Click;
            C4btn.Click += Button_Click;
            C5btn.Click += Button_Click;
            C6btn.Click += Button_Click;
            C7btn.Click += Button_Click;
            C8btn.Click += Button_Click;

            // D1 ~ D8 버튼
            D1btn.Click += Button_Click;
            D2btn.Click += Button_Click;
            D3btn.Click += Button_Click;
            D4btn.Click += Button_Click;
            D5btn.Click += Button_Click;
            D6btn.Click += Button_Click;
            D7btn.Click += Button_Click;
            D8btn.Click += Button_Click;

            // E1 ~ E8 버튼
            E1btn.Click += Button_Click;
            E2btn.Click += Button_Click;
            E3btn.Click += Button_Click;
            E4btn.Click += Button_Click;
            E5btn.Click += Button_Click;
            E6btn.Click += Button_Click;
            E7btn.Click += Button_Click;
            E8btn.Click += Button_Click;

            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            radioButton4.CheckedChanged += RadioButton_CheckedChanged;
            radioButton5.CheckedChanged += RadioButton_CheckedChanged;

            radioButton6.CheckedChanged += RadioButton_CheckedChanged;
            radioButton7.CheckedChanged += RadioButton_CheckedChanged;
            radioButton8.CheckedChanged += RadioButton_CheckedChanged;
            radioButton9.CheckedChanged += RadioButton_CheckedChanged;
            radioButton10.CheckedChanged += RadioButton_CheckedChanged;

            radioButton11.CheckedChanged += RadioButton_CheckedChanged;
            radioButton12.CheckedChanged += RadioButton_CheckedChanged;
            radioButton13.CheckedChanged += RadioButton_CheckedChanged;
            radioButton14.CheckedChanged += RadioButton_CheckedChanged;
            radioButton15.CheckedChanged += RadioButton_CheckedChanged;

            radioButton16.CheckedChanged += RadioButton_CheckedChanged;
            radioButton17.CheckedChanged += RadioButton_CheckedChanged;
            radioButton18.CheckedChanged += RadioButton_CheckedChanged;
            radioButton19.CheckedChanged += RadioButton_CheckedChanged;
            radioButton20.CheckedChanged += RadioButton_CheckedChanged;

            radioButton21.CheckedChanged += RadioButton_CheckedChanged;
            radioButton22.CheckedChanged += RadioButton_CheckedChanged;
            radioButton23.CheckedChanged += RadioButton_CheckedChanged;
            radioButton24.CheckedChanged += RadioButton_CheckedChanged;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton selectedRadioButton = (System.Windows.Forms.RadioButton)sender;
            /*if (int.Parse(selectedRadioButton.Text) < maxSeats)
            {
                MessageBox.Show("선택한 좌석이 얘매 인원 보다 많습니다.");
                return;
            }*/
            SeatNameChecking();
            if (selectedRadioButton.Checked)
            {
                SeatName.Text += selectedRadioButton.Text;
                SeatCnt(selectedRadioButton.Text);
            }
            else if(radioButton26.Checked)
            {
                SeatName.Text += radioButton26.Text;
                SeatCnt(radioButton26.Text);
            }

        }
        private void SeatNameChecking()
        {
            if(radioButton1.Checked ||  radioButton2.Checked ||
                radioButton3.Checked || radioButton4.Checked ||
                    radioButton5.Checked) 
            {
                SeatName.Text = "수험표 ";
            }
            else if (radioButton6.Checked || radioButton7.Checked ||
                radioButton8.Checked || radioButton9.Checked ||
                    radioButton10.Checked)
            {
                SeatName.Text = "일반 ";
            }
            else if (radioButton11.Checked || radioButton12.Checked ||
                radioButton13.Checked || radioButton14.Checked ||
                    radioButton15.Checked)
            {
                SeatName.Text = "청소년 ";
            }
            else if (radioButton16.Checked || radioButton17.Checked ||
                radioButton18.Checked || radioButton19.Checked ||
                    radioButton20.Checked)
            {
                SeatName.Text = "우대 ";
            }
            else if (radioButton21.Checked || radioButton22.Checked ||
                radioButton23.Checked || radioButton24.Checked ||
                    radioButton25.Checked)
            {
                SeatName.Text = "경로 ";
            }
            else if (radioButton26.Checked)
            {
                SeatName.Text = "ALL ";
            }
        }
        private void UpdateSeatNumText()
        {
            seats.Sort();
            SeatNumtxt.Text = string.Join(" ", seats);
        }

        private void SeatCnt(String radioButtonValue)
        {
            maxSeats = int.Parse(radioButtonValue);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string seatNumber = btn.Name.Substring(0, 2);
            if (btn.BackColor != Color.Red && seats.Count < maxSeats)
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
                seats.Add(seatNumber);
            }
            else
            {
                btn.BackColor = default;
                btn.ForeColor = default;
                seats.Remove(seatNumber);
            }
            UpdateSeatNumText();
        }
    }
}
